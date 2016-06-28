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
        #region Load

        private void frmLibro_Load(object sender, EventArgs e)
        {
            mDeshabilitarAcciones();
            mHabilitarBotones();
        }
        #endregion
        #region Atributos
        const string opcion2 = "";
        private clsConexion conexion;
        private SqlDataReader dtr;
        public clsLibro libro;
        private clsEntidadLibro pEntidadLibro;
        private clsUsuario usuario;
        #endregion
        #region Constructor
        public frmLibro(clsConexion conexion)
        {
            InitializeComponent();
            this.pEntidadLibro = new clsEntidadLibro();
            this.libro = new clsLibro();
            this.conexion = conexion;
            this.usuario = new clsUsuario();



        }
        #endregion
        #region Eliminar Libro
        public void mEliminarLibro()
        {
            if (!verificarEspacioID())
            {
                pEntidadLibro.setIdLibro(Int32.Parse(this.txtID.Text));
                if (libro.mEliminarLibro(conexion, pEntidadLibro))
                {
                    MessageBox.Show("El Libro con el codigo " + txtID.Text + " eliminado con Exito", "Acción", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    mLimpiar();
                }
                else
                {
                    MessageBox.Show("Surgio un Error, Libro No Eliminado", "Acción", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Libro Para eliminar", "ID LIBRO NO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion
        #region Consultar Libro
        public void mConsultarLibro()
        {
            frmListaGeneral listaGeneral = new frmListaGeneral(conexion);//Crea el listView
            listaGeneral.cargarListViewLibros();//carga el ListView con los datos de todos los libros
            listaGeneral.ShowDialog();//Activa el showDialog

            if (listaGeneral.mIdUsuario != 0)//Verifica que se haya seleccionado un libro
            {
                // entidadUsuario.mIdUsuario = lista.mIdUsuario;
                txtID.Text = Convert.ToString(listaGeneral.mIdUsuario);

                pEntidadLibro.setIdLibro(Int32.Parse(txtID.Text));
                dtr = libro.mSeleccionarLibroID(conexion, pEntidadLibro);
                if (dtr != null)
                {
                    if (dtr.Read())
                    {
                        txtNombre.Text = dtr.GetString(1);
                        txtISBN.Text = dtr.GetString(2);
                    }
                }

            }
        }
        #endregion
        #region Metodo Modificar
        public void mModificar()
        {
            pEntidadLibro.setIdLibro(Convert.ToInt32(txtID.Text));
            pEntidadLibro.setNombre(txtNombre.Text);
            pEntidadLibro.setISBN(txtISBN.Text);
            pEntidadLibro.setModificadoPor(clsConstantes.nombreUsuario);
            pEntidadLibro.setFechaModificacion(frmUsuario.fechaSistema());
            pEntidadLibro.setCreadoPor("");
            pEntidadLibro.setFechaCreacion("");

            if (libro.mModificarLibro(conexion, pEntidadLibro))
            {
                MessageBox.Show("El Libro Ha Sido Modificado Con Exito", "Accion Efectuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mLimpiar();
            }
            else
            {
                MessageBox.Show("Surgio Un Error ", "No se pudo modificar", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
        #endregion
        #region Metodo para limpiar

        public void mLimpiar()
        {
            this.txtISBN.Text = "";
            this.txtNombre.Text = "";
            this.txtID.Text = "Automatico";
        }
        #endregion
        #region Acciones de los Botones

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal frmMenu = new frmMenuPrincipal(conexion);
            frmMenu.Visible = true;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            mConsultarLibro();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
            mVerificarId();

        }

        private void clickBtnEliminar(object sender, EventArgs e)
        {
            mEliminarLibro();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            mModificar();
        }
        #endregion
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
        #region Metodo para verificar el ID
        public void mVerificarId()
        {
            if (!verificarEspacioID())
            {
                DialogResult opcion = MessageBox.Show("El id se encuentra registrado\n\nDesea utilizar uno de forma Automática...???", "ID LIBRO EXISTENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcion == DialogResult.Yes)
                {
                    this.txtID.Text = "Automatico";
                    mAgreagarLibro();
                }
                else
                {
                    MessageBox.Show("Libro No Registrado Por Problemas de ID", "ID LIBRO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }// fin del if que verifca si se selecciono un libro ya existente 
            else
            {
                mAgreagarLibro();
            }
        }
        #endregion
        #region Metodo para agregar un Libro
        public void mAgreagarLibro()
        {

            if (verificarEspacioISBN() && verificarEspacioNombre())
            {
                //Carga la entidad con los datos
                pEntidadLibro.setISBN(this.txtISBN.Text);
                pEntidadLibro.setNombre(this.txtNombre.Text);
                pEntidadLibro.setCreadoPor(clsConstantes.nombreUsuario);
                pEntidadLibro.setFechaCreacion(frmUsuario.fechaSistema());
                pEntidadLibro.setModificadoPor("");
                pEntidadLibro.setFechaModificacion("");
                dtr = libro.mSeleccionarLibroISBN(this.conexion, pEntidadLibro);//Cinsulta un libro por isbn , con el fin de saber si existe ese isbn

                if (dtr != null)
                {
                    if (dtr.Read())
                    {
                        MessageBox.Show("No Pueden Existir Dos Libros Con El Mismo ISBN", "Proceso No Completado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }//fin del if que verifica si existe el isb y si existe devuelve un mensaje de error

                    else
                    {
                        if (libro.mInsertarLibro(this.conexion, pEntidadLibro))
                        {
                            MessageBox.Show("Libro Agregado Correctamente", "Proceso Exítoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mLimpiar();
                        }// fin del if que inserto un libro

                        else
                        {
                            MessageBox.Show("Surgió un Error al Agregar un libro", "Proceso No Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }//fin del else que controla si se realizo el insert
                    }// fin del else que verifica que no exista un ISBN igual al que se quiere ingresar

                }
            }
            else
            {
                MessageBox.Show("Debe Completar los Espacios Solicitados", "Complete Los Datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }// fin del else que virifca que los espacios esten correctamente
        }
        #endregion
        #region Metodo Para Habilitar Acciones
        public void mHabilitarBotones()
        {
            clsEntidadUsuario pEntidadUsuario = new clsEntidadUsuario();
            dtr = libro.mSeleccionarIdUsuario(conexion, clsConstantes.nombreUsuario);
            if (dtr != null && dtr.Read())
            {
                pEntidadUsuario.mIdUsuario = dtr.GetInt32(0);

                dtr = libro.mObtenerRolesUsuario(this.conexion, Convert.ToString(dtr.GetInt32(0)), this.Name);
                if (dtr != null && dtr.Read())
                {
                    if (dtr.GetBoolean(0)==true)// Modificar
                    {
                        this.btnModificar.Enabled = true;
                    }
                    if (dtr.GetBoolean(1))// Insertar
                    {
                        this.btnAgregar.Enabled = true;
                    }
                    if (dtr.GetBoolean(2))//Consultar
                    {
                        this.btnConsultar.Enabled = true;
                    }
                    if (dtr.GetBoolean(3))//Eliminar
                    {
                        this.btnEliminar.Enabled = true;
                    }
                }
                //Privilegios directos al usuario para esa pantalla
                dtr = libro.mObtenerPrivilegiosDirectos(this.conexion, Convert.ToString(pEntidadUsuario.mIdUsuario), this.Name);
                if(dtr!=null && dtr.Read())
                {
                    if (dtr.GetBoolean(0))// Modificar
                    {
                        this.btnModificar.Enabled = true;
                    }
                    if (dtr.GetBoolean(1))// Insertar
                    {
                        this.btnAgregar.Enabled = true;
                    }
                    if (dtr.GetBoolean(2))//Consultar
                    {
                        this.btnConsultar.Enabled = true;
                    }
                    if (dtr.GetBoolean(3))//Eliminar
                    {
                        this.btnEliminar.Enabled = true;
                    }
                }
            }

        }
        #endregion
        #region Metodo para DesHabilitar Botones
        public void mDeshabilitarAcciones()
        {
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnConsultar.Enabled = false;
            this.btnAgregar.Enabled = false;
        }
        #endregion     
        #region Metodo Controlar el metodo Modificar 
        public void mControlModificar()
        {
            if (!verificarEspacioID())
            {
                pEntidadLibro.setIdLibro(Int32.Parse(this.txtID.Text));
                pEntidadLibro.setISBN(this.txtISBN.Text);
                pEntidadLibro.setNombre(this.txtNombre.Text);
                if (verificarEspacioISBN() && verificarEspacioNombre())
                {
                    dtr = libro.mSeleccionarLibroISBN(conexion, pEntidadLibro);
                    if (dtr != null)
                    {
                        if (dtr.Read())
                        {
                            if (dtr.GetInt32(0) == Int32.Parse(this.txtID.Text))
                            {
                                mModificar();
                            }
                            else
                            {
                                MessageBox.Show("Este ISBN ya se encuentra registrado", "Existen Espacios Vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            mModificar();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Complete Los Espacios", "Existen Espacios Vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Libro Para Modificarlo", "ID LIBRO NO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion
  

    }
}
