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

        private int stUsuario;
        SqlDataReader strUsuarios;
        clsUsuario usuario;
        clsEntidadUsuario entidadUsuario;

        clsConexion conexion;

        #endregion
        public frmListaUsuario(clsConexion conexion)
        {
            this.conexion = conexion;
            usuario = new clsUsuario();
            entidadUsuario = new clsEntidadUsuario();
            InitializeComponent();
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            strUsuarios = usuario.mConsultarListaBitacora(conexion);
            lvListaUusario.Items.Clear();
            if (strUsuarios != null)
                while (strUsuarios.Read())
                {
                    ListViewItem item = new ListViewItem(strUsuarios.GetString(0));
                    item.SubItems.Add(strUsuarios.GetString(1));
                    item.SubItems.Add(strUsuarios.GetString(2));
                    lvListaUusario.Items.Add(item);
                }
        }

        private void lvListaUusario_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvListaUusario.Items.Count; i++)
            {
                if (lvListaUusario.Items[i].Selected)
                {
                    stUsuario = Convert.ToInt32(lvListaUusario.Items[i].Text);
                }
            }
        }

        private void lvListaUusario_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < lvListaUusario.Items.Count; i++)
            {
                if (lvListaUusario.Items[i].Selected)
                {
                    stUsuario = Convert.ToInt32(lvListaUusario.Items[i].Text);
                }
            }
        }

        public int getUsuario()
        {
            return stUsuario;
        }


        private void lvListaUusario_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            for (int i = 0; i < lvListaUusario.Items.Count; i++)
            {
                if (lvListaUusario.Items["Nombre"].Selected)
                {
                    if (lvListaUusario.Items[i].Text == entidadUsuario.mNombre)
                    {

                       // stUsuario = Convert.ToInt32(usuario.mConsultaIdUsuario(conexion));
                    }

                }

            }
        }
    }
}
