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
        /*El metodo load es el que se ejecuta al cargar el Frame
         * detro de este se llama a el metodo mDeshabilitarAcciones el cual desactiva todos los botones
         * ademas se llama al metodo mHabilitarBotones, el cual es el encargado de verificar los roles y privilegios y habilitar botones
         * 
         */
        private void frmLibro_Load(object sender, EventArgs e)
        {
            mDeshabilitarAcciones();
            mHabilitarBotones();
        }
        #endregion
        #region Atributos
        /*
         * Atributos a utilizar
         */
        const string opcion2 = "";
        private clsConexion conexion;
        private SqlDataReader dtr;
        public clsLibro libro;
        private clsEntidadLibro pEntidadLibro;
        private clsUsuario usuario;
        #endregion
        #region Constructor

        /*
         *Este es el metodo constructor en el cual se inicializan o se crean todas las instancias 
         * 
        */
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
        /*
         * Este metodo es el encargado de eliminar un libro por id
         */

        public void mEliminarLibro()
        {
            //Verifica que se selccionara un libro
            if (!verificarEspacioID())
            {
                pEntidadLibro.setIdLibro(Int32.Parse(this.txtID.Text));// se carga la entidad para hacer la eliminacion

                // se verifica si se elimino un libro correctamente y si es asi , se envia un mensaje y se limpian los campos
                if (libro.mEliminarLibro(conexion, pEntidadLibro))
                {
                    MessageBox.Show("El Libro con el codigo " + txtID.Text + " eliminado con Exito", "Acción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mLimpiar();
                }
                // si no se pudo eliminar se envia un mensja de error
                else
                {
                    MessageBox.Show("Surgio un Error, Libro No Eliminado", "Acción", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            //si no se selecciono un libro entonces se envia un mensaje para que seleccione un libro
            else
            {
                MessageBox.Show("Debe Seleccionar un Libro Para eliminar", "ID LIBRO NO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                this.txtID.Text = Convert.ToString(listaGeneral.mIdUsuario);

                pEntidadLibro.setIdLibro(Int32.Parse(txtID.Text));// carga la entidad libro con el id 
                dtr = libro.mSeleccionarLibroID(conexion, pEntidadLibro);// hace la consulta del libro por ID 
                if (dtr != null&& dtr.Read())// si la consulta devuelve registros entonces se llenan los campos con los datos devueltos
                {
                    this.txtNombre.Text = dtr.GetString(1);
                    this.txtISBN.Text = dtr.GetString(2);
                }

            }
        }
        #endregion
        #region Metodo Modificar
        // Este metodo se encarga de modificar un libro
        public void mModificar()
        {
            /*se carga la entidad libro con los datos 
             * un aspecto importante es el creadoPor y el modificadoPor 
             * estos campos se cargan vacios porque asi lo requiere el metodo para validar los datos que no sean codigo vasura
             */
             
            pEntidadLibro.setIdLibro(Convert.ToInt32(txtID.Text));
            pEntidadLibro.setNombre(txtNombre.Text);
            pEntidadLibro.setISBN(txtISBN.Text);
            pEntidadLibro.setModificadoPor(clsConstantes.nombreUsuario);
            pEntidadLibro.setFechaModificacion(frmUsuario.fechaSistema());
            pEntidadLibro.setCreadoPor("");
            pEntidadLibro.setFechaCreacion("");
            // Se verifica si se realizo correctamente la mofiifcacion y se envia un mensaje
            if (libro.mModificarLibro(conexion, pEntidadLibro))
            {
                MessageBox.Show("El Libro Ha Sido Modificado Con Exito", "Accion Efectuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mLimpiar();
            }
            // si nose pudo realizar la modificacion se envia un mensaje 
            else
            {
                MessageBox.Show("Surgio Un Error ", "No se pudo modificar", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
        #endregion
        #region Metodo para limpiar
        // Este metodo se encarga de limpiar los campos de txtNombre ,txtISBN y de ponerle como valor automatico al campo txtID
        public void mLimpiar()
        {
            this.txtISBN.Text = "";
            this.txtNombre.Text = "";
            this.txtID.Text = "Automatico";
        }
        #endregion
        #region Acciones de los Botones

        // Cuando se presiona el boton salir se cierra la ventana y se abre nuevamente la principal
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal frmMenu = new frmMenuPrincipal(conexion);
            frmMenu.Visible = true;
        }
        // cuando se presiona en boton consultar se llama al metodo mConsultar que abre el listView
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            mConsultarLibro();
        }

        // cuando se presiona en botn agregar se llama al metodo mVerificarId que se encarga de hacer las comparaciones respectivas y agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mVerificarId();
        }
        // Cuando se presiona el boton eliminar se llama al metodo eliminar que hace las comparciones respectivas y elimina un libro
        private void clickBtnEliminar(object sender, EventArgs e)
        {
            mEliminarLibro();
        }
        // Cuando se presiona el botn modificar se llama al metodo mModificar y se hacen las comparaciones respectivas y modifica un libro
        private void btnModificar_Click(object sender, EventArgs e)
        {
            mControlModificar();
        }
        #endregion
        #region Metodos Control espacios
        // Metodo para verificar que exista un isbn, que el campo txtIsbn no se encuentre vacio
        public Boolean verificarEspacioISBN()
        {
            if (!this.txtISBN.Text.Trim().Equals(""))
                return true;
            return false;
        }
        // Metodo para verificar que el campo txtNombre no este vacio para poder agregar un libro
        public Boolean verificarEspacioNombre()
        {
            if (!this.txtNombre.Text.Trim().Equals(""))
                return true;
            return false;
        }

        /* Metodo para verificar que exista un ID
         * La forma de verificar que existe un esque el campo txtID sea falso ya que 
         * al seleccionarse un libro se cargara su id en este campo 
         */
        public Boolean verificarEspacioID()
        {
            // Verifica que el texto sea igual a "Automatico" si es igual quiere decir que no se ha seleccionado ningun libro
            if (this.txtID.Text.Trim().Equals("Automatico"))
                return true;
            return false;
        }
        #endregion 
        #region Metodo para verificar el ID
        /*
         * Este metodo se encarga de verificar el id de un libro en el momento que sera ingresado un nuevo libro
         * 
         */
        public void mVerificarId()
        {
            // llama al metodo verificarEspacioID que lo que hace es verificar que espacio sea diferente de automatico 
            if (!verificarEspacioID())
            {
                /* si es diferente de automatico quiere decir que se ha seleccionado un libro, por lo tanto ese id ya existe 
                 * entonces mediante un dialog result se pregunta si quiere generar un id automatico
                 * 
                */
                DialogResult opcion = MessageBox.Show("El id se encuentra registrado\n\nDesea utilizar uno de forma Automática...???", "ID LIBRO EXISTENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Si el usuario desea generar un id Automatico entonces se pone como el texto "Automatico" en el espacio del ID y se agrega un nuevo libro
                if (opcion == DialogResult.Yes)
                {
                    this.txtID.Text = "Automatico";
                    mAgreagarLibro();
                }
                // Si el usuario no quiere generar un id automatico entonces se le envia un mensaje de error que no se pudo registrar el libro
                else
                {
                    MessageBox.Show("Libro No Registrado Por Problemas de ID", "ID LIBRO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }// fin del if que verifca si se selecciono un libro ya existente 
            // si el id es automatico entonces se llama al metodo agregar libro
            else
            {
                mAgreagarLibro();
            }
        }
        #endregion
        #region Metodo para agregar un Libro
        /*
         * Este metodo es el encargado de agregar un nuevo libro
         */
        public void mAgreagarLibro()
        {
            // verifica que espacio de nombre y de ISBN no se encuentren vacios
            if (verificarEspacioISBN() && verificarEspacioNombre())
            {
                //Carga la entidad con los datos
                pEntidadLibro.setISBN(this.txtISBN.Text);
                pEntidadLibro.setNombre(this.txtNombre.Text);
                pEntidadLibro.setCreadoPor(clsConstantes.nombreUsuario);
                pEntidadLibro.setFechaCreacion(frmUsuario.fechaSistema());
                pEntidadLibro.setModificadoPor("");
                pEntidadLibro.setFechaModificacion("");
                dtr = libro.mSeleccionarLibroISBN(this.conexion, pEntidadLibro);//Consulta un libro por isbn , con el fin de saber si existe ese isbn
                // verifica que la consulta no sea null
                if (dtr != null)
                {
                    // si la consulta devuelve registros quiere decir que existe ese ISBN por lo tanto no se puede efectuar el registro
                    if (dtr.Read())
                    {
                        MessageBox.Show("No Pueden Existir Dos Libros Con El Mismo ISBN", "Proceso No Completado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }//fin del if que verifica si existe el isb y si existe devuelve un mensaje de error

                    // Si la consulta no devuelve registros entonces quiere decir que no existe ese ISBN registrado
                    else
                    {
                        /* llama al metodo que se encarga re hacer la insercion y lo ponemos dentro de un if para verificar si se 
                         * inserto de una forma correcta
                        */
                        if (libro.mInsertarLibro(this.conexion, pEntidadLibro))
                        {
                            MessageBox.Show("Libro Agregado Correctamente", "Proceso Exítoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mLimpiar();
                        }// fin del if que inserto un libro
                        // si no se logro insertar de una manera correcta envia el mensaje de error
                        else
                        {
                            MessageBox.Show("Surgió un Error al Agregar un libro", "Proceso No Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }//fin del else que controla si se realizo el insert
                    }// fin del else que verifica que no exista un ISBN igual al que se quiere ingresar

                }
            }
            // si alguno de los espacios , estavacio envia un mensaje de advertencia
            else
            {
                MessageBox.Show("Debe Completar los Espacios Solicitados", "Complete Los Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }// fin del else que virifca que los espacios esten correctamente
        }
        #endregion
        #region Metodo Para Habilitar Acciones
        // Este metodo es el encargado de, controlador las acciones de los botones 
        public void mHabilitarBotones()
        {
            // Se crea la entidad usuario 
            clsEntidadUsuario pEntidadUsuario = new clsEntidadUsuario();
            // Llama al metodo seleccionarIdUsuario mediante el nombre que se encuentra en la constante clsConstantes.nombreUsuario
            dtr = libro.mSeleccionarIdUsuario(conexion, clsConstantes.nombreUsuario);
            //Verifica si la consulta devuelve registros
            if (dtr != null && dtr.Read())
            {
                // si devuelve registros, guarde en la entidad usuario el id obtenido
                pEntidadUsuario.mIdUsuario = dtr.GetInt32(0);

                //se hace una consulta para verificar los roles que tenga ese usuario con respecto a esa ventana
                dtr = libro.mObtenerRolesUsuario(this.conexion, Convert.ToString(dtr.GetInt32(0)), this.Name);
                while(dtr != null && dtr.Read())// se recorre los registros obtenidos y se verifica los privilegios para cada boton en ese role
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
        // Este metodo se encarga de deshabilitar los botones 
        public void mDeshabilitarAcciones()
        {
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnConsultar.Enabled = false;
            this.btnAgregar.Enabled = false;
        }
        #endregion     
        #region Metodo Controlar el metodo Modificar 
        // Este metodo se encarga de modificar un libro existente que se buscar por id
        public void mControlModificar()
        {
            // verifica que se seleccione un libro
            if (!verificarEspacioID())
            {
                // carga la entidad con los datos 
                pEntidadLibro.setIdLibro(Int32.Parse(this.txtID.Text));
                pEntidadLibro.setISBN(this.txtISBN.Text);
                pEntidadLibro.setNombre(this.txtNombre.Text);
                //verifica que los los campos de isbn y nombre no estes vacios
                if (verificarEspacioISBN() && verificarEspacioNombre())
                {
                    // hace una consulta por isbn para saber si existe 
                    dtr = libro.mSeleccionarLibroISBN(conexion, pEntidadLibro);
                    if (dtr != null)
                    {
                        if (dtr.Read())// si existe un libro con ese isbn 
                        {
                            /*pregunta si el id de ese libro que ya existe es igual al id del libro que se quiere modificar, si es 
                             * asi entonces se modifica el libro
                             */
                            if (dtr.GetInt32(0) == Int32.Parse(this.txtID.Text))
                            {
                                mModificar();
                            }
                            // si el id encontrado es distinto al id del libro que se va a modificar entonces se envia un msj de error
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
                // si los espacios de nombre y de ISBN estan vacios entonces se envia un msj de advertencia
                else
                {
                    MessageBox.Show("Complete Los Espacios", "Existen Espacios Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            // si el campo txtID tiene el valor de "Automatico entonces se le envia un msj para que seleccione un libro a mofificar
            else
            {
                MessageBox.Show("Debe Seleccionar un Libro Para Modificarlo", "ID LIBRO NO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion
    }
}
