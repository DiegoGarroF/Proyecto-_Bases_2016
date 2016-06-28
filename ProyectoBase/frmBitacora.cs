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
    public partial class frmBitacora : Form
    {

        clsEntidadUsuario entidadUsuario;
        clsBitacora clbitacora;
        SqlDataReader dtrUsuario;
        clsUsuario usuario;
        Object entidad;
        clsConexion conexion;
        clsEntidadBitacora entidadBitacora;
        frmListaUsuario frmLista;
        DateTime localDate = DateTime.Now;

        public frmBitacora(clsConexion conexion)
        {
            usuario = new clsUsuario();
            clbitacora = new clsBitacora();
            entidadUsuario = new clsEntidadUsuario();
            this.conexion = conexion;
            entidadBitacora = new clsEntidadBitacora();
            frmLista = new frmListaUsuario(conexion);
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            frmLista.ShowDialog();
            if (frmLista.getUsuario() != "")
            {
                entidadUsuario.mNombre=frmLista.getUsuario();
                tbNombreUsuario.Text = Convert.ToString( frmLista.getUsuario()); // para cargar
                mConsultarBitacora();

            }


        }

        public void mConsultarBitacora()
        {
            dtrUsuario = clbitacora.mConsultaGeneral(conexion);
            if (dtrUsuario != null)
            {
                if (dtrUsuario.Read())//si existe
                {
                    this.tbNombreUsuario.Text = dtrUsuario.GetString(0);
                }//Fin del if si existe

            }//Fin del if dtrEstudiante!=null

        }


        private void frmBitacora_Load(object sender, EventArgs e)
        {
            dtrUsuario = clbitacora.mConsultaGeneral(conexion);

            if (frmLista.getUsuario() == entidadUsuario.mNombre)
            {

                // dtrUsuario = clbitacora.mInsertarBitacora(conexion, pEntidadBitacora);
                if (entidadUsuario.mIdUsuario == entidadBitacora.getIdUsuario())
                {
                    entidadBitacora.setFecha(Convert.ToDateTime(entidadUsuario.mFechaModificacion));
                    entidadBitacora.setHora(localDate);
                    if (entidad is clsEntidadUsuario)
                        entidadBitacora.setTabla("tbUsuario");
                    else
                        if (entidad is clsEntidadLibro)
                    {
                        entidadBitacora.setTabla("tbLibro");
                        entidadBitacora.setDescripcion("hola");
                    }

                    else
                        if (entidad is clsEntidadPrestamo)
                    { 
                        entidadBitacora.setTabla("tbPrestamo");
                        entidadBitacora.setDescripcion("hola");
                    }
                    else
                        if (entidad is clsEntidadPantalla)
                    { 
                        entidadBitacora.setTabla("tbPantalla");
                    entidadBitacora.setDescripcion("hola");
                }
                else
                        if (entidad is clsEntidadRol)
                        entidadBitacora.setTabla("tbRol");
                    else
                        if (entidad is clsEntidadRolPantalla)
                        entidadBitacora.setTabla("tbRolPantalla");
                    else
                        if (entidad is clsUsuarioPantalla)
                        entidadBitacora.setTabla("tbUsuarioPantalla");
                    else
                        if (entidad is clsEntidadUsuarioRol)
                        entidadBitacora.setTabla("tbUsuarioRol");

                }

                lvBitacora.Items.Clear();
                if (dtrUsuario != null)
                    while (dtrUsuario.Read())
                    {
                        ListViewItem item = new ListViewItem(Convert.ToString(dtrUsuario.GetString(0)));
                        item.SubItems.Add(dtrUsuario.GetString(1));
                        item.SubItems.Add(dtrUsuario.GetString(2));
                        item.SubItems.Add(dtrUsuario.GetString(3));
                        lvBitacora.Items.Add(item);
                    }
            }
        }
    }
}
