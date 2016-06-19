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
        private clsEntidadLibro pEntidadLibro;
        private clsLibro libro;
        private clsEntidadUsuario pEntidadUsuario;
        private clsUsuario usuario;
        private clsPrestamo prestamo;
        private int idUsuario;
        private SqlDataReader dataReader;
        #endregion


        public frmGestionPrestamos(clsConexion conexion)
        {
            this.conexion = conexion;
            pEntidadLibro = new clsEntidadLibro();
            libro = new clsLibro();
            pEntidadPrestamo = new clsEntidadPrestamo();
            prestamo = new clsPrestamo();
            pEntidadUsuario = new clsEntidadUsuario();
            usuario = new clsUsuario();
            
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
                txtIdCliente.Text = Convert.ToString(listaGeneral.mIdUsuario);
                cargarCamposCliente();

            }
        }
        public void cargarCamposCliente()
        {
            pEntidadUsuario.mIdUsuario = Convert.ToInt32(txtIdCliente.Text);
            dataReader = usuario.mBuscarUsuario(conexion, pEntidadUsuario);
            if (dataReader != null)
            {
                if (dataReader.Read())
                {
                    txtNombreCliente.Text = dataReader.GetString(3);
                    txtApellidos.Text = dataReader.GetString(4);
                }
            }
        }

        public void mBloquearCampos()
        {
            txtApellidos.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtIdCliente.Enabled = false;
            txtIdLibro.Enabled = false;
            txtNombreLibro.Enabled = false;
            txtIsbn.Enabled = false;
        }


        private void frmGestionPrestamos_Load(object sender, EventArgs e)
        {
            mBloquearCampos();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            frmListaGeneral listaGeneral = new frmListaGeneral(conexion);
            listaGeneral.cargarListViewLibros();
            listaGeneral.ShowDialog();
            if (listaGeneral.mIdUsuario != 0)
            {
               // pEntidadLibro.setIdLibro(Convert.ToInt32( listaGeneral.mIdUsuario));
                txtIdLibro.Text = Convert.ToString(listaGeneral.mIdUsuario);
                cargarCamposLibro();

            }
        }
        public void cargarCamposLibro()
        {
            pEntidadLibro.setIdLibro(Convert.ToInt32(txtIdLibro.Text));
            dataReader = libro.mSeleccionarLibroID(conexion, pEntidadLibro);
            if (dataReader!= null)
            {
                if (dataReader.Read())
                {
                    txtNombreLibro.Text = dataReader.GetString(1);
                    txtIsbn.Text = dataReader.GetString(2);
                }
            }
        }

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            frmConsultaPrestamos consulta = new frmConsultaPrestamos(conexion);
            consulta.mCargarListViewPrestamos();
            consulta.ShowDialog();
            if (consulta.mIdLibros!=0)
            {
                txtIdLibro.Text = Convert.ToString(consulta.mIdLibros);
                txtIdCliente.Text = Convert.ToString(consulta.mIdCLiente);
                cargarCamposCliente();
                cargarCamposLibro();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Motodo para tomar la fecha del sistema
        public string fechaSistema()
        {
            DateTime fechaSistema = DateTime.Today;
            return fechaSistema.ToString("d");
        }
        public void mLimpiar()
        {
            txtApellidos.Text = "";
            txtIdCliente.Text = "";
            txtIdLibro.Text = "";
            txtIsbn.Text = "";
            txtNombreCliente.Text = "";
            txtNombreLibro.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pEntidadPrestamo.setGetFecha = Convert.ToDateTime(fechaSistema());
            pEntidadPrestamo.setGetidLibro = Convert.ToInt32(txtIdLibro.Text);
            pEntidadPrestamo.setGetIdUsuario = Convert.ToInt32(txtIdCliente.Text);
            pEntidadPrestamo.setGetIdUsuariocliente = Convert.ToInt32(txtIdCliente.Text);
            pEntidadPrestamo.mCreadoPor = clsConstantes.nombreUsuario;
            pEntidadPrestamo.mFechaCreacion = Convert.ToDateTime(fechaSistema());
           // pEntidadPrestamo.mFechaModificado = Convert.ToDateTime("");

            if (prestamo.mInsertarPrestamo(conexion, pEntidadPrestamo))
            {
                MessageBox.Show("Se inserto con Exito el Prestamo", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mLimpiar();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al insertar el Prestamo", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            mLimpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmConsultaPrestamos consulta = new frmConsultaPrestamos(conexion);
            consulta.mCargarListViewPrestamos();
            consulta.ShowDialog();
            if (consulta.mIdLibros != 0)
            {
                txtIdLibro.Text = Convert.ToString(consulta.mIdLibros);
                txtIdCliente.Text = Convert.ToString(consulta.mIdCLiente);
                cargarCamposCliente();
                cargarCamposLibro();
                eliminarPrestamo();
                mLimpiar();

            }
        }
        public void eliminarPrestamo()
        {
            pEntidadPrestamo.setGetidLibro = Convert.ToInt32(txtIdLibro.Text);
            pEntidadPrestamo.setGetIdUsuariocliente = Convert.ToInt32(txtIdCliente.Text);
            if(prestamo.mEliminarPrestamo(conexion, pEntidadPrestamo, btnEliminar.Text))
            {
                MessageBox.Show("Se Elimino con Exito el Prestamo", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mLimpiar();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al Eliminar el Prestamo", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
      
    }
}
