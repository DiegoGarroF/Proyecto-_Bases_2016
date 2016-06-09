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

        private void btnAccion_Click(object sender, EventArgs e)
        {
            conexion.codigo = "admBiblioteca";
            conexion.clave = "123";
            entidadUsuario.mIdUsuario =Convert.ToInt32(txtId.Text);
            dtrUsuario = usuario.mBuscarUsuario(conexion,entidadUsuario);
            if (dtrUsuario != null)
            {
                if (dtrUsuario.Read())
                {
                    txtNombreUsuario.Text = dtrUsuario.GetString(1);
                    txtContrasena.Text = dtrUsuario.GetString(2);





                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmListaGeneral  lista = new frmListaGeneral(conexion);
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

            dtrRol = rol.mConsultaRolesUsuario(conexion);

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

            dtrPantalla = pantalla.mConsultaPrivPantaUsuario(conexion);

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
            txtId.Text = "";
            txtContrasena.Text = "";
            txtNombreUsuario.Text = "";
        }

        private void chkRol_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRol.Enabled == true)
            {
                cbRol.Enabled = false;
            }
            else
            {
                cbRol.Enabled = true;
            }
        }

        private void chkPrivilegio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPrivilegio.Enabled == true)
            {
                cbPrivilegio.Enabled = false;
                cbPantalla.Enabled = false;
            }
            else
            {
                cbPrivilegio.Enabled = true;
                cbPantalla.Enabled = true;
            }
        }

        public void controlAgregarRolPriv(int estado)
        {
            if (estado ==0)
            {
                chkPrivilegio.Enabled = true;
                chkRol.Enabled = true;

                lvRoles.Enabled = false;
                lvPrivilegios.Enabled = false;

                btnEliminarPrivilegioPantalla.Enabled = false;
                btnEliminarRol.Enabled = false;
            }
            else
            {
                if (estado == 1)
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
        }
    }
}
