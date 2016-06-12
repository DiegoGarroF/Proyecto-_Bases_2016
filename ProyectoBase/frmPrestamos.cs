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

        //Metodo constructor
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
        //Metodo asigna el texto a las botones
        public void setBtnAccionTipo(String titulo)
        {
            btnFuncional.Text = titulo;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo que se utiliza para llenar listview de un libro
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

        //Metodo que se utiliza para llenar listview de un usuario
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


        //Para guardar un campo del listview
        public int mIdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        //metodo para llenar el listview con la informacion del Usuario cliente
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


        //metodo para validar los campos que se ocupen dependiendo de los opciones que se necesiten
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
                    txtFecha.Enabled = false;
                    txtIdLibro.Enabled = false;
                    txtIdUsuarioEstudiante.Enabled = false;
                    txtIdUsurio.Enabled = false;
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

        //Motodo para tomar la fecha del sistema
        public string fechaSistema()
        {
            DateTime fechaSistema = DateTime.Today;
            return fechaSistema.ToString("d");
        }

        //Metodo para consultar todos los prestamos y guardarlos en un listview
        public void btnBuscarGeneral_Click(object sender, EventArgs e)
        {
            frmConsultaPrestamos consultaPrestamos = new frmConsultaPrestamos(conexion);
            consultaPrestamos.mCargarListViewPrestamos();
            consultaPrestamos.ShowDialog();
            
            if (consultaPrestamos.mIdUsuario > 0)
            {
                
                txtIdPrestamo.Text = Convert.ToString(consultaPrestamos.mIdUsuario);
                pEntidadPrestamo.setGetIdPrestamo = Convert.ToInt32(txtIdPrestamo.Text);
                mConsultarPrestamo();
            }
        }
        
        //Metodo para realizar una consulta de un prestamo con el boton Consultar
        public void mConsultarPrestamo()
        {
            pEntidadPrestamo.setGetIdPrestamo = Convert.ToInt32(txtIdPrestamo.Text);
            dtrPrestamo = prestamo.mConsultarPrestamo(conexion, pEntidadPrestamo);
            if (dtrPrestamo!= null)
            {
                if (dtrPrestamo.Read())
                {
                    txtFecha.Text = Convert.ToString( dtrPrestamo.GetDateTime(1));
                    txtIdUsurio.Text = Convert.ToString( dtrPrestamo.GetInt32(2));
                    txtIdLibro.Text = Convert.ToString( dtrPrestamo.GetInt32(3));
                    txtIdUsuarioEstudiante.Text = Convert.ToString( dtrPrestamo.GetInt32(4));
                }
            }
        }

        //Metodo para agregar un pretamo
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

        //Metodo para limpiar los cmapos de informacion
        public void mLimpiar()
        {
            txtIdLibro.Text = "";
            txtIdUsurio.Text = "";
            txtIdUsuarioEstudiante.Text = "";
        }

        //metodo para eliminar un prestamo ingresando el codigo del prestamo
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

        //Metodo para las funciones que va a realizar el boton funcional
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
                        mConsultarPrestamo();
                    }
                }
            }

        }


        //metodo que se utiliza para realizar una busqueda presionandi la tecla enter.
        private void txtIdPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                mConsultarPrestamo();
            }
        }
    }
}
