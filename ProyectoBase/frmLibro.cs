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
using System.Data.SqlClient;
using Controlador;
namespace Vista
{
    public partial class frmLibro : Form
    {
        const string opcion2="";
        private clsConexion conexion;
        private SqlDataReader dtr;
        public clsLibro libro;
        private clsEntidadLibro pEntidadLibro;

        public frmLibro(clsConexion conexion)
        {
            InitializeComponent();
            pEntidadLibro = new clsEntidadLibro();
            libro = new clsLibro();
            this.conexion = conexion;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal frmMenu = new frmMenuPrincipal(conexion);
            frmMenu.Visible = true;
        }

        private void frmLibro_Load(object sender, EventArgs e)
        {

        }
        public void setBtnAccionTipo(String titulo)
        {
            btnMultiFuncion.Text = titulo;
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Este Metodo sera el encargado de verificar, el texto que tiene el boton multifuncion
        //y asi realizar la accion correspondiente 
        private void btnMultiFuncion_Click(object sender, EventArgs e)
        {
            if(btnMultiFuncion.Text.Equals(clsConstantes.AGREGAR))
            {

            }
            else if(btnMultiFuncion.Text.Equals(clsConstantes.CONSULTAR))
            {

            }
            else if (btnMultiFuncion.Text.Equals(clsConstantes.ELIMINAR))
            {

            }
            else if (btnMultiFuncion.Text.Equals(clsConstantes.MODIFICAR))
            {

            }
        }

        #region Metodos IMEC

        //Metodo para agregar un nuevo libro
        public Boolean mAgregar()
        {
            return false;
        }
        // Metodo para consultar un libro
        public Boolean mConsultar()
        {
            return false;
        }
        // Metodo para modificar un libro
        public Boolean mModificar()
        {
            return false;
        }
        //Metodo para eliminar 
        public Boolean mEliminar()
        {
            return false;
        }


        #endregion

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmListaGeneral listaGeneral = new frmListaGeneral(conexion);
            listaGeneral.cargarListViewLibros();
            listaGeneral.Visible = true;
        }
        
    }
}
