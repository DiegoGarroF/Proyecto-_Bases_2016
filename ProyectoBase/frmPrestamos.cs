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
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            frmListaGeneral listaGeneral = new frmListaGeneral(conexion);
            listaGeneral.cargarListViewUsuarios();
            listaGeneral.ShowDialog();
        }

        private void btnBuscarUsuarioEstudiante_Click(object sender, EventArgs e)
        {
            frmListaGeneral listaGeneral = new frmListaGeneral(conexion);
            listaGeneral.ShowDialog();
        }
    }
}
