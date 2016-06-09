using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmListaUsuario : Form
    {

        #region Atributos 

        private String stUsuario;

        #endregion
        public frmListaUsuario()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            frmBitacora frmBitacora = new frmBitacora();
            for (int i = 0; i < lvListaUusario.Items.Count; i++)
            {
                if (lvListaUusario.Items[i].Selected)
                {
                    stUsuario = lvListaUusario.Items[i].Text;

                }
            }
            frmBitacora.Show();
        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
