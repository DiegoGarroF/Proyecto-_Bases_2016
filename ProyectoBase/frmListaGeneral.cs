using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Controlador;
using Modelo;


namespace Vista
{
    public partial class frmListaGeneral : Form
    {
        private SqlDataReader dtrUsuario;
        private clsUsuario usuario;
        private clsConexion conexion;
        private int idUsuario;
        public frmListaGeneral(clsConexion cone)
        {
            InitializeComponent();
            usuario = new clsUsuario();
            this.conexion = cone;
        }

        private void frmListaGeneral_Load(object senqder, EventArgs e)
        {
            dtrUsuario = usuario.mConsultaGeneral(conexion);
            while (dtrUsuario.Read())
            {
                ListViewItem item = new ListViewItem(Convert.ToString(dtrUsuario.GetInt32(0)));
                item.SubItems.Add(dtrUsuario.GetString(1)); 
                lvGeneral.Items.Add(item);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvGeneral_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvGeneral.Items.Count; i++)
            {
                if (lvGeneral.Items[i].Selected)
                {
                    idUsuario = Convert.ToInt32(lvGeneral.Items[i].Text);
                }
            }
        }
        public int mIdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
    }
}
