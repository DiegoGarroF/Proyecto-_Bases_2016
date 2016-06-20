using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;
using System.Data.SqlClient;

namespace Vista
{
    public partial class frmRoles : Form
    {
        clsConexion conexion;
        clsEntidadRol entidadRol;
        clsPantalla pantalla;
        SqlDataReader strRol;
        String strPantalla;
        clsRol clRol;
        private SqlDataReader dtrPantalla;
        private frmMenuPrincipal menuPrincipal;

        public frmRoles(frmMenuPrincipal menu)
        {
            conexion = new clsConexion();
            entidadRol = new clsEntidadRol();
            clRol = new clsRol();
            this.menuPrincipal = menu;
            pantalla = new clsPantalla();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreRol.Text != "")
            {
               
                entidadRol.mNombreRol = txtNombreRol.Text;
                clRol.mInsertarRol(conexion,entidadRol);
            }
            else
            {
                MessageBox.Show("Seleccione un rol válido", "Rol no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

               
             if ((mValidarInformacionRoles() == true & mValidarPermisos(lvPantalla) == true))
                {
                    //Se realiza inserción de roles y privilegios directos
                    if (mValidarPermisos(lvPantalla) == true)
                    {
                    if (cbPantalla.Text != null)
                    {
                        if (clRol.mInsertarRol(conexion, entidadRol))
                        {
                            MessageBox.Show("Se ha insertado el rol", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al insertar el rol", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    }
                }
                else
                {
                    MessageBox.Show("Información insuficiente para agregar un rol", "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


        }// fin del metodo


        public Boolean mValidarInformacionRoles()
        {
            if (txtNombreRol.Text != "")
            {
                return true;
            }
            return false;
        }

        //Valida que al menos se vaya a insertar un rol o un privilegio
        public Boolean mValidarPermisos(ListView lista)
        {
            if (lista.Items.Count > 0)
            {
                return true;
            }

            return false;
        }

        public void limpiar()
        {
           
            txtNombreRol.Text = "";
            cbPantalla.SelectedIndex = -1;
            lvPantalla.Items.Clear();
            

            chkConsultar.Checked = false;
            chkEliminar.Checked = false;
            chkInsertar.Checked = false;
            chkModificar.Checked = false;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            mModificarRol();
        }


        public Boolean verificarNombre()
        {
            if (!this.txtNombreRol.Text.Trim().Equals(""))
                return true;
            return false;
        }


        public void llenadoPantalla() //Para que este método?
        {
            strRol = clRol.mConsultarRoles(conexion);
            while (strRol.Read())
            {
                ListViewItem lista;
                lista = lvPantalla.Items.Add(strRol.GetString(0));
            }
        }



      
        public void mModificarRol()
        {
            if (!verificarNombre()&& lvPantalla != null)
            {
                btnQuitarPantalla.Enabled = true;
                
                if(strRol!=null)
                {
                    entidadRol.mNombreRol = txtNombreRol.Text;
                }
               
            }
            else
            {
                MessageBox.Show("No digitó el nombre del rol ", "No se pudo modificar", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void lvPantalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvPantalla.Items.Count; i++)
            {
                if (lvPantalla.Items[i].Selected)
                {
                    strPantalla = lvPantalla.Items[i].Text;
                }
            }
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            dtrPantalla = pantalla.mConsultarPantallas(conexion);
            if (dtrPantalla != null)
                while (dtrPantalla.Read())
                {
                    cbPantalla.Items.Add(dtrPantalla.GetSqlString(0));

                }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal.Show();
        }

        private void btnAgregarPrivilegios_Click(object sender, EventArgs e)
        {
            if ((verificarNombre()==true) &(cbPantalla.Text!=""))
            {
                if (verificarRolPantallaLista(lvPantalla, txtNombreRol.Text, cbPantalla.Text))
                {
                    ListViewItem item = new ListViewItem(txtNombreRol.Text);
                    item.SubItems.Add(cbPantalla.Text);
                    if (chkInsertar.Checked == true)
                    {
                        item.SubItems.Add("Sí");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }

                    if (chkConsultar.Checked == true)
                    {
                        item.SubItems.Add("Sí");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }

                    if (chkModificar.Checked == true)
                    {
                        item.SubItems.Add("Sí");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }

                    if (chkEliminar.Checked == true)
                    {
                        item.SubItems.Add("Sí");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }
                    lvPantalla.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("Únicamente se puede insertar un rol a la vez, Quizá este rol ya fue asignado a esta pantalla", "Tenga en cuenta lo siguiente:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Datos insuficientes","Falta información",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }

        public Boolean verificarRolPantallaLista(ListView lista, string rol, string pantalla)
        {
            Boolean estado = true;
            foreach (ListViewItem I in lista.Items)
            {
                if (((I.SubItems[0].Text == rol)&((I.SubItems[1].Text ==pantalla))) ||(I.SubItems[0].Text!=rol))
                {
                    Console.WriteLine("NO Pruede agregar");
                    return false;
                }
            }
            return estado;
        }

        //Retorna el rol o pantalla seleccionada de un listview
        public int itemSeleccion(ListView lista) //Usar solo 1 método
        {
            for (int i = 0; i < lista.Items.Count; i++)
            {
                if (lista.Items[i].Selected)
                {
                    return lista.Items[i].Index;
                }
            }
            return -1;
        }

        private void btnQuitarPantalla_Click(object sender, EventArgs e)
        {
            if (itemSeleccion(lvPantalla) != -1)
            {
                lvPantalla.Items.RemoveAt(itemSeleccion(lvPantalla));

            }
            else
            {
                MessageBox.Show("Seleccione un item válido", "No se ha seleccionado nada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
