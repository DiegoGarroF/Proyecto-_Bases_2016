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
                txtFecha.Text = fechaSistema();
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
                else
                {
                    if (btnFuncional.Text.Equals(clsConstantes.ELIMINAR))
                    {
                        btnBuscarLibro.Enabled = false;
                        btnBuscarUsuario.Enabled = false;
                        btnBuscarUsuarioEstudiante.Enabled = false;
                        txtFecha.Enabled = false;
                        txtIdLibro.Enabled = false;
                        txtIdUsuarioEstudiante.Enabled = false;
                        txtIdUsurio.Enabled = false;

                    }
                }
            }

           
        } 
        public string fechaSistema()
        {
            DateTime fechaSistema = DateTime.Today;
            return fechaSistema.ToString("d");
        }

        public void btnBuscarGeneral_Click(object sender, EventArgs e)
        {
            frmConsultaPrestamos consultaPrestamos = new frmConsultaPrestamos(this.conexion);
            consultaPrestamos.ShowDialog();
            consultaPrestamos.mCargarListViewPrestamos();
        }
        
        public void mAgregarPrestamos()
        {
           
                pEntidadPrestamo.setGetFecha = Convert.ToDateTime( txtFecha.Text);
                pEntidadPrestamo.setGetidLibro = Convert.ToInt32(txtIdLibro.Text);
                pEntidadPrestamo.setGetIdUsuario = Convert.ToInt32(txtIdUsurio.Text);
                pEntidadPrestamo.setGetIdUsuariocliente= Convert.ToInt32(txtIdUsuarioEstudiante.Text);
               
                if (prestamo.mInsertarPrestamo(conexion, pEntidadPrestamo))
                {
                    MessageBox.Show("Se inserto con Exito el Prestamo", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al insertar el Prestamo", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
        }
        public void mLimpiar()
        {
            txtIdLibro.Text = "";
            txtIdUsurio.Text = "";
            txtIdUsuarioEstudiante.Text = "";
        }

        public void mEliminar()
        {
            pEntidadPrestamo.setGetIdPrestamo = Convert.ToInt32(txtIdPrestamo.Text);
            if (prestamo.mEliminarPrestamo(conexion, pEntidadPrestamo, btnFuncional.Text))
            {
                MessageBox.Show("Prestamo eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Ocurrio un error al Eliminar el Prestamo", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFuncional_Click(object sender, EventArgs e)
        {
            if (btnFuncional.Text.Equals(clsConstantes.AGREGAR))
            {
                mAgregarPrestamos();
                mLimpiar();
            }
            else
            {
                if (btnFuncional.Text.Equals(clsConstantes.ELIMINAR))
                {
                    mEliminar();
                    mLimpiar();
                }
                else
                {
                    if (btnFuncional.Text.Equals(clsConstantes.CONSULTAR))
                    {

                    }
                }
            }

        }
    }
}
