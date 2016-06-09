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
    public partial class frmUsuario : Form
    {
        private clsEntidadUsuario entidadUsuario;
        private clsUsuario usuario;
        private SqlDataReader dtrUsuario;
        private SqlDataReader dtrRol;     
        private clsConexion conexion;
        private clsEntidadRol entidadRol;
        private clsRol rol;       

        private clsPantalla pantalla;
        private clsEntidadPantalla entidadPantalla;
        private SqlDataReader dtrPantalla;

        private frmMenuPrincipal menu;
        public frmUsuario(frmMenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.menu = menuPrincipal;
            entidadUsuario = new clsEntidadUsuario();
            usuario = new clsUsuario();
            conexion = new clsConexion();

            entidadRol = new clsEntidadRol();
            rol = new clsRol();

            entidadPantalla = new clsEntidadPantalla();
            pantalla = new clsPantalla();

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            
            dtrUsuario = pantalla.mConsultarPantallas(conexion);
            if(dtrUsuario!=null)
            while (dtrUsuario.Read())
            {
                cbPantalla.Items.Add(dtrUsuario.GetSqlString(0));

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        public void setBtnAccionTipo(string tipo)
        {
            this.btnAccion.Text = tipo;
        }

        private void mAgregarUsuario()
        {
            conexion.codigo = "123";
            conexion.clave = "123";
            if ((mValidarInfoUsuario() == true & mValidarPrivilegioUsuario() == true) || (mValidarRolUsuario() == true & mValidarInfoUsuario() == true))
            {
                if (mValidarRolUsuario() == true)
                {
                    entidadUsuario.mUsuario = txtNombreUsuario.Text;
                    entidadUsuario.mContrasena = txtContrasena.Text;
                    entidadUsuario.mNombre = txtNombre.Text;
                    entidadUsuario.mTipoUsuario = txtTipoUsuario.Text;
                    entidadUsuario.mApellidos = txtApellidos.Text;

                    if (usuario.mInsertarUsuario(conexion, entidadUsuario))
                    {
                        MessageBox.Show("Se insertó correctamente el usuario","Éxito", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al insertar el usuario", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    if (mValidarPrivilegioUsuario() == true)
                    {

                    }
                    else
                    {
                        if (mValidarPrivilegioUsuario() == true & mValidarRolUsuario() == true)
                        {

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Información insuficiente para agregar un usuario", "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            conexion.codigo = "123";
            conexion.clave = "123";
            
            if(btnAccion.Text== "Agregar")
            {
                mAgregarUsuario();
            }

            
            
        }

        public Boolean mValidarPrivilegioUsuario()
        {
            if (lvPrivilegios.Items.Count>0)
            {
                return true;
            }

            return false;
        }
        public Boolean mValidarRolUsuario()
        {
            if (lvRoles.Items.Count > 0)
            {
                return true;
            }

            return false;
        }

        public Boolean mValidarInfoUsuario()
        {
            if (txtNombre.Text!="" & txtApellidos.Text!="" & txtContrasena.Text!="" & txtId.Text!="" & txtNombreUsuario.Text!="" & txtNombre.Text!="" & txtApellidos.Text!="" & txtTipoUsuario.Text!="")
            {
                return true;
            }
            return false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            limpiar();
            frmListaGeneral  lista = new frmListaGeneral(conexion);
            lista.cargarListViewUsuarios();
            lista.ShowDialog();

            if (lista.mIdUsuario != 0)
            {
                entidadUsuario.mIdUsuario=lista.mIdUsuario;
                txtId.Text = Convert.ToString(lista.mIdUsuario);
                mConsultaCodigo();
                cargarRolesUsuario();
                cargarPrivilPantallasUsuario();
            }
        }

        public void cargarRolesUsuario()
        {
            conexion.clave = "123";
            conexion.codigo = "123";
            entidadUsuario.mIdUsuario = Convert.ToInt32(txtId.Text);
            dtrRol = rol.mConsultaRolesUsuario(conexion,entidadUsuario);

            if (dtrRol != null)
            {
                while (dtrRol.Read())
                {
                    ListViewItem item = new ListViewItem(dtrRol.GetString(0));
                    lvRoles.Items.Add(item);
                }
            }
        }

        public void cargarPrivilPantallasUsuario()
        {
            conexion.clave = "123";
            conexion.codigo = "123";
            entidadUsuario.mIdUsuario =Convert.ToInt32( txtId.Text);
            dtrPantalla = pantalla.mConsultaPrivPantaUsuario(conexion, entidadUsuario);

            if (dtrPantalla != null)
            {
                while (dtrPantalla.Read())
                {
                    ListViewItem item = new ListViewItem(dtrPantalla.GetString(0));

                    if (dtrPantalla.GetBoolean(1) == true)
                    {
                        item.SubItems.Add("Sí");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }
                    if (dtrPantalla.GetBoolean(2) == true)
                    {
                        item.SubItems.Add("Sí");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }
                    if (dtrPantalla.GetBoolean(3) == true)
                    {
                        item.SubItems.Add("Sí");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }
                    if (dtrPantalla.GetBoolean(4) == true)
                    {
                        item.SubItems.Add("Sí");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }
                    lvPrivilegios.Items.Add(item);
                }
            }
        }

        public void mConsultaCodigo()
        {
            conexion.codigo = "123";
            conexion.clave = "123";
            entidadUsuario.mIdUsuario = Convert.ToInt32(txtId.Text);
            dtrUsuario = usuario.mBuscarUsuario(conexion,entidadUsuario);

            if (dtrUsuario != null)
            {
                if (dtrUsuario.Read())
                {
                    txtNombreUsuario.Text = dtrUsuario.GetString(1);
                    txtContrasena.Text= dtrUsuario.GetString(2);
                    txtNombre.Text = dtrUsuario.GetString(3);
                    txtApellidos.Text = dtrUsuario.GetString(4);
                    txtTipoUsuario.Text = dtrUsuario.GetString(5); ;
                }
                else
                {
                    MessageBox.Show("Este usuario no existe","NOT FOUNT",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                mConsultaCodigo();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar()
        {
            txtId.Text = "";
            txtContrasena.Text = "";
            txtNombreUsuario.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTipoUsuario.Text = "";
            lvPrivilegios.Items.Clear();
            lvRoles.Items.Clear();
        }

        private void chkRol_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRol.Enabled == true)
            {
                cbRol.Enabled = false;
                btnAgregarRol.Enabled = false;
            }
            else
            {
                cbRol.Enabled = true;
                btnAgregarRol.Enabled = true;
            }
        }

        private void chkPrivilegio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPantalla.Enabled == true)
            {
                
                
                cbPantalla.Enabled = false;
                chkConsultar.Enabled = false;
                chkEliminar.Enabled = false;
                chkInsertar.Enabled = false;
                chkModificar.Enabled = false;
                btnAgregarPrivilegios.Enabled = false;
            }
            else
            {
                cbPantalla.Enabled = true;
                chkConsultar.Enabled = true;
                chkEliminar.Enabled = true;
                chkInsertar.Enabled = true;
                chkModificar.Enabled = true;
                btnAgregarPrivilegios.Enabled = true;
            }
        }

        public void controlAgregarRolPriv(int estado)
        {
            if (estado ==0)
            {
                chkPrivilegio.Enabled = true;
                chkRol.Enabled = true;

                lvRoles.Enabled = true;
                lvPrivilegios.Enabled = true;

                btnEliminarPrivilegioPantalla.Enabled = true;
                btnEliminarRol.Enabled = true;
                
            }
            else
            {
                if (estado == 2)
                {
                    chkPrivilegio.Enabled = false;
                    chkRol.Enabled = false;

                    lvRoles.Enabled = false;
                    lvPrivilegios.Enabled = false;

                    btnEliminarPrivilegioPantalla.Enabled = false;
                    btnEliminarRol.Enabled = false;
                }

            }
        }

        private void btnAgregarPrivilegios_Click(object sender, EventArgs e)
        {
            if (cbPantalla.Text != "")
            {
                ListViewItem item = new ListViewItem(cbPantalla.Text);
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
                lvPrivilegios.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Seleccione una pantalla","Datos incompletos",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnEliminarPrivilegioPantalla_Click(object sender, EventArgs e)
        {
            if (itemSeleccionPrivilegio() != -1)
            {
                lvPrivilegios.Items.RemoveAt(itemSeleccionPrivilegio());
            }
            else
            {
                MessageBox.Show("Seleccione un item válido", "No se ha seleccionado nada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public int itemSeleccionPrivilegio()
        {
            for (int i = 0; i < lvPrivilegios.Items.Count; i++)
            {
                if (lvPrivilegios.Items[i].Selected)
                {                    
                    return lvPrivilegios.Items[i].Index;
                }
            }
            return -1;
        }

        public int itemSeleccionRol()
        {
            for (int i = 0; i < lvRoles.Items.Count; i++)
            {
                if (lvRoles.Items[i].Selected)
                {                    
                    return lvRoles.Items[i].Index;
                }
            }
            return -1;
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            if (itemSeleccionRol() != -1)
            {
                lvRoles.Items.RemoveAt(itemSeleccionRol());
            }
            else
            {
                MessageBox.Show("Seleccione un item válido","No se ha seleccionado nada",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbRol.Text != "")
            {
                ListViewItem item = new ListViewItem(cbRol.Text);
                lvRoles.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Seleccione un rol válido", "Rol no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
