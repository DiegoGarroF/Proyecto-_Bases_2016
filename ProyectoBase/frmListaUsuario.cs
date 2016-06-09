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
    public partial class frmListaUsuario : Form
    {

        #region Atributos 

        private String stUsuario;
        SqlDataReader strUsuarios;
        clsUsuario usuario;

        clsConexion conexion;

        #endregion
        public frmListaUsuario()
        {
            conexion = new clsConexion();
            usuario = new clsUsuario();
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lvListaUusario.Items.Count; i++)
            {
                if (lvListaUusario.Items[i].Selected)
                {
                    stUsuario = lvListaUusario.Items[i].Text;

                }
            }
          
        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            strUsuarios = usuario.mConsultaGeneral(conexion);
            while (strUsuarios.Read())
            {
                ListViewItem lista;
                lista = lvListaUusario.Items.Add(strUsuarios.GetString(0));
            }
        }
    }
}
