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
    public partial class frmListaUsuario : Form
    {

        #region Atributos 
        frmBitacora ventanaBitacora;
        private String stUsuario;
        SqlDataReader strUsuarios;
        clsUsuario usuario;
        clsEntidadUsuario entidadUsuario;
        private ArrayList idUsuariosSeleccionados;
        clsConexion conexion;

        #endregion
        public frmListaUsuario(clsConexion conexion,frmBitacora ventana)
        {
            this.conexion = conexion;
            usuario = new clsUsuario();
            entidadUsuario = new clsEntidadUsuario();
            InitializeComponent();            
            this.ventanaBitacora = ventana;
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            ventanaBitacora.Show();
            this.Hide();
        }

        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            strUsuarios = usuario.mConsultarListaBitacora(conexion);            
            dgvUsuarios.Rows.Clear();
            if (strUsuarios != null)
                while (strUsuarios.Read())
                {
                    int reglon = dgvUsuarios.Rows.Add();                    
                    dgvUsuarios.Rows[reglon].Cells["ColNombre"].Value = strUsuarios.GetString(0);
                    dgvUsuarios.Rows[reglon].Cells["ColApellidos"].Value = strUsuarios.GetString(1);
                    dgvUsuarios.Rows[reglon].Cells["ColTipoUsuario"].Value = strUsuarios.GetString(2);
                    dgvUsuarios.Rows[reglon].Cells["ColIdUsuario"].Value = strUsuarios.GetInt32(3);
                    dgvUsuarios.Rows[reglon].Cells["ColUsuario"].Value = strUsuarios.GetString(4);

                }
        }

        private void lvListaUusario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < lvListaUusario.Items.Count; i++)
            //{
            //    if (lvListaUusario.Items[i].Selected)
            //    {
            //        stUsuario = lvListaUusario.Items[i].Text;
            //    }
            //}
        }

        private void lvListaUusario_DoubleClick(object sender, EventArgs e)
        {
            //for (int i = 0; i < lvListaUusario.Items.Count; i++)
            //{
            //    if (lvListaUusario.Items[i].Selected)
            //    {
            //        stUsuario = lvListaUusario.Items[i].Text;
            //    }
            //}
        }

        public String getUsuario()
        {
            return stUsuario;
        }


        private void lvListaUusario_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            //for (int i = 0; i < lvListaUusario.Items.Count; i++)
            //{
            //    if (lvListaUusario.Items[i].Selected)
            //    {

            //        stUsuario = lvListaUusario.Items[i].Text;
            //     }

                

            //}
        }

        private void dgvUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idUsuariosSeleccionados = new ArrayList();
            foreach (DataGridViewRow dgv in dgvUsuarios.SelectedRows)
            {
                idUsuariosSeleccionados.Add(dgv.Cells["ColIdUsuario"].Value);

            }
            ventanaBitacora.mConsultarBitacora(idUsuariosSeleccionados);
            this.Hide();
            ventanaBitacora.Show();
        }

        public ArrayList mIdUsuariosSeleccionados()
        {
            return idUsuariosSeleccionados;
        }
    }
}
