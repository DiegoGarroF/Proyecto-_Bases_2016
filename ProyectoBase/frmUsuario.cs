﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;
using System.Data.SqlClient;


namespace Vista
{
    public partial class frmUsuario : Form
    {
        private clsEntidadUsuario entidadUsuario;
        private clsUsuario usuario;
        private SqlDataReader dtrUsuario;
        private SqlDataReader dtrRol;
        private clsConexion conexion;
        private clsEntidadRol entidadRol;
        private clsRol rol;

        private clsUsuarioRol usuarioRol;
        private clsEntidadUsuarioRol entidadUsuarioRol;

        private clsEntidadUsuarioPantalla entidadUsuarioPantalla;
        private clsUsuarioPantalla usuarioPantalla;

        private clsEntidadRolPantalla entidadRolPantalla;
        private clsRolPantalla rolPantalla;

        private clsPantalla pantalla;
        private clsEntidadPantalla entidadPantalla;
        private SqlDataReader dtrPantalla;        
        private SqlDataReader dtrPrivilegiosUsuaio;

        private frmMenuPrincipal menu;
        public frmUsuario(frmMenuPrincipal menuPrincipal,clsConexion conexion)
        {
            InitializeComponent();
            this.menu = menuPrincipal;
            entidadUsuario = new clsEntidadUsuario();
            usuario = new clsUsuario();
            this.conexion = conexion;

            entidadRol = new clsEntidadRol();
            rol = new clsRol();

            entidadPantalla = new clsEntidadPantalla();
            pantalla = new clsPantalla();

            usuarioRol = new clsUsuarioRol();
            entidadUsuarioRol = new clsEntidadUsuarioRol();

            entidadUsuarioPantalla = new clsEntidadUsuarioPantalla();
            usuarioPantalla = new clsUsuarioPantalla();

            entidadRolPantalla = new clsEntidadRolPantalla();
            rolPantalla = new clsRolPantalla();

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            //Se llena el combobox de las pantallas 
            dtrPantalla = pantalla.mConsultarPantallas(conexion);
            if (dtrPantalla != null)
                while (dtrPantalla.Read())
                {
                    if (dtrPantalla.GetSqlString(0) == this.Name)
                    {
                        cbPantalla.Items.Add("Mantenimiento de usuarios");
                    }
                    else
                    {
                        if (dtrPantalla.GetSqlString(0) == "frmRoles")
                        {
                            cbPantalla.Items.Add("Mantenimiento de roles");
                        }
                        else
                        {
                            if (dtrPantalla.GetSqlString(0) == "frmBitacora")
                            {
                                cbPantalla.Items.Add("Auditoría");
                            }
                            else
                            {
                                if (dtrPantalla.GetSqlString(0) == "frmGestionPrestamos")
                                {
                                    cbPantalla.Items.Add("Mantenimiento de prestamos");
                                }
                                else
                                {
                                    if (dtrPantalla.GetSqlString(0) == "frmLibro")
                                    {
                                        cbPantalla.Items.Add("Mantenimiento de libros");
                                    }
                                }
                            }
                        }
                    }
                }
            //Se llena el combobox de roles
            dtrRol = rol.mConsultarRoles(conexion);
            if (dtrRol != null)
                while (dtrRol.Read())
                {
                    cbRol.Items.Add(dtrRol.GetSqlString(0));

                }
            //PROCESO PARA VER SI UN USUARIO TIENE PRIVILEGIOS SOBRE ESTA VENTANA
            entidadUsuario.mUsuario = clsConstantes.nombreUsuario;
            entidadUsuario.mContrasena = "";
            dtrUsuario = usuario.mLogueoPrincipal(conexion, entidadUsuario); // saco id del usuario conectado
            if (dtrUsuario != null)
                while (dtrUsuario.Read())
                {
                    entidadUsuario.mIdUsuario = dtrUsuario.GetInt32(0);
                    dtrPrivilegiosUsuaio = usuario.mBuscarPrivilegiosUsuario(conexion, entidadUsuario);
                    if (dtrPrivilegiosUsuaio != null)
                        while (dtrPrivilegiosUsuaio.Read())
                        {
                            if (dtrPrivilegiosUsuaio.GetString(4) == this.Name)
                                mActivarBotonesAdministrador(dtrPrivilegiosUsuaio);
                        }
                }

            clsLibro libro = new clsLibro();
            dtrPrivilegiosUsuaio = libro.mObtenerPrivilegiosDirectos(this.conexion, Convert.ToString(entidadUsuario.mIdUsuario), this.Name);
            if (dtrPrivilegiosUsuaio != null)
                while (dtrPrivilegiosUsuaio.Read())
                {
                    mActivarBotonesAdministrador(dtrPrivilegiosUsuaio);
                }
        }
        //Método para salir de la ventana y mostrar el menú principal
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
        //Método para guardar los privilegios de un usuario, dependiendo si los posee o no 
        //A razón de que en la BD se guardan booleanos y de que en la interfaz se muestran "si" o "no " es necesario
        public void llenarPrivilegiosUsuarioPantalla(ListViewItem I)
        {
            if (I.SubItems[1].Text == "Sí")
            {
                entidadUsuarioPantalla.mInsertar = true;
            }
            else
            {
                entidadUsuarioPantalla.mInsertar = false;
            }

            if (I.SubItems[2].Text == "Sí")
            {
                entidadUsuarioPantalla.mConsultar = true;
            }
            else
            {
                entidadUsuarioPantalla.mConsultar = false;
            }

            if (I.SubItems[3].Text == "Sí")
            {
                entidadUsuarioPantalla.mModificar = true;
            }
            else
            {
                entidadUsuarioPantalla.mModificar = false;
            }

            if (I.SubItems[4].Text == "Sí")
            {
                entidadUsuarioPantalla.mEliminar = true;
            }
            else
            {
                entidadUsuarioPantalla.mEliminar = false;
            }


        }
        //Este método solamente llama a otros 2, uno para guardar los roles de un usuario y otro para almacenar los privilegios del mismo
        public void agregarUsuarioRolPrivilegio(int idUsuarioAgregado)
        {
            agregarUsuarioRol(idUsuarioAgregado);
            agregarUsuarioPrivilegio(idUsuarioAgregado);
            limpiar();
        }

