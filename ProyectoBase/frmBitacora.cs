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
using System.Collections;

namespace Vista
{
    public partial class frmBitacora : Form
    {

        clsEntidadUsuario entidadUsuario;
        DateTime fecha;
        clsBitacora clbitacora;
        SqlDataReader dtrUsuario;
        SqlDataReader dtrBitacora;
        clsUsuario usuario;
        frmAcceso frmAcceso;
        clsConexion conexion;
        clsEntidadBitacora entidadBitacora;
        frmListaUsuario frmLista;
        DateTime localDate = DateTime.Now;
        SqlDataReader dtrPrivilegiosUsuaio;

        public frmBitacora(clsConexion conexion)
        {
            usuario = new clsUsuario();
            fecha = new DateTime();
            clbitacora = new clsBitacora();
            entidadUsuario = new clsEntidadUsuario();
            frmAcceso = new frmAcceso();
            this.conexion = conexion;
            entidadBitacora = new clsEntidadBitacora();
            frmLista = new frmListaUsuario(conexion, this);
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmLista.Show();
            this.Hide();
        }

        //Coloca en el listView las bitácoras de uno o varios usuarios seleccionados
        //realiza la consulta a la BD a partir de los ID de los usuarios seleccionados
        public void mConsultarBitacora(ArrayList idUsuarios)
        {
            lvBitacora.Items.Clear();
            for (int i = 0; i < idUsuarios.Count; i++)
            {
                entidadBitacora.setIdiUsuario(Convert.ToInt32(idUsuarios[i]));
                dtrBitacora = clbitacora.mConsultaEspecifica(conexion, entidadBitacora);
                if (dtrBitacora != null)
                    while (dtrBitacora.Read())
                    {
                        ListViewItem item = new ListViewItem(dtrBitacora.GetDateTime(0).ToString("dd/MM/yyyy"));
                        item.SubItems.Add(dtrBitacora.GetString(1));


                        entidadUsuario.mIdUsuario = entidadBitacora.getIdUsuario();
                        dtrUsuario = usuario.mBuscarUsuario(conexion, entidadUsuario);
                        if (dtrUsuario != null)
                            if (dtrUsuario.Read())
                            {
                                item.SubItems.Add(dtrUsuario.GetString(1));
                                lvBitacora.Items.Add(item);
                            }
                    }
            }
        }


        private void frmBitacora_Load(object sender, EventArgs e)
        {

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
                            {

                                mActivarBotonesAdministrador(dtrPrivilegiosUsuaio);

                            }
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

        //Llena el listview con todas las bitácoras existentes en la BD
        public void llenarDatosTabla()
        {
            dtrBitacora = clbitacora.mConsultaGeneral(conexion);
            if (dtrBitacora != null)
                while (dtrBitacora.Read())
                {
                    ListViewItem item = new ListViewItem(dtrBitacora.GetDateTime(0).ToString("dd/MM/yyyy"));
                    item.SubItems.Add(dtrBitacora.GetString(1));

                    entidadUsuario.mIdUsuario = dtrBitacora.GetInt32(2);
                    dtrUsuario = usuario.mBuscarUsuario(conexion, entidadUsuario);
                    if (dtrUsuario != null)
                        if (dtrUsuario.Read())
                        {
                            item.SubItems.Add(dtrUsuario.GetString(1));
                            lvBitacora.Items.Add(item);
                        }

                }
        }

        //Vuelve a colocar todas en el listview, todas las bitácoras existentes en la BD
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            lvBitacora.Items.Clear();
            llenarDatosTabla();
        }

        //Busca las bitácoras de un usuario, cada vez que se levante una tecla
        //Para mostrarlas en el listview
        private void tbNombreUsuario_KeyUp(object sender, KeyEventArgs e)
        {

            if (txtNombreUsuario.Text != "")
            {
                entidadUsuario.mUsuario = txtNombreUsuario.Text;
                dtrUsuario = usuario.mConsultaIdUsuario(conexion, entidadUsuario);

                if (dtrUsuario != null)
                    if (dtrUsuario.Read())
                    {
                        ArrayList array = new ArrayList();
                        array.Add(dtrUsuario.GetInt32(0));
                        lvBitacora.Items.Clear();
                        mConsultarBitacora(array);
                    }
            }
            else
            {
                lvBitacora.Items.Clear();
                llenarDatosTabla();
            }

        }
        //Activa las opciones de búsqueda, en caso de un usuario posea los permisos
        public void mActivarBotonesAdministrador(SqlDataReader dtrPermisos)
        {

            if (dtrPermisos.GetBoolean(2))//Se activan opciones de búsqueda
            {
                btnConsultar.Enabled = true;
                btnRefrescar.Enabled = true;
                txtNombreUsuario.Enabled = true;
                llenarDatosTabla();
            }

        }
    }
}
