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

namespace Vista
{
    public partial class frmMenuPrincipal : Form
    {

        private frmUsuario usuario;
        private clsConexion conexion;
        public frmMenuPrincipal(clsConexion conexion)
        {
            InitializeComponent();
            usuario = new frmUsuario(this);
            this.conexion = conexion;

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
            usuario.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.AGREGAR));
            this.Hide();
            usuario.limpiar();
            usuario.controlAgregarRolPriv(0);
            usuario.Show();
        }

        public string mEstablecerTipoBoton(string tipo)
        {             
            switch (tipo)
            {
                case clsConstantes.AGREGAR:
                    return clsConstantes.AGREGAR;

                case clsConstantes.MODIFICAR:
                   return clsConstantes.MODIFICAR;
               
                case clsConstantes.CONSULTAR:                
                    return clsConstantes.CONSULTAR;

                case clsConstantes.ELIMINAR:
                    return clsConstantes.ELIMINAR;
                    
            }
            return null;
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.MODIFICAR));
            this.Hide();
            usuario.controlAgregarRolPriv(1);
            usuario.limpiar();
            usuario.Show();
        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.CONSULTAR));
            this.Hide();
            usuario.controlAgregarRolPriv(2);
            usuario.limpiar();
            usuario.Show();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.ELIMINAR));
            this.Hide();
            usuario.controlAgregarRolPriv(2);
            usuario.limpiar();
            usuario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacora frmBitacora = new frmBitacora(conexion);
            frmBitacora.Show();
        }

        private void agregarPréstamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestamos prestamos = new frmPrestamos();
            prestamos.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.AGREGAR));
            prestamos.ShowDialog();
        }

        private void modificarPréstamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestamos prestamos = new frmPrestamos();
            prestamos.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.MODIFICAR));
            prestamos.ShowDialog();
        }

        private void consultarPréstamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestamos prestamos = new frmPrestamos();
            prestamos.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.CONSULTAR));
            prestamos.ShowDialog();
        }

        private void eliminarPréstamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestamos prestamos = new frmPrestamos();
            prestamos.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.ELIMINAR));
            prestamos.ShowDialog();
        }

        private void opcionMantenimientoLibros(object sender, EventArgs e)
        {
            frmLibro nuevoLibro = new frmLibro(conexion);
            nuevoLibro.Visible = true;
            this.Close();
        }
    }
}
