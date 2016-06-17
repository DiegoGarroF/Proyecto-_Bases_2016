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
namespace ProyectoBase
{
    public partial class frmRoles : Form
    {
        clsConexion conexion;
        clsEntidadRol entidadRol;
        SqlDataReader strRol;
        String strPantalla;
        clsRol clRol;

        public frmRoles()
        {
            conexion = new clsConexion();
            entidadRol = new clsEntidadRol();
            clRol = new clsRol();
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


        public void llenadoPantalla()
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
    }
}
