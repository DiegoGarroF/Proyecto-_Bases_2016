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
using System.Transactions;


namespace Vista
{
    public partial class frmRoles : Form
    {
        clsConexion conexion;
        clsEntidadRol entidadRol;
        clsPantalla pantalla;
        SqlDataReader strRol;
        clsEntidadRolPantalla entidadRolPantalla;
        String strPantalla;
        clsRol clRol;
        private SqlDataReader dtrPantalla;
        private frmMenuPrincipal menuPrincipal;
        private clsEntidadUsuario entidadUsuario;
        SqlDataReader dtrUsuario;
        SqlDataReader dtrPrivilegiosUsuario;
        clsUsuario usuario;
        SqlDataReader dtrRol;
        clsEntidadPantalla entidadPantalla;
        clsRolPantalla rolPantalla;   
        IAsyncResult pruebaRol; 

        public frmRoles(frmMenuPrincipal menu)
        {
            entidadUsuario = new clsEntidadUsuario();
            conexion = new clsConexion();
            entidadRol = new clsEntidadRol();
            clRol = new clsRol();
            usuario = new clsUsuario();
            this.menuPrincipal = menu;
            pantalla = new clsPantalla();
            entidadRolPantalla = new clsEntidadRolPantalla();
            entidadPantalla = new clsEntidadPantalla();
            rolPantalla = new clsRolPantalla();
            InitializeComponent();
        }

        //Coloca en la entidadRolPantalla el privilegio elegido para el rol que se va a crear        
        public void establecerPrivilegiosRol(ListViewItem I)
        {
            if (I.SubItems[2].Text == "Sí"){
                entidadRolPantalla.mInsertar = true;
            } else {
                entidadRolPantalla.mInsertar = false;
            } if (I.SubItems[3].Text == "Sí"){
                entidadRolPantalla.mConsultar = true;
            }else {
                entidadRolPantalla.mConsultar = false;
            } if (I.SubItems[4].Text == "Sí") {
                entidadRolPantalla.mModificar = true;
            } else {
                entidadRolPantalla.mModificar = false;
            } if (I.SubItems[5].Text == "Sí"){
                entidadRolPantalla.mEliminar = true;
            } else{
                entidadRolPantalla.mEliminar = false;
            }       
    }
        //Inserta un los la relación RolPantalla, la cual es básicamente privilegios del rol
        public void agregarRolPantalla(SqlConnection connection)
        {
            foreach (ListViewItem I in lvPantalla.Items)//Se recorre el listview y se inserta el rol a todas las pantallas que aparecen en el listview
            {
                establecerPrivilegiosRol(I);
                entidadPantalla.mNombrePantalla = mRetornarVentanaSeleccionada(I.SubItems[1].Text);
                dtrPantalla= pantalla.mConsultaIdPantallaScope(conexion,entidadPantalla, connection);//aqui ocupa otra trasacción
                if(dtrPantalla!=null)
                    if (dtrPantalla.Read())
                    {
                        entidadRolPantalla.mIdPantalla = dtrPantalla.GetInt32(0);
                        dtrPantalla.Close();
                        entidadRolPantalla.mCreadoPor = clsConstantes.nombreUsuario;
                        entidadRolPantalla.mFechaCreacion = frmUsuario.fechaSistema();
                        entidadRolPantalla.mModificadoPor = "";
                        entidadRolPantalla.mFechaModificacion = "";
                        rolPantalla.mInsertarRolPantalla(conexion, entidadRolPantalla, connection);
                    }
            }               
        }
        //Realiza la verificación previo a insertar un rol, llama al método de insertar el rol
        //Y posteriormente llama a insertar los privilegios
        //ESTE MÉTODO SE EJECUTA BAJO TRANSACCIONES, EN CASO QUE ALGO FALLE, SE CANCELAN LAS INSERCIONES
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.codigo = "123";
            conexion.clave = "123";
            entidadRol.mNombreRol = lvPantalla.Items[0].Text;