        public string retornarPantalla(string nombre)
        {
            if (nombre == "Mantenimiento de usuarios")
            {
                return this.Name;
            }
            else
            {
                if (nombre == "Mantenimiento de roles")
                {
                    return "frmRoles";
                }
                else
                {
                    if (nombre == "Auditoria")
                    {
                        return "frmBitacora";
                    }
                    else
                    {
                        if (nombre == "Mantenimiento de prestamos")
                        {
                            return "frmGestionPrestamos";
                        }
                        else
                        {
                            if (nombre == "Mantenimiento de libros")
                            {
                                return "frmLibro";
                            }
                            else
                            {
                                return "";
                            }
                        }
                    }
                }
            }
        }
        //Este método inserta los roles de un usuario, la variable idUsuarioAgregado es el usuario al que se le cargarán los roles
        public void agregarUsuarioRol(int idUsuarioAgregado)
        {
            foreach (ListViewItem I in lvRoles.Items)//Se recorre el listview y se insertan todos los roles que aparecen en el listview
            {

                entidadRol.mNombreRol = I.SubItems[0].Text;
                dtrRol = rol.mConsultaIdRoles(conexion, entidadRol);
                if (dtrRol != null)
                    if (dtrRol.Read())
                    {
                        entidadUsuarioRol.mIdRol = dtrRol.GetInt32(0);
                        entidadUsuarioRol.mIdUsuario = idUsuarioAgregado;
                        entidadUsuarioRol.mCreadoPor = clsConstantes.nombreUsuario;
                        entidadUsuarioRol.mFechaCreacion = fechaSistema();
                        entidadUsuarioRol.mModificadoPor = "";
                        entidadUsuarioRol.mFechaModificacion = "";
                        usuarioRol.mInsertarUsuarioRol(conexion, entidadUsuarioRol);
                    }
            }
        }
        //Este método inserta los privilegios de un usuario, la variable idUsuarioAgregado es el usuario al que se le cargarán los privilegios directos
        public void agregarUsuarioPrivilegio(int idUsuarioAgregado)
        {
            entidadUsuarioPantalla.mIdUsuario = idUsuarioAgregado;
            foreach (ListViewItem I in lvPrivilegios.Items)//Se recorre el listview y se insertan todos los privilegios que aparecen en el listview
            {
                entidadPantalla.mNombrePantalla = retornarPantalla(I.SubItems[0].Text);
                dtrPantalla = pantalla.mConsultaIdPantalla(conexion, entidadPantalla);
                if (dtrPantalla != null)
                    if (dtrPantalla.Read())
                    {
                        entidadUsuarioPantalla.mIdPantalla = dtrPantalla.GetInt32(0);
                        entidadUsuarioPantalla.mIdUsuario = idUsuarioAgregado;
                        llenarPrivilegiosUsuarioPantalla(I); // este método verifica si se inserta un true o false en la BD
                        entidadUsuarioPantalla.mCreadoPor = clsConstantes.nombreUsuario;
                        entidadUsuarioPantalla.mFechaCreacion = fechaSistema();
                        entidadUsuarioPantalla.mModificadoPor = "";
                        entidadUsuarioPantalla.mFechaModificacion = "";
                        usuarioPantalla.mInsertarUsuarioPantalla(conexion, entidadUsuarioPantalla);
                    }
            }
        }
        //Este método retorna el id de un usuario agregado a la base de datos, ya que cuando se inserta un usuario no se digita este
        //Por lo cual es necesario retornar dicho id para posteriormente agregar los roles o privilegios del mismo, estas tablas exigen el id del usuario
        public int seleccionIdUsuarioAgregado()
        {
            entidadUsuario.mUsuario = txtNombreUsuario.Text;
            dtrUsuario = usuario.mConsultaIdUsuario(conexion, entidadUsuario);
            if (dtrUsuario != null)
                if (dtrUsuario.Read())//Debe devolver solo 1
                {
                    return dtrUsuario.GetInt32(0);
                }
            return -1;
        }

