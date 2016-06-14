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

        private clsPantalla pantalla;
        private clsEntidadPantalla entidadPantalla;
        private SqlDataReader dtrPantalla;

        private frmMenuPrincipal menu;
        public frmUsuario(frmMenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.menu = menuPrincipal;
            entidadUsuario = new clsEntidadUsuario();
            usuario = new clsUsuario();
            conexion = new clsConexion();

            entidadRol = new clsEntidadRol();
            rol = new clsRol();

            entidadPantalla = new clsEntidadPantalla();
            pantalla = new clsPantalla();

            usuarioRol = new clsUsuarioRol();
            entidadUsuarioRol = new clsEntidadUsuarioRol();

            entidadUsuarioPantalla = new clsEntidadUsuarioPantalla();
            usuarioPantalla = new clsUsuarioPantalla();

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            
            dtrUsuario = pantalla.mConsultarPantallas(conexion);
            if(dtrUsuario!=null)
            while (dtrUsuario.Read())
            {
                cbPantalla.Items.Add(dtrUsuario.GetSqlString(0));

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }        

        public void llenarPrivilegiosUsuarioPantalla(ListViewItem I)
        {
            if (I.SubItems[1].Text == "No")
            {
                entidadUsuarioPantalla.mInsertar = false;
            }
            else
            {
                entidadUsuarioPantalla.mInsertar = true;
            }

            if (I.SubItems[2].Text == "No")
            {
                entidadUsuarioPantalla.mConsultar = false;
            }
            else
            {
                entidadUsuarioPantalla.mConsultar = true;
            }

            if (I.SubItems[3].Text == "No")
            {
                entidadUsuarioPantalla.mModificar = false;
            }
            else
            {
                entidadUsuarioPantalla.mModificar = true;
            }

            if (I.SubItems[4].Text == "No")
            {
                entidadUsuarioPantalla.mEliminar = false;
            }
            else
            {
                entidadUsuarioPantalla.mEliminar = true;
            }

        }

        public void agregarUsuarioRolPrivilegio(int idUsuarioAgregado)
        {            
                agregarUsuarioRol(idUsuarioAgregado);
                agregarUsuarioPrivilegio(idUsuarioAgregado);
                limpiar();
        }
        public void agregarUsuarioRol(int idUsuarioAgregado)
        {
            foreach (ListViewItem I in lvRoles.Items)
            {
                entidadRol.mNombreRol = I.SubItems[0].Text;
                dtrRol = rol.mConsultaIdRoles(conexion, entidadRol);
                if (dtrRol != null)
                    if (dtrRol.Read())
                    {
                        entidadUsuarioRol.mIdRol = dtrRol.GetInt32(0);
                        entidadUsuarioRol.mIdUsuario = idUsuarioAgregado;
                        usuarioRol.mInsertarUsuarioRol(conexion, entidadUsuarioRol);
                    }
            }
        }

        public void agregarUsuarioPrivilegio(int idUsuarioAgregado)
        {
            entidadUsuarioPantalla.mIdUsuario = idUsuarioAgregado;
            foreach (ListViewItem I in lvPrivilegios.Items)
            {
                entidadPantalla.mNombrePantalla = I.SubItems[0].Text;
                dtrPantalla = pantalla.mConsultaIdPantalla(conexion, entidadPantalla);
                if (dtrPantalla != null)
                    if (dtrPantalla.Read())
                    {
                        entidadUsuarioPantalla.mIdPantalla = dtrPantalla.GetInt32(0);
                        entidadUsuarioPantalla.mIdUsuario = idUsuarioAgregado;
                        llenarPrivilegiosUsuarioPantalla(I);
                        usuarioPantalla.mInsertarUsuarioPantalla(conexion, entidadUsuarioPantalla);               
                    }
            }
        }

        public int seleccionIdUsuarioAgregado()
        {
            entidadUsuario.mUsuario = txtNombreUsuario.Text;
            dtrUsuario = usuario.mConsultaIdUsuario(conexion, entidadUsuario);
            if (dtrUsuario != null)
                if (dtrUsuario.Read())//Deve devolver solo 1
                {
                    return  dtrUsuario.GetInt32(0);
                }
            return -1;
        }

        private void mAgregarUsuario()
        {
            conexion.codigo = "123";
            conexion.clave = "123";
            int idUsuarioAgregado=-1;
            entidadUsuario.mUsuario = txtNombreUsuario.Text;
            entidadUsuario.mContrasena = txtContrasena.Text;
            entidadUsuario.mNombre = txtNombre.Text;
            entidadUsuario.mTipoUsuario = cbTipoUsuario.Text;
            entidadUsuario.mApellidos = txtApellidos.Text;

            //Se compara si se está asignando un rol o privilegio a un usuario, y si además se llenaron todos los datos del usuario
            if ((mValidarInfoUsuario() == true & mValidarPrivilegioUsuario() == true) || (mValidarRolUsuario() == true & mValidarInfoUsuario() == true))
            {                

                if (mValidarPrivilegioUsuario() & mValidarRolUsuario() == true)
                {                                                                     
                    if (usuario.mInsertarUsuario(conexion, entidadUsuario))
                    {
                        MessageBox.Show("Se ha insertado el usuario", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idUsuarioAgregado =seleccionIdUsuarioAgregado();
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
                    if (mValidarPrivilegioUsuario() == true)
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
                        if (mValidarRolUsuario() == true)
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
                    }
                }
            }
            else
            {
                MessageBox.Show("Información insuficiente para agregar un usuario", "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        public void modificarUsuario( int idUsuarioSeleccionado)
        {
            

            conexion.codigo = "123";
            conexion.clave = "123";
            
            entidadUsuario.mUsuario = txtNombreUsuario.Text;
            entidadUsuario.mContrasena = txtContrasena.Text;
            entidadUsuario.mNombre = txtNombre.Text;
            entidadUsuario.mTipoUsuario = cbTipoUsuario.Text;
            entidadUsuario.mApellidos = txtApellidos.Text;

            
            if (usuario.mModificarUsuario(conexion, entidadUsuario) == true)
            {
                MessageBox.Show("Se ha modificado el usuario","Modificación exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }

        }
        public void mEliminarUsuario()
        {
            conexion.clave = "123";
            conexion.codigo = "123";

            if (txtId.Text != "")
            {
                if (mEliminarUsuarioRol() == true & mEliminarUsuarioPrivilegio() == true)
                {
                    entidadUsuario.mIdUsuario = Convert.ToInt32(txtId.Text);
                    if (usuario.mEliminarUsuario(conexion, entidadUsuario, btnAgregar.Text))
                    {
                        MessageBox.Show("Usuario eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor indique el usuario a eliminar", "????", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }                    
        }

        public Boolean mEliminarUsuarioRol()
        {
           
                entidadUsuarioRol.mIdUsuario = Convert.ToInt32(txtId.Text);
                return usuarioRol.mEliminarRolesUsuario(conexion, entidadUsuarioRol, btnAgregar.Text);           
        }
        public Boolean mEliminarUsuarioPrivilegio()
        {
            entidadUsuarioPantalla.mIdUsuario = Convert.ToInt32(txtId.Text);
            return usuarioPantalla.mEliminarPantallasUsuario(conexion, entidadUsuarioPantalla, btnAgregar.Text);
        }

        public Boolean mValidarPrivilegioUsuario()
        {
            if (lvPrivilegios.Items.Count>0)
            {
                return true;
            }

            return false;
        }
        public Boolean mValidarRolUsuario()
        {
            if (lvRoles.Items.Count > 0)
            {
                return true;
            }

            return false;
        }

        public Boolean mValidarInfoUsuario()
        {
            if (txtNombre.Text!="" & txtApellidos.Text!="" & txtContrasena.Text!="" & txtNombreUsuario.Text!="" & txtNombre.Text!="" & txtApellidos.Text!="" & cbTipoUsuario.Text!="")
            {
                return true;
            }
            return false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            frmListaGeneral  lista = new frmListaGeneral(conexion);
            lista.cargarListViewUsuarios();
            lista.ShowDialog();

            conexion.codigo = "123";
            conexion.clave = "123";
            entidadUsuario.mIdUsuario = lista.mIdUsuario;
            dtrUsuario = usuario.mBuscarUsuario(conexion, entidadUsuario);

            if (lista.mIdUsuario != 0)
            {
                entidadUsuario.mIdUsuario=lista.mIdUsuario;
                txtId.Text = Convert.ToString(lista.mIdUsuario);
                mConsultaUsuario(dtrUsuario);
                cargarRolesUsuario();
                cargarPrivilPantallasUsuario();
            }
        }

        public void cargarRolesUsuario()
        {
            conexion.clave = "123";
            conexion.codigo = "123";
            entidadUsuario.mIdUsuario = Convert.ToInt32(txtId.Text);
            dtrRol = rol.mConsultaRolesUsuario(conexion,entidadUsuario);

            if (dtrRol != null)
            {
                while (dtrRol.Read())
                {
                    ListViewItem item = new ListViewItem(dtrRol.GetString(0));
                    lvRoles.Items.Add(item);
                }
            }
        }

        public void cargarPrivilPantallasUsuario()
        {
            conexion.clave = "123";
            conexion.codigo = "123";
            entidadUsuario.mIdUsuario =Convert.ToInt32( txtId.Text);
            dtrPantalla = pantalla.mConsultaPrivPantaUsuario(conexion, entidadUsuario);

            if (dtrPantalla != null)
            {
                while (dtrPantalla.Read())
                {
                    ListViewItem item = new ListViewItem(dtrPantalla.GetString(0));

                    if (dtrPantalla.GetBoolean(1) == true)
                    {
                        item.SubItems.Add("Sí");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }
                    if (dtrPantalla.GetBoolean(2) == true)
                    {
                        item.SubItems.Add("Sí");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }
                    if (dtrPantalla.GetBoolean(3) == true)
                    {
                        item.SubItems.Add("Sí");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }
                    if (dtrPantalla.GetBoolean(4) == true)
                    {
                        item.SubItems.Add("Sí");
                    }
                    else
                    {
                        item.SubItems.Add("No");
                    }
                    lvPrivilegios.Items.Add(item);
                }
            }
        }

        public void mConsultaUsuario(SqlDataReader dtrUsuario)
        {
            

            if (dtrUsuario != null)
            {
                if (dtrUsuario.Read())
                {
                    txtId.Text =Convert.ToString( dtrUsuario.GetInt32(0));
                    txtNombreUsuario.Text = dtrUsuario.GetString(1);
                    txtContrasena.Text= dtrUsuario.GetString(2);
                    txtNombre.Text = dtrUsuario.GetString(3);
                    txtApellidos.Text = dtrUsuario.GetString(4);
                    cbTipoUsuario.Text = dtrUsuario.GetString(5); 
                }
                else
                {
                    MessageBox.Show("Este usuario no existe","NOT FOUNT",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
        }
     

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar( )
        {
            txtId.Text = "Automático";
            txtContrasena.Text = "";
            txtNombreUsuario.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            cbRol.SelectedIndex = -1;
            cbPantalla.SelectedIndex = -1;
            cbTipoUsuario.SelectedIndex = -1;
            lvPrivilegios.Items.Clear();
            lvRoles.Items.Clear();

            chkConsultar.Checked = false;
            chkEliminar.Checked = false;
            chkInsertar.Checked = false;
            chkModificar.Checked = false;
            chkPrivilegio.Checked = false;
            chkRol.Checked = false;
        }

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
                MessageBox.Show("Seleccione una pantalla","Datos incompletos",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

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

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            if (itemSeleccion(lvRoles) != -1)
            {
                lvRoles.Items.RemoveAt(itemSeleccion(lvRoles));
            }
            else
            {
                MessageBox.Show("Seleccione un item válido","No se ha seleccionado nada",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mEliminarUsuario();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarDatosUsuario();
        }

        public void cargarDatosUsuario()
        {
            conexion.codigo = "123";
            conexion.clave = "123";
            entidadUsuario.mUsuario = txtNombreUsuario.Text;
            dtrUsuario = usuario.mBuscarPorLogin(conexion, entidadUsuario);
            mConsultaUsuario(dtrUsuario);
            cargarPrivilPantallasUsuario();
            cargarRolesUsuario();
        }

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.codigo = "123";
            conexion.clave = "123";
            mAgregarUsuario();
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(Char) Keys.Enter)
            {
                cargarDatosUsuario();
            }
        }
    }
}
