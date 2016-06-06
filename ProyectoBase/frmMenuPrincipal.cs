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
    public partial class frmMenuPrincipal : Form
    {
        

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario usuario = new frmUsuario(this);
            this.Hide();
            usuario.Show();
        }

        private void opcionNuevoLibro_Click(object sender, EventArgs e)
        {
            frmLibro nuevoLibro = new frmLibro();
            nuevoLibro.mSeleccion("Nuevo");
            nuevoLibro.Visible = true;
            this.Close();
        }

        private void opcionModificarLibro_Click(object sender, EventArgs e)
        {
            frmLibro nuevoLibro = new frmLibro();
            nuevoLibro.mSeleccion("Modificar");
            nuevoLibro.Visible = true;
            this.Close();
        }

        private void opcionBuscarLibro_Click(object sender, EventArgs e)
        {
            frmLibro nuevoLibro = new frmLibro();
            nuevoLibro.mSeleccion("Buscar");
            nuevoLibro.Visible = true;
            this.Close();
        }

        private void opcionEliminarLibro_Click(object sender, EventArgs e)
        {
            frmLibro nuevoLibro = new frmLibro();
            nuevoLibro.mSeleccion("Eliminar");
            nuevoLibro.Visible = true;
            this.Close();
        }
    }
}
