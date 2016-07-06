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
using Controlador;
using System.Data.SqlClient;
namespace Vista
{
    public partial class frmMenuPrincipal : Form
    {
        private SqlDataReader dtr;
        private frmUsuario usuario;
        private clsConexion conexion;
        private clsLibro libro;
        private clsEntidadUsuario pEntidadUsuario;
        private frmLibro nuevoLibro;

        public frmMenuPrincipal(clsConexion conexion)
        {
            InitializeComponent();            
            this.conexion = conexion;
            this.libro = new clsLibro();
            this.pEntidadUsuario = new clsEntidadUsuario();
            this.nuevoLibro = new frmLibro(this.conexion);

            this.verificarPrivilegios(this.nuevoLibro.Name, opcionNuevoLibro);


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
            //usuario.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.AGREGAR));
            this.Hide();
            usuario.limpiar();
            //usuario.controlAgregarRolPriv(0);
            usuario.Show();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacora frmBitacora = new frmBitacora(conexion);
            frmBitacora.Show();
        }



        private void opcionMantenimientoLibros(object sender, EventArgs e)
        {

            nuevoLibro = new frmLibro(conexion);
            nuevoLibro.Visible = true;
            this.Close();
        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario = new frmUsuario(this,conexion);
            this.Hide();
            usuario.limpiar();            
            usuario.Show();
        }

        private void mantenimientoPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionPrestamos prestamos = new frmGestionPrestamos(conexion);
            prestamos.ShowDialog();
        }

        private void mantenimientoDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoles ventanaRoles = new frmRoles(this, conexion);
            this.Hide();
            ventanaRoles.Show();
        }

        public Boolean verificarPrivilegios(String nombreFrame, ToolStripMenuItem item)
        {

            dtr = libro.mSeleccionarIdUsuario(conexion, clsConstantes.nombreUsuario);
            if (dtr != null && dtr.Read())
            {
                pEntidadUsuario.mIdUsuario = dtr.GetInt32(0);
                dtr = libro.mObtenerRolesUsuario(this.conexion, Convert.ToString(dtr.GetInt32(0)), nombreFrame);
                while (dtr != null && dtr.Read())
                {
                    if (dtr.GetBoolean(0) || dtr.GetBoolean(1) || dtr.GetBoolean(2) || dtr.GetBoolean(3))
                    {
                        item.Visible = true;

                    }
                }
                dtr = libro.mObtenerPrivilegiosDirectos(this.conexion, Convert.ToString(pEntidadUsuario.mIdUsuario), nombreFrame);
                while (dtr != null && dtr.Read())
                {
                    if (dtr.GetBoolean(0) || dtr.GetBoolean(1) || dtr.GetBoolean(2) || dtr.GetBoolean(3))
                    {

                        item.Visible = true;
                    }
                }
            }
            return false;
        }
    }
}
