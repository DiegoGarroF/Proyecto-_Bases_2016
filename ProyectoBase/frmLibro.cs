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
    public partial class frmLibro : Form
    {
        const string opcion2="";
        public frmLibro()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipal frmMenu = new frmMenuPrincipal();
            frmMenu.Visible = true;
        }

        private void frmLibro_Load(object sender, EventArgs e)
        {

        }
        public void setBtnAccionTipo(String titulo)
        {
            btnMultiFuncion.Text = titulo;
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Este Metodo sera el encargado de verificar, el texto que tiene el boton multifuncion
        //y asi realizar la accion correspondiente 
        private void btnMultiFuncion_Click(object sender, EventArgs e)
        {
            if(btnMultiFuncion.Text.Equals(""))
            {

            }
        }
    }
}