            if ((mValidarInformacionRoles() == true & mValidarPermisos(lvPantalla) == true))
            {                
                if (mValidarPermisos(lvPantalla) == true)
                {
                    if (cbPantalla.Text != null)
                    {

                        using (TransactionScope transactionScope = new TransactionScope())
                        {
                            try
                            {
                                clRol.mInsertarRol(conexion, entidadRol);

                                using (SqlConnection connection = new SqlConnection(conexion.retornarSentenciaConeccion(conexion)))
                                {
                                    connection.Open();
                                    dtrRol = clRol.mConsultaIdRolScope(conexion, entidadRol, connection);//otro scope aquí ocupo

                                    if (dtrRol != null)
                                        if (dtrRol.Read())//ERROR AL LEER
                                        {
                                            entidadRolPantalla.mIdRol = dtrRol.GetInt32(0);
                                            dtrRol.Close();
                                            agregarRolPantalla(connection);
                                            transactionScope.Complete();
                                            MessageBox.Show("Se ha insertado el rol completo", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            limpiar();
                                        }
                                }
                            }
                            catch
                            {
                                MessageBox.Show("No se ha insertado el rol completo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                       
                    }
                }
            }
            else
            {
                MessageBox.Show("Información insuficiente para agregar un rol", "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }// fin del metodo

        //Verifica exista el rol en el listview
        public Boolean mValidarInformacionRoles()
        {
            if (lvPantalla.Items[0].Text != "")
            {
                return true;
            }
            return false;
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

        //Limpia los campos de la ventana
        public void limpiar()
        {           
            txtNombreRol.Text = "";
            cbPantalla.SelectedIndex = -1;
            lvPantalla.Items.Clear();            

            chkConsultar.Checked = false;
            chkEliminar.Checked = false;
            chkInsertar.Checked = false;
            chkModificar.Checked = false;
        }
        //Ejecuta el método modificar rol
        private void btnModificar_Click(object sender, EventArgs e)
        {
            mModificarRol();
        }

        //Verifica que el textBox nombreRol no este vacío
        public Boolean verificarNombre()
        {
            if (!this.txtNombreRol.Text.Trim().Equals(""))
                return true;
            return false;
        }    

        //Modifica el rol que se encuentre en el listview
        public void mModificarRol()
        {
            if (lvPantalla != null)
            {
                entidadRol.mNombreRol = lvPantalla.Items[0].Text;
                dtrRol = clRol.mConsultaIdRoles(conexion, entidadRol);
                if(dtrRol!=null)
                    if (dtrRol.Read())
                    {
                        entidadRolPantalla.mIdRol = dtrRol.GetInt32(0);
                        rolPantalla.mEliminarRolPantalla(conexion, entidadRolPantalla);
                    }
                using (SqlConnection connection = new SqlConnection(conexion.retornarSentenciaConeccion(conexion)))
                {
                    connection.Open();
                    try{
                        agregarRolPantalla(connection);
                        MessageBox.Show("Rol modificado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch{
                        MessageBox.Show("No se ha modificado correctamente el rol", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
            }
            else
            {
                MessageBox.Show("No digitó el nombre del rol ", "No se pudo modificar", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }



        public void mActivarBotonesAdministrador(SqlDataReader dtrPermisos)
        {
            if (dtrPermisos.GetBoolean(0))
            {
                btnModificar.Enabled = true;                                
                btnQuitarPantalla.Enabled = true;
                btnEliminar.Enabled = true;
                chkConsultar.Enabled = true;
                chkEliminar.Enabled = true;
                chkInsertar.Enabled = true;
                chkModificar.Enabled = true;
                btnBuscar.Enabled = true;
                txtNombreRol.Enabled = true;
                btnLimpiar.Enabled = true;
            }
            if (dtrPermisos.GetBoolean(1))
            {
                btnAgregar.Enabled = true;
                btnAgregarPrivilegios.Enabled = true;
                btnQuitarPantalla.Enabled = true;
                chkConsultar.Enabled = true;
                chkEliminar.Enabled = true;
                chkInsertar.Enabled = true;
                chkModificar.Enabled = true;
                btnBuscar.Enabled = true;
                txtNombreRol.Enabled = true;
                btnLimpiar.Enabled = true;
            }
            if (dtrPermisos.GetBoolean(2))
            {
                btnBuscar.Enabled = true;
                txtNombreRol.Enabled = true;
                btnLimpiar.Enabled = true;
            }
            if (dtrPermisos.GetBoolean(3))
            {
                btnEliminar.Enabled = true;
                btnBuscar.Enabled = true;
                txtNombreRol.Enabled = true;                
            }

        }

        public string mRetornarVentanaSeleccionada(string ventana)
        {
            if (ventana == "Mantenimiento de roles")
            {
                return this.Name;
            }
            else
            {
                if (ventana == "Mantenimiento de usuarios")
                {
                    return "frmUsuario";
                }
                else
                {
                    if (ventana == "Auditoría")
                    {
                        return "frmBitacora";
                    }
                    else
                    {
                        if (ventana == "Mantenimiento de prestamos")
                        {                            
                            return "frmGestionPrestamos";
                        }
                        else
                        {
                            if (ventana == "Mantenimiento de libros")
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

        private void frmRoles_Load(object sender, EventArgs e)
        {
            dtrPantalla = pantalla.mConsultarPantallas(conexion);
            if (dtrPantalla != null)
                while (dtrPantalla.Read())
                {
                    if (dtrPantalla.GetSqlString(0) == this.Name)
                    {
                        cbPantalla.Items.Add("Mantenimiento de roles");
                    }
                    else
                    {
                        if (dtrPantalla.GetSqlString(0) == "frmUsuario")
                        {
                            cbPantalla.Items.Add("Mantenimiento de usuarios");
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

            //PROCESO PARA VER SI UN USUARIO TIENE PRIVILEGIOS SOBRE ESTA VENTANA
            entidadUsuario.mUsuario = clsConstantes.nombreUsuario;
            entidadUsuario.mContrasena = "";
            dtrUsuario = usuario.mLogueoPrincipal(conexion, entidadUsuario); // saco id del usuario conectado
            if (dtrUsuario != null)
                while (dtrUsuario.Read())
                {
                    entidadUsuario.mIdUsuario = dtrUsuario.GetInt32(0);
                    dtrPrivilegiosUsuario = usuario.mBuscarPrivilegiosUsuario(conexion, entidadUsuario);
                    if (dtrPrivilegiosUsuario != null)
                        while (dtrPrivilegiosUsuario.Read())
                        {
                            if (dtrPrivilegiosUsuario.GetString(4) == this.Name)
                                mActivarBotonesAdministrador(dtrPrivilegiosUsuario);
                        }
                    clsLibro libro = new clsLibro();
                    dtrPrivilegiosUsuario = libro.mObtenerPrivilegiosDirectos(this.conexion, Convert.ToString(entidadUsuario.mIdUsuario), this.Name);
                    if(dtrPrivilegiosUsuario!=null)
                    while (dtrPrivilegiosUsuario.Read())
                    {
                        mActivarBotonesAdministrador(dtrPrivilegiosUsuario);
                    }
                }
        }       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal.Show();
        }

        private void btnAgregarPrivilegios_Click(object sender, EventArgs e)
        {
            if ((verificarNombre()==true) &(cbPantalla.Text!=""))
            {
                if (verificarRolPantallaLista(lvPantalla, txtNombreRol.Text, cbPantalla.Text))
                {
                    ListViewItem item = new ListViewItem(txtNombreRol.Text);
                    item.SubItems.Add(cbPantalla.Text);
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
                    lvPantalla.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("Únicamente se puede insertar un rol a la vez, Quizá este rol ya fue asignado a esta pantalla", "Tenga en cuenta lo siguiente:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Datos insuficientes","Falta información",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }

        public Boolean verificarRolPantallaLista(ListView lista, string rol, string pantalla)
        {
            Boolean estado = true;
            foreach (ListViewItem I in lista.Items)
            {
                if (((I.SubItems[0].Text == rol)&((I.SubItems[1].Text ==pantalla))) ||(I.SubItems[0].Text!=rol))
                {
                    Console.WriteLine("NO Pruede agregar");
                    return false;
                }
            }
            return estado;
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

        private void btnQuitarPantalla_Click(object sender, EventArgs e)
        {
            if (itemSeleccion(lvPantalla) != -1)
            {
                lvPantalla.Items.RemoveAt(itemSeleccion(lvPantalla));

            }
            else
            {
                MessageBox.Show("Seleccione un item válido", "No se ha seleccionado nada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void cargarDatos()
        {
            lvPantalla.Items.Clear();
            conexion.codigo = "123";
            conexion.clave = "123";
            entidadRol.mNombreRol = txtNombreRol.Text;
            dtrRol = clRol.mConsultarRolesPriv(conexion,entidadRol);
            if (dtrRol != null)
                while (dtrRol.Read())
                {
                    ListViewItem item = new ListViewItem(dtrRol.GetString(0));
                    item.SubItems.Add(dtrRol.GetString(1));
                    for (int i = 2; i <= 5; i++)
                    {
                        if (dtrRol.GetBoolean(i) == true)
                        {
                            item.SubItems.Add("Sí");
                        }
                        else
                        {
                            item.SubItems.Add("No");
                        }
                    }
                    lvPantalla.Items.Add(item);
                }
        }

        private void txtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)(Keys.Enter))
            {
                cargarDatos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreRol.Text = "";
            lvPantalla.Items.Clear();
            chkConsultar.Checked =false ;
            chkEliminar.Checked = false;
            chkInsertar.Checked = false;
            chkModificar.Checked = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvPantalla.Items != null)
            {
                if (lvPantalla.Items[0].Text != "") { 
                entidadRol.mNombreRol = lvPantalla.Items[0].Text;
                dtrRol = clRol.mConsultaIdRoles(conexion, entidadRol);
                if (dtrRol != null)
                    if (dtrRol.Read())
                    {
                        entidadRolPantalla.mIdRol = dtrRol.GetInt32(0);
                        rolPantalla.mEliminarRolPantalla(conexion, entidadRolPantalla);
                        clRol.mEliminarRol(conexion, entidadRol);
                        limpiar();
                         MessageBox.Show("Rol eliminado","Éxito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
