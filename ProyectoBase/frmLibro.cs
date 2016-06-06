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


        // Metodo para cuando el usuario selcciona una opcion del menu 
        public void mSeleccion(String opcion)
        {
            switch(opcion)
            {
                case "Nuevo":
                    this.btnMultiFuncion.Text = "Agregar";
                break;
                case "Modificar":
                    this.btnMultiFuncion.Text = "Modificar";
                    break;
                case "Buscar":
                    this.btnMultiFuncion.Text = "Consultar";
                    break;
                case "Eliminar":
                    this.btnMultiFuncion.Text = "Eliminar";
                    break;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
