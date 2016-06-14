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
        public  clsLibro libro;
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
            btnAgregar.Text = titulo;
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Este Metodo sera el encargado de verificar, el texto que tiene el boton multifuncion
        //y asi realizar la accion correspondiente 
        private void btnMultiFuncion_Click(object sender, EventArgs e)
        {
            if(btnAgregar.Text.Equals(clsConstantes.AGREGAR))
            {

            }
            else if(btnAgregar.Text.Equals(clsConstantes.CONSULTAR))
            {

            }
            else if (btnAgregar.Text.Equals(clsConstantes.ELIMINAR))
            {

            }
            else if (btnAgregar.Text.Equals(clsConstantes.MODIFICAR))
            {

            }
        }
   
        #region Metodos IMEC

        //Metodo para agregar un nuevo libro
        public Boolean mAgregar()
        {
            dtr = libro.mSeleccionarTodos(conexion);
            if(!verificarEspacioISBN())
            {
                if(!verificarEspacioNombre())
                {

                }
                else
                {
                    mMostraMensaje(clsConstantes.COMPLETE_NOMBRE, clsConstantes.TIPO_GENERAL);
                }
            }
            else
            {
                mMostraMensaje(clsConstantes.COMPLETE_ISBN, clsConstantes.TIPO_GENERAL);
            }

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
            listaGeneral.ShowDialog();
            
            if (listaGeneral.mIdUsuario != 0)
            {
                // entidadUsuario.mIdUsuario = lista.mIdUsuario;
                txtID.Text = Convert.ToString(listaGeneral.mIdUsuario);
                
                pEntidadLibro.setIdLibro(Int32.Parse(txtID.Text));
                dtr = libro.mSeleccionarLibroID(conexion, pEntidadLibro);
                if(dtr!=null)
                {
                    if (dtr.Read())
                    {
                        txtNombre.Text = dtr.GetString(1);
                        txtISBN.Text = dtr.GetString(2);
                    }
                }

            }
        }

        public void mTipoAccion()
        {
            switch(btnAgregar.Text)
            {
                case clsConstantes.AGREGAR:

                    break;
                case clsConstantes.MODIFICAR:
                    break;
                case clsConstantes.ELIMINAR:
                    break;
                case clsConstantes.CONSULTAR:
                    break;
            }
        }

        #region Metodos Control espacios
        // Metodo para verificar que exista un isbn
        public Boolean verificarEspacioISBN()
        {
            if (!this.txtISBN.Text.Trim().Equals(""))
                return true;
            return false;
        }
        // Metodo para verificar que exista un nombre
        public Boolean verificarEspacioNombre()
        {
            if (!this.txtNombre.Text.Trim().Equals(""))
                return true;
            return false;
        }
        // Metodo para verificar que exista un ID
        public Boolean verificarEspacioID()
        {
            if (this.txtID.Text.Trim().Equals("Automatico"))
                return true;
            return false;
        }
        #endregion

        public void mMostraMensaje(String mensaje, int tipo)
        {
            
            
            switch(tipo)
            {
                case clsConstantes.TIPO_AGREGAR:
                    MessageBox.Show(clsConstantes.AGREGAR_LIBRO, clsConstantes.TIPO_LIBRO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsConstantes.TIPO_ELIMINAR:
                    MessageBox.Show(clsConstantes.ELIMINAR_LIBRO, clsConstantes.TIPO_LIBRO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case clsConstantes.TIPO_MODIFICAR:
                    MessageBox.Show(clsConstantes.MODIFICAR_LIBRO, clsConstantes.TIPO_LIBRO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    MessageBox.Show(mensaje, clsConstantes.TIPO_LIBRO, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;     
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!verificarEspacioID())
            {

                MessageBox.Show("El Id Se Encuentra Registrado\n\nSe Utilizara Uno De Forma Automática", "ID LIBRO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtID.Text = "Automatico";
            }
            if (verificarEspacioISBN()&& verificarEspacioNombre())
            {
              
                pEntidadLibro.setISBN(this.txtISBN.Text);
                pEntidadLibro.setNombre(this.txtNombre.Text);
                dtr = libro.mSeleccionarLibroISBN(this.conexion, pEntidadLibro);
                MessageBox.Show(pEntidadLibro.getISBN());
                if (dtr==null)
                {
                    if (libro.mInsertarLibro(this.conexion, pEntidadLibro))
                    {
                        MessageBox.Show("Libro Agregado Correctamente", "Proceso Exítoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mLimpiar();
                    }
                    else
                    {
                        MessageBox.Show("Surgió Un Error Al Agregar Un Libro", "Proceso No Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No Pueden Existir Dos Libros Con El Mismo ISBN", "Proceso No Completado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
               

            }
            else
            {
                MessageBox.Show("Debe Completar los Espacios Solicitados", "Complete Los Datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
        public void mLimpiar()
        {
            this.txtISBN.Text = "";
            this.txtNombre.Text = "";
        }
    }
}