        public static string fechaSistema()
        {
            DateTime fechaSistema = DateTime.Today;
            return fechaSistema.ToString("d");
        }

        //Metodo para verificar NO exista otro usuario con el mismo login
        public Boolean mVerificarNombreUsuario()
        {
            entidadUsuario.mUsuario = txtNombreUsuario.Text;
            dtrUsuario = usuario.mBuscarPorLogin(conexion, entidadUsuario);
            if (dtrUsuario != null)
                if (dtrUsuario.Read())
                {
                    return true;
                }
                else
                {
                }
            return false;

        }

        //Este método inserta un usuario, además inserta los roles asignados al mismo y los privilegios. Dependiendo de la situación
        private void mAgregarUsuario()
        {            
            int idUsuarioAgregado = -1;
            entidadUsuario.mUsuario = txtNombreUsuario.Text;
            entidadUsuario.mContrasena = txtContrasena.Text;
            entidadUsuario.mNombre = txtNombre.Text;
            entidadUsuario.mTipoUsuario = cbTipoUsuario.Text;
            entidadUsuario.mApellidos = txtApellidos.Text;

            entidadUsuario.mEstadoUsuario = 0;
            entidadUsuario.mEstadoContrasena = false;
            entidadUsuario.mCreadoPor = clsConstantes.nombreUsuario;
            entidadUsuario.mFechaCreacion = fechaSistema();
            entidadUsuario.mModificadoPor = "";
            entidadUsuario.mFechaModificacion = "";

            //Se compara si se está asignando un rol o privilegio a un usuario, y si además se llenaron todos los datos del usuario
            if ((mValidarInfoUsuario() == true & mValidarPermisos(lvPrivilegios) == true) || (mValidarPermisos(lvRoles) == true & mValidarInfoUsuario() == true))
            {
                //Se realiza inserción de roles y privilegios directos
                if (mValidarPermisos(lvPrivilegios) & mValidarPermisos(lvRoles) == true)
                {
                    //AQUI
                    if (mVerificarNombreUsuario() == false)
                    {
                        if (usuario.mInsertarUsuario(conexion, entidadUsuario))
                        {
                            MessageBox.Show("Se ha insertado el usuario", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            idUsuarioAgregado = seleccionIdUsuarioAgregado();
                            agregarUsuarioRolPrivilegio(idUsuarioAgregado);
                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al insertar el usuario", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un usuario con este nombre de usuario", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {//se insertan solo privilegios
                    if (mValidarPermisos(lvPrivilegios) == true)
                    {
                        if (mVerificarNombreUsuario() == false)
                        {
                            if (usuario.mInsertarUsuario(conexion, entidadUsuario))
                            {
                                MessageBox.Show("Se ha insertado el usuario", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                idUsuarioAgregado = seleccionIdUsuarioAgregado();
                                agregarUsuarioPrivilegio(idUsuarioAgregado);
                                limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al insertar el usuario", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un usuario con este nombre de usuario", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {//se insertan únicamente roles
                        if (mValidarPermisos(lvRoles) == true)
                        {
                            if (mVerificarNombreUsuario() == false)
                            {
                                if (usuario.mInsertarUsuario(conexion, entidadUsuario))
                                {

                                    idUsuarioAgregado = seleccionIdUsuarioAgregado();
                                    agregarUsuarioRol(idUsuarioAgregado);
                                    MessageBox.Show("Se ha insertado el usuario", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    limpiar();
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrió un error al insertar el usuario", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ya existe un usuario con este nombre de usuario", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Información insuficiente para agregar un usuario", "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Modifica los datos propios de un usuario a partir del id del mismo
        public void modificarUsuario(int idUsuarioSeleccionado)
        {

            entidadUsuario.mIdUsuario = idUsuarioSeleccionado;
            entidadUsuario.mUsuario = txtNombreUsuario.Text;
            entidadUsuario.mContrasena = txtContrasena.Text;
            entidadUsuario.mNombre = txtNombre.Text;
            entidadUsuario.mTipoUsuario = cbTipoUsuario.Text;
            entidadUsuario.mApellidos = txtApellidos.Text;

            if (cbEstado.Text == "Bloqueado")
                entidadUsuario.mEstadoUsuario = 3;

            if (cbEstado.Text == "Desbloqueado")
                entidadUsuario.mEstadoUsuario = 0;

            entidadUsuario.mCreadoPor = "";
            entidadUsuario.mFechaCreacion = "";
            entidadUsuario.mModificadoPor = clsConstantes.nombreUsuario;
            entidadUsuario.mFechaModificacion = fechaSistema();

            if (usuario.mModificarUsuario(conexion, entidadUsuario) == true)
            {
                MessageBox.Show("Se ha modificado el usuario", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        //Este método elimina un usuario, SOLO USUARIO
        public void mEliminarUsuario()
        {           
            if (txtId.Text != "" & txtId.Text != "Automático")
            {
                if (mEliminarUsuarioRol() == true & mEliminarUsuarioPrivilegio() == true)
                {
                    entidadUsuario.mIdUsuario = Convert.ToInt32(txtId.Text);
                    entidadUsuario.mUsuario = txtNombreUsuario.Text;
                    if (usuario.mEliminarUsuario(conexion, entidadUsuario, btnAgregar.Text))
                    {
                        MessageBox.Show("Usuario eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor indique el usuario a eliminar", "Búsqueda necesaria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        //Este método elimina los roles asociados a un usuario en específico
        public Boolean mEliminarUsuarioRol()
        {

            entidadUsuarioRol.mIdUsuario = Convert.ToInt32(txtId.Text);
            return usuarioRol.mEliminarRolesUsuario(conexion, entidadUsuarioRol, btnAgregar.Text);
        }
        //Este método elimina los privilegios asociados a un usuario en específico
        public Boolean mEliminarUsuarioPrivilegio()
        {
            entidadUsuarioPantalla.mIdUsuario = Convert.ToInt32(txtId.Text);
            return usuarioPantalla.mEliminarPantallasUsuario(conexion, entidadUsuarioPantalla, btnAgregar.Text);
        }

        //Valida que al menos se vaya a insertar un rol o un privilegio
        public Boolean mValidarPermisos(ListView lista)
        {
            if (lista.Items.Count > 0)
            {
                return true;
            }

            return false;
        }
        //Se verifica que este toda la información de un usuario antes de ser insertado
        public Boolean mValidarInfoUsuario()
        {
            if (txtNombre.Text != "" & txtApellidos.Text != "" & txtContrasena.Text != "" & txtNombreUsuario.Text != "" & txtNombre.Text != "" & txtApellidos.Text != "" & cbTipoUsuario.Text != "")
            {
                return true;
            }
            return false;
        }
        //este método despliega una lista con todos los usuarios, para seleccionar el que se desee visualmente
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            frmListaGeneral lista = new frmListaGeneral(conexion);
            lista.cargarListViewUsuarios();
            lista.ShowDialog();            
            entidadUsuario.mIdUsuario = lista.mIdUsuario;
            dtrUsuario = usuario.mBuscarUsuario(conexion, entidadUsuario);

            if (lista.mIdUsuario != 0)
            {
                entidadUsuario.mIdUsuario = lista.mIdUsuario;
                txtId.Text = Convert.ToString(lista.mIdUsuario);
                if (mConsultaUsuario(dtrUsuario) == true)
                {
                    cargarRolesUsuario();
                    cargarPrivilPantallasUsuario();
                }

            }
        }
        //Este método carga los roles de un usuario
        public void cargarRolesUsuario()
        {
            entidadUsuario.mIdUsuario = Convert.ToInt32(txtId.Text);
            dtrRol = rol.mConsultaRolesUsuario(conexion, entidadUsuario);

            if (dtrRol != null)
            {
                while (dtrRol.Read())
                {
                    ListViewItem item = new ListViewItem(dtrRol.GetString(0));
                    lvRoles.Items.Add(item);
                }
            }
        }
        //Este método carga los privilegios directos de un usuario
        public void cargarPrivilPantallasUsuario()
        {
            
            entidadUsuario.mIdUsuario = Convert.ToInt32(txtId.Text);
            dtrPantalla = pantalla.mConsultaPrivPantaUsuario(conexion, entidadUsuario);

            if (dtrPantalla != null)
            {
                while (dtrPantalla.Read())
                {
                    ListViewItem item = new ListViewItem(dtrPantalla.GetString(0));
                    for (int i = 1; i <= 4; i++)
                    {
                        if (dtrPantalla.GetBoolean(i) == true)
                        {
                            item.SubItems.Add("Sí");
                        }
                        else
                        {
                            item.SubItems.Add("No");
                        }
                    }
                    lvPrivilegios.Items.Add(item);
                }
            }
        }
        //Este método recibe un SqlDataReader con el resultado de una búsqueda de un usuario, si existe muestra la información
        public Boolean mConsultaUsuario(SqlDataReader dtrUsuario)
        {
            if (dtrUsuario != null)
            {
                if (dtrUsuario.Read())
                {
                    txtId.Text = Convert.ToString(dtrUsuario.GetInt32(0));
                    txtNombreUsuario.Text = dtrUsuario.GetString(1);
                    txtContrasena.Text = dtrUsuario.GetString(2);
                    txtNombre.Text = dtrUsuario.GetString(3);
                    txtApellidos.Text = dtrUsuario.GetString(4);
                    cbTipoUsuario.Text = dtrUsuario.GetString(5);
                    if (dtrUsuario.GetInt32(6) < 3)
                    {
                        cbEstado.Text = "Desbloqueado";
                    }
                    else
                    {
                        cbEstado.Text = "Bloqueado";
                    }

                    return true;
                }
                else
                {
                    MessageBox.Show("Este usuario no existe", "NOT FOUNT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else { return false; }
        }

        //ejecuta el método de limpiar todos los campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        //Limpia todos los campos
        public void limpiar()
        {
            txtId.Text = "Automático";
            txtContrasena.Text = "";
            txtNombreUsuario.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            cbRol.SelectedIndex = -1;
            cbPantalla.SelectedIndex = -1;
            cbTipoUsuario.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            lvPrivilegios.Items.Clear();
            lvRoles.Items.Clear();

            chkConsultar.Checked = false;
            chkEliminar.Checked = false;
            chkInsertar.Checked = false;
            chkModificar.Checked = false;
            chkPrivilegio.Checked = false;
            chkRol.Checked = false;
        }
        //Activa o desactiva el combobox de roles
        private void chkRol_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRol.Enabled == true)
            {
                cbRol.Enabled = false;
                btnAgregarRol.Enabled = false;
            }
            else
            {
                cbRol.Enabled = true;
                btnAgregarRol.Enabled = true;
            }
        }
        //Activa o desactiva el combobox de pantallas y los privilegios posibles a asignar
        private void chkPrivilegio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPantalla.Enabled == true)
            {
                cbPantalla.Enabled = false;
                chkConsultar.Enabled = false;
                chkEliminar.Enabled = false;
                chkInsertar.Enabled = false;
                chkModificar.Enabled = false;
                btnAgregarPrivilegios.Enabled = false;
            }
            else
            {
                cbPantalla.Enabled = true;
                chkConsultar.Enabled = true;
                chkEliminar.Enabled = true;
                chkInsertar.Enabled = true;
                chkModificar.Enabled = true;
                btnAgregarPrivilegios.Enabled = true;
            }
        }
        //Agrega los privilegios de una pantalla al listview respectivo, dependiendo de los privilegios en la bd
        //Es necesario xq en la BD se almacenan como true o false...
        private void btnAgregarPrivilegios_Click(object sender, EventArgs e)
        {
            if (cbPantalla.Text != "")
            {
                ListViewItem item = new ListViewItem(cbPantalla.Text);
                if (chkInsertar.Checked == true)
                {
                    item.SubItems.Add("Sí");
                }
                else
                {
                    item.SubItems.Add("No");
                }

                if (chkConsultar.Checked == true)
                {
                    item.SubItems.Add("Sí");
                }
                else
                {
                    item.SubItems.Add("No");
                }

                if (chkModificar.Checked == true)
                {
                    item.SubItems.Add("Sí");
                }
                else
                {
                    item.SubItems.Add("No");
                }

                if (chkEliminar.Checked == true)
                {
                    item.SubItems.Add("Sí");
                }
                else
                {
                    item.SubItems.Add("No");
                }
                lvPrivilegios.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Seleccione una pantalla", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        //Elimina un item del listview privilegios pantallas
        private void btnEliminarPrivilegioPantalla_Click(object sender, EventArgs e)
        {
            if (itemSeleccion(lvPrivilegios) != -1)
            {
                lvPrivilegios.Items.RemoveAt(itemSeleccion(lvPrivilegios));

            }
            else
            {
                MessageBox.Show("Seleccione un item válido", "No se ha seleccionado nada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Retorna el rol o pantalla seleccionada de un listview
        public int itemSeleccion(ListView lista) //Usar solo 1 método
        {
            for (int i = 0; i < lista.Items.Count; i++)
            {
                if (lista.Items[i].Selected)
                {
                    return lista.Items[i].Index;
                }
            }
            return -1;
        }
        //Elimina un rol del listview asociado a él
        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            if (itemSeleccion(lvRoles) != -1)
            {
                lvRoles.Items.RemoveAt(itemSeleccion(lvRoles));
            }
            else
            {
                MessageBox.Show("Seleccione un item válido", "No se ha seleccionado nada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Ejecuta el método eliminarUsuario
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mEliminarUsuario();
        }
        //Ejecuta el método cargarDatosUsuario
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarDatosUsuario();
        }
        //Se cargan los roles y privilegios directos de un usuario
        public void cargarDatosUsuario()
        {
            
            entidadUsuario.mUsuario = txtNombreUsuario.Text;
            dtrUsuario = usuario.mBuscarPorLogin(conexion, entidadUsuario);

            if (mConsultaUsuario(dtrUsuario) == true)
            {
                cargarRolesUsuario();
                cargarPrivilPantallasUsuario();
            }

        }
        //Se modifica un usuario
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idUsuarioSeleccionado = -1;
            idUsuarioSeleccionado = Convert.ToInt32(txtId.Text);

            if (idUsuarioSeleccionado != -1)
            {
                modificarUsuario(idUsuarioSeleccionado);

                //Elimino roles y privilegios
                mEliminarUsuarioRol();
                mEliminarUsuarioPrivilegio();
                agregarUsuarioRolPrivilegio(idUsuarioSeleccionado);
                limpiar();
            }
            else
            {
                MessageBox.Show("Realice una búsqueda del usuario a modificar", "Indique un usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Ejecuta el metodo agregarUsuario
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mAgregarUsuario();
        }
        //Busca los datos de un usuario a partir del nombre de usuario
        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                cargarDatosUsuario();
            }
        }
        //Agrega un rol del combobox al listview respectivo
        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            if (cbRol.Text != "")
            {
                ListViewItem item = new ListViewItem(cbRol.Text);
                lvRoles.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Seleccione un rol válido", "Rol no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Activa los botones, textbox, checkbox, etc... cuando un usuario posee los privilegios indicados
        public void mActivarBotonesAdministrador(SqlDataReader dtrPermisos)
        {
            if (dtrPermisos.GetBoolean(0))
            {
                btnModificar.Enabled = true;
                chkPrivilegio.Enabled = true;
                chkRol.Enabled = true;
                btnEliminarRol.Enabled = true;
                btnEliminarPrivilegioPantalla.Enabled = true;
            }
            if (dtrPermisos.GetBoolean(1))
            {
                btnAgregar.Enabled = true;
                btnAgregarPrivilegios.Enabled = true;
                btnAgregarRol.Enabled = true;
                chkPrivilegio.Enabled = true;
                chkRol.Enabled = true;
                btnEliminarRol.Enabled = true;
                btnEliminarPrivilegioPantalla.Enabled = true;
            }
            if (dtrPermisos.GetBoolean(2))
            {
                btnConsultar.Enabled = true;
                btnBuscar.Enabled = true;
            }
            if (dtrPermisos.GetBoolean(3))
            {
                btnEliminar.Enabled = true;
            }

        }

    }
}
