using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Modelo;
using Controlador;

namespace Vista
{
    public partial class frmPrestamos : Form
    {
        #region Atributos
        clsConexion conexion;
        clsEntidadPrestamo pEntidadPrestamo;
        clsPrestamo prestamo;
        int idUsuario;
        SqlDataReader dtrPrestamo;
        #endregion
        public frmPrestamos()
        {
            InitializeComponent();
            pEntidadPrestamo = new clsEntidadPrestamo();
            prestamo = new clsPrestamo();
            conexion = new clsConexion();
            conexion.clave = "123";
            conexion.codigo = "123";
            
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            camposInvalidos();
        }
        public void setBtnAccionTipo(String titulo)
        {
            btnFuncional.Text = titulo;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            frmListaGeneral listaGeneral = new frmListaGeneral(conexion);
            listaGeneral.cargarListViewLibros();
            listaGeneral.ShowDialog();
            if (listaGeneral.mIdUsuario != 0)
            {
                // entidadUsuario.mIdUsuario = lista.mIdUsuario;
                txtIdLibro.Text = Convert.ToString(listaGeneral.mIdUsuario);
                
            }

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            frmListaGeneral lista = new frmListaGeneral(conexion);
            lista.cargarListViewUsuarios();
            lista.ShowDialog();
            if (lista.mIdUsuario != 0)
            {
               // entidadUsuario.mIdUsuario = lista.mIdUsuario;
                txtIdUsurio.Text = Convert.ToString(lista.mIdUsuario);
                
            }
        }

        public int mIdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        private void btnBuscarUsuarioEstudiante_Click(object sender, EventArgs e)
        {
            frmListaGeneral listaGeneral = new frmListaGeneral(conexion);
            listaGeneral.cargarListViewUsuariosCliente();
            listaGeneral.ShowDialog();
            if (listaGeneral.mIdUsuario !=0)
            {
                txtIdUsuarioEstudiante.Text = Convert.ToString(listaGeneral.mIdUsuario);
            }
        }
        public void camposInvalidos()
        {
            if (btnFuncional.Text.Equals(clsConstantes.AGREGAR))
            {
                txtIdPrestamo.Text = "Automatico";
                txtIdPrestamo.Enabled = false;
                btnBuscarGeneral.Enabled = false;
                txtFecha.Text = "Automatico";
                txtFecha.Enabled = false;
            }
            else
            {
                if (btnFuncional.Text.Equals(clsConstantes.CONSULTAR))
                {
                    btnBuscarLibro.Enabled = false;
                    btnBuscarUsuario.Enabled = false;
                    btnBuscarUsuarioEstudiante.Enabled = false;
                }
            }

           
        }
    }
}
