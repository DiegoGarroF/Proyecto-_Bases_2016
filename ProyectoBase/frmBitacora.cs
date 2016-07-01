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
        DateTime fecha ;
        clsBitacora clbitacora;
        SqlDataReader dtrUsuario;
        clsUsuario usuario;
        frmAcceso frmAcceso;
        clsConexion conexion;
        clsEntidadBitacora entidadBitacora;
        frmListaUsuario frmLista;
        DateTime localDate = DateTime.Now;

        public frmBitacora(clsConexion conexion)
        {
            usuario = new clsUsuario();
            fecha = new DateTime();
            clbitacora = new clsBitacora();
            entidadUsuario = new clsEntidadUsuario();
            frmAcceso = new frmAcceso();
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
                if (mInsertarBitacora() == true)
                {
                    llenarDatosTabla();
                }

            }


        }

        public void mConsultarBitacora()
        {
            dtrUsuario = clbitacora.mConsultaGeneral(conexion);
            if (dtrUsuario != null)
            {
                if (dtrUsuario.Read())//si existe
                {
                    this.tbNombreUsuario.Text = dtrUsuario.GetString(1);
                }//Fin del if si existe

            }//Fin del if dtrEstudiante!=null

        }

        public Boolean mInsertarBitacora()
        {
            if (frmAcceso.mValidarContraseña(Convert.ToString(clbitacora.mConsultarContraseña(conexion, entidadBitacora))) == true)
            {
                clbitacora.mInsertarBitacora(conexion, entidadBitacora);
                entidadBitacora.setFecha(DateTime.Today);
                entidadBitacora.setHora(DateTime.Now);
                entidadBitacora.setIdiUsuario(entidadUsuario.mIdUsuario);
                lvBitacora.Items.Clear();

                return true;
            }
            else
                return false;
        }
    


        private void frmBitacora_Load(object sender, EventArgs e)
        {
             
        }

        public void llenarDatosTabla()
        {
            dtrUsuario = clbitacora.mConsultaGeneral(conexion);

            if (frmLista.getUsuario() == entidadUsuario.mNombre)
            {

                if (entidadUsuario.mIdUsuario == entidadBitacora.getIdUsuario())
                {
                    entidadBitacora.setFecha(Convert.ToDateTime(entidadUsuario.mFechaModificacion));
                    entidadBitacora.setHora(localDate);

                }

                if (dtrUsuario != null)
                    while (dtrUsuario.Read())
                    {
                        if (entidadUsuario.mIdUsuario == entidadBitacora.getIdUsuario())
                        {
                            if (mInsertarBitacora() == true)
                            {
                                ListViewItem item = new ListViewItem(Convert.ToString(dtrUsuario.GetDateTime(0)));
                                item.SubItems.Add(dtrUsuario.GetString(1));
                                item.SubItems.Add(Convert.ToString(dtrUsuario.GetInt32(2)));
                                lvBitacora.Items.Add(item);
                            }
                        }
                    }

            }




        }
    }
}
