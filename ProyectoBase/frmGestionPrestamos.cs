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
        private SqlDataReader dataReader, dataReader2;
        #endregion

        //Constructor de la calse frmPrestamos
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

        //Metodo para buscar un cliente boton
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
        //Metodo para cargar la informacion de un cliente
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

        //metodo para bloquear todos los campos que no se pueden modificar
        public void mBloquearCampos()
        {
            txtApellidos.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtIdCliente.Enabled = false;
            txtIdLibro.Enabled = false;
            txtNombreLibro.Enabled = false;
            txtIsbn.Enabled = false;
            btnAgregar.Enabled = false;
            btnBuscarPrestamo.Enabled = false;
            btnBuscarCliente.Enabled = false;
            btnBuscarLibro.Enabled = false;
            btnEliminar.Enabled = false;

        }


        private void frmGestionPrestamos_Load(object sender, EventArgs e)
        {
//            verificar();
            mBloquearCampos();
            mHabilitarBotones();
        }

        //Metodo que realiza una consulta en la base de datos y ve todos los privilegios que este tiene con este sistema
        public void mHabilitarBotones()
        {

            clsEntidadUsuario pEntidadUsuario = new clsEntidadUsuario();
            dataReader = prestamo.mSeleccionarIdUsuario(conexion, clsConstantes.nombreUsuario);
            if (dataReader != null && dataReader.Read())
            {
                pEntidadUsuario.mIdUsuario = dataReader.GetInt32(0);

                dataReader = prestamo.mObtenerRolesUsuario(this.conexion, Convert.ToString(dataReader.GetInt32(0)), this.Name);
                if (dataReader != null && dataReader.Read())
                {
                    if (dataReader.GetBoolean(0))// Modificar
                    {
                        
                    }
                    if (dataReader.GetBoolean(1))// Insertar
                    {
                        this.btnAgregar.Enabled = true;
                    }
                    if (dataReader.GetBoolean(2))//Consultar
                    {
                        this.btnBuscarPrestamo.Enabled = true;
                        this.btnBuscarLibro.Enabled = true;
                        this.btnBuscarCliente.Enabled = true;
                    }
                    if (dataReader.GetBoolean(3))//Eliminar
                    {
                        this.btnEliminar.Enabled = true;
                    }
                }
                //Privilegios directos al usuario para esa pantalla
                dataReader = libro.mObtenerPrivilegiosDirectos(this.conexion, Convert.ToString(pEntidadUsuario.mIdUsuario), this.Name);
                if (dataReader != null && dataReader.Read())
                {
                    if (dataReader.GetBoolean(0))// Modificar
                    {
                        
                    }
                    if (dataReader.GetBoolean(1))// Insertar
                    {
                        this.btnAgregar.Enabled = true;
                    }
                    if (dataReader.GetBoolean(2))//Consultar
                    {
                        this.btnBuscarPrestamo.Enabled = true;
                        this.btnBuscarLibro.Enabled = true;
                        this.btnBuscarCliente.Enabled = true;
                    }
                    if (dataReader.GetBoolean(3))//Eliminar
                    {
                        this.btnEliminar.Enabled = true;
                    }
                }
            }
        }
        
        //Metodo para buscar los libros almacenados en las bases de datos
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

        //Metodo para cargar los campos de los libros
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

        //Metodo que realiza una consulta de todos los prestamos que se encuentran registrados en las base de datos
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

        //Accion de boton salir
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

        //Metodo para limpiar los campos de la ventana
        public void mLimpiar()
        {
            txtApellidos.Text = "";
            txtIdCliente.Text = "";
            txtIdLibro.Text = "";
            txtIsbn.Text = "";
            txtNombreCliente.Text = "";
            txtNombreLibro.Text = "";
        }

        //Boton que realiza la accion de agregar en ella se llaman los metodos correspondientes
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                pEntidadPrestamo.setGetFecha = Convert.ToDateTime(fechaSistema());
                pEntidadPrestamo.setGetidLibro = Convert.ToInt32(txtIdLibro.Text);
                pEntidadPrestamo.setGetIdUsuario = mRetornarId();
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
            else
            {
                MessageBox.Show("Campos vacios. Llene todos los datos", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        //Retorna el id de usuario conectado 
        public int mRetornarId()
        {
            pEntidadUsuario.mUsuario= clsConstantes.nombreUsuario;
            dataReader= usuario.mBuscarPorLogin(conexion, pEntidadUsuario);
            if (dataReader != null)
            {
                if (dataReader.Read())
                {
                    return dataReader.GetInt32(0);
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }
        //Accion de boton para limpiar un 
        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            mLimpiar();
        }


        //Accion del boton eliminar y con ello llama al metodo de eliminar un prestamo
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
        //Metodo que se utiliza para borrar algun prestamo
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

        //Verifica que no existan campos vacios para realizar el prestamo
        public Boolean verificarCampos()
        {
            if (txtIdLibro.Text!= "" && txtIdCliente.Text!= "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
    }
}
