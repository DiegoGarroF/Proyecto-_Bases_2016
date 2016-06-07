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
        public frmListaGeneral(clsConexion cone)
        {
            InitializeComponent();
            usuario = new clsUsuario();
            this.conexion = cone;
        }

        private void frmListaGeneral_Load(object sender, EventArgs e)
        {
            dtrUsuario = usuario.mConsultaGeneral(conexion);
            while (dtrUsuario.Read())
            {
                ListViewItem lista;
                lista = lvGeneral.Items.Add(Convert.ToString(dtrUsuario.GetInt32(0)));
                lista = lvGeneral.Items.Add(dtrUsuario.GetString(1));
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
