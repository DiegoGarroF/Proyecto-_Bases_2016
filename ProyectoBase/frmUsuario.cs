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
        private clsConexion conexion;

        private frmMenuPrincipal menu;
        public frmUsuario(frmMenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.menu = menuPrincipal;
            entidadUsuario = new clsEntidadUsuario();
            usuario = new clsUsuario();
            conexion = new clsConexion();

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
    }
}
