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
    public partial class frmCambioContrsena : Form
    {
        #region Atributos
        private frmAcceso acceso;
        private clsConexion conexion;
        private clsEntidadUsuario pEntidadUsuario;
        private clsUsuario usuario;
        private SqlDataReader dataReader;
        #endregion
        public frmCambioContrsena(frmAcceso acceso, clsConexion conexion)
        {
            this.acceso = acceso;
            this.conexion = conexion;
            pEntidadUsuario = new clsEntidadUsuario();
            usuario = new clsUsuario();

            InitializeComponent();
        }


        public Boolean confirmarCcontra()
        {
            if (txtNuevaContraseña.Text.Equals(txtConfirmarContraseña.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Asegurese que las contraseñas sean iguales", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public Boolean conFirmarTamaño()
        {
            if (txtNuevaContraseña.TextLength >= 8 && txtConfirmarContraseña.TextLength >= 8)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Asegurese que las contraseñas las contrseñas tengan minimo 8 caracteres", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
        private void frmCambioContrsena_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = acceso.guardarUsuario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmAcceso acceso = new frmAcceso();
            acceso.Show();
            this.Close();
        }
        public string encriptar(String contraseña)
        {
            string resultado = string.Empty;
            byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(contraseña);
            resultado = Convert.ToBase64String(encriptar);
            return resultado;
        }

        public Boolean verificarCampos()
        {
            if (txtNuevaContraseña.Text != "" & txtConfirmarContraseña.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Ingrese una contraseña Valida", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (verificarCampos() == true)
            {
                if (confirmarCcontra() == true && conFirmarTamaño() == true)
                {
                    pEntidadUsuario.mUsuario = txtUsuario.Text;
                    pEntidadUsuario.mContrasena = encriptar(txtNuevaContraseña.Text);
                    if (usuario.mModificarContraseña(conexion, pEntidadUsuario, btnConfirmar.Text = "Modificar"))
                    {
                        clsConstantes.nombreUsuario = txtUsuario.Text;
                        MessageBox.Show("Contraseña cambiada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        frmMenuPrincipal menu = new frmMenuPrincipal(conexion, acceso);
                        menu.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
    }
}
