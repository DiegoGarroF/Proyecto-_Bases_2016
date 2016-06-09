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
        SqlDataReader dtrUsuario;
        clsUsuario usuario;
        clsConexion conexion;
        
        public frmBitacora(clsConexion conexion)
        {
            usuario = new clsUsuario();
            entidadUsuario = new clsEntidadUsuario();
            this.conexion = conexion;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmListaUsuario frmLista = new frmListaUsuario();
            frmLista.Show();

          /*  dtrUsuario = usuario.mConsultaGeneral(conexion);
            if (tbNombreUsuario != null)
            {
                while (dtrUsuario.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(dtrUsuario.GetInt32(0)));
                    item.SubItems.Add(dtrUsuario.GetString(1));
                    lvBitacora.Items.Add(item);
                }
            }*/
        }

        
      
        private void frmBitacora_Load(object sender, EventArgs e)
        {
        }
    }
}
