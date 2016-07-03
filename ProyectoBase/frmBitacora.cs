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
        DateTime fecha ;
        clsBitacora clbitacora;
        SqlDataReader dtrUsuario;
        SqlDataReader dtrBitacora;
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

        public void mConsultarBitacora(ArrayList idUsuarios)
        {
            lvBitacora.Items.Clear();
            for(int i=0; i<idUsuarios.Count; i++)
            {
                entidadBitacora.setIdiUsuario(Convert.ToInt32(idUsuarios[i]));
                dtrBitacora = clbitacora.mConsultaEspecifica(conexion, entidadBitacora);
                if(dtrBitacora!=null)
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
            llenarDatosTabla();
        }

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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            llenarDatosTabla();
        }

        private void tbNombreUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (txtNombreUsuario.Text != "") { 
            entidadUsuario.mUsuario = txtNombreUsuario.Text;
            dtrUsuario= usuario.mConsultaIdUsuario(conexion, entidadUsuario);
            
            if(dtrUsuario!=null)
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
    }
}
