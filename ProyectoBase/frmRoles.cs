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

namespace ProyectoBase
{
    public partial class frmRoles : Form
    {
        clsConexion conexion;
        clsEntidadRol entidadRol;
        clsRol clRol;

        public frmRoles()
        {
            conexion = new clsConexion();
            entidadRol = new clsEntidadRol();
            clRol = new clsRol();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreRol.Text != "")
            {
                //int idRol = -1;
                entidadRol.mNombreRol = txtNombreRol.Text;
            else
            {
                    MessageBox.Show("Seleccione un rol válido", "Rol no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Se compara si se está asignando un rol o privilegio a un usuario, y si además se llenaron todos los datos del usuario
                if ((mValidarInformacionRoles() == true & mValidarPermisos(lvPantalla) == true))
                {
                    //Se realiza inserción de roles y privilegios directos
                    if (mValidarPermisos(lvPantalla) == true)
                    {
                        if (clRol.mInsertarRol(conexion, entidadRol))
                        {
                            MessageBox.Show("Se ha insertado el usuario", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al insertar el usuario", "Fracaso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Información insuficiente para agregar un usuario", "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                 }
        }// fin del metodo

        public Boolean mValidarInformacionRoles()
        {
            if (txtNombreRol.Text != "")
            {
                return true;
            }
            return false;
        }

        //Valida que al menos se vaya a insertar un rol o un privilegio
        public Boolean mValidarPermisos(ListView lista)
        {
            if (lista.Items.Count > 0)
            {
                return true;
            }

            return false;
        }

        public void limpiar()
        {
           
            txtNombreRol.Text = "";
            cbPantalla.SelectedIndex = -1;
            lvPantalla.Items.Clear();
            

            chkConsultar.Checked = false;
            chkEliminar.Checked = false;
            chkInsertar.Checked = false;
            chkModificar.Checked = false;

        }




    }
}
