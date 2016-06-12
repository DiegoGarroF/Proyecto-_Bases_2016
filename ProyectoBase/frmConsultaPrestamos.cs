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
    public partial class frmConsultaPrestamos : Form
    {
        #region Atributos
        private SqlDataReader dataReader;
        private clsPrestamo prestamo;
        private int idUsuarios;
        private clsConexion conexion;
        #endregion
        public frmConsultaPrestamos(clsConexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.prestamo = new clsPrestamo();
            conexion.clave = "123";
            conexion.codigo = "123";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaPrestamos_Load(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvConsultaPrestamos_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvConsultaPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < lvConsultaPrestamos.Items.Count; i++)
            {
                if (lvConsultaPrestamos.Items[i].Selected)
                {
                    idUsuarios = Convert.ToInt32(lvConsultaPrestamos.Items[i].Text);
                }
            }
        }
        public int mIdUsuario
        {
            get { return idUsuarios; }
            set { idUsuarios = value; }
        }
        public void mCargarListViewPrestamos()
        {
            dataReader = prestamo.mConsultaGeneral(conexion);
            if (dataReader!= null)
            {
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(dataReader.GetInt32(0)));
                    item.SubItems.Add(Convert.ToString(dataReader.GetDateTime(1)));
                    item.SubItems.Add(Convert.ToString(dataReader.GetInt32(2)));
                    item.SubItems.Add(Convert.ToString(dataReader.GetInt32(3)));
                    item.SubItems.Add(Convert.ToString(dataReader.GetInt32(4)));
                    lvConsultaPrestamos.Items.Add(item);
                }
            }

        }
    }
}
