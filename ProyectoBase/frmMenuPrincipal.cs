﻿using System;
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
        public frmMenuPrincipal()
        {
            InitializeComponent();
            usuario = new frmUsuario(this);
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
            usuario.controlAgregarRolPriv(0);
            usuario.Show();
        }

        private void opcionNuevoLibro_Click(object sender, EventArgs e)
        {
            frmLibro nuevoLibro = new frmLibro();
            nuevoLibro.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.AGREGAR));
            nuevoLibro.Visible = true;
            this.Close();
        }

        private void opcionModificarLibro_Click(object sender, EventArgs e)
        {
            frmLibro nuevoLibro = new frmLibro();
            nuevoLibro.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.MODIFICAR));
            nuevoLibro.Visible = true;
            this.Close();
        }

        private void opcionBuscarLibro_Click(object sender, EventArgs e)
        {
            frmLibro nuevoLibro = new frmLibro();
            nuevoLibro.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.CONSULTAR));
            nuevoLibro.Visible = true;
            this.Close();
        }

        private void opcionEliminarLibro_Click(object sender, EventArgs e)
        {
            frmLibro nuevoLibro = new frmLibro();
            nuevoLibro.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.ELIMINAR));
            nuevoLibro.Visible = true;
            
            this.Close();
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
            usuario.Show();
        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.CONSULTAR));
            this.Hide();
            usuario.controlAgregarRolPriv(2);
            usuario.Show();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario.setBtnAccionTipo(mEstablecerTipoBoton(clsConstantes.ELIMINAR));
            this.Hide();
            usuario.controlAgregarRolPriv(2);
            usuario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacora frmBitacora = new frmBitacora();
            frmBitacora.Show();
        }
    }
}
