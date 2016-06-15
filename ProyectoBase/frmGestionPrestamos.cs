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
    public partial class frmGestionPrestamos : Form
    {
        #region Atributos
        private clsConexion conexion;
        private clsEntidadPrestamo pEntidadPrestamo;
        private clsPrestamo prestamo;
        private int idUsuario;
        private SqlDataReader dtrPrestamo;
        #endregion
        public frmGestionPrestamos(clsConexion conexion)
        {
            this.conexion = conexion;
            
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmListaGeneral listaGeneral = new frmListaGeneral(conexion);
            listaGeneral.cargarListViewUsuariosCliente();
            listaGeneral.ShowDialog();
            if (listaGeneral.mIdUsuario != 0)
            {
                // entidadUsuario.mIdUsuario = lista.mIdUsuario;
                txtIdLibro.Text = Convert.ToString(listaGeneral.mIdUsuario);

            }
        }

        private void frmGestionPrestamos_Load(object sender, EventArgs e)
        {

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

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            frmConsultaPrestamos consulta = new frmConsultaPrestamos(conexion);
            consulta.mCargarListViewPrestamos();
            consulta.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
