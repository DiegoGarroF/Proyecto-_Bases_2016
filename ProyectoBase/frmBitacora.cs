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
using System.Data.SqlClient;
using Controlador;

namespace Vista
{
    public partial class frmBitacora : Form
    {

        clsEntidadUsuario entidadUsuario;
        clsBitacora clbitacora;
        SqlDataReader dtrUsuario;
        clsUsuario usuario;
        clsConexion conexion;


        public frmBitacora(clsConexion conexion)
        {
            usuario = new clsUsuario();
            clbitacora = new clsBitacora();
            entidadUsuario = new clsEntidadUsuario();
            this.conexion = conexion;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmListaUsuario frmLista = new frmListaUsuario(conexion);
            frmLista.ShowDialog();
            if (frmLista.getUsuario() != " ")
            {
                entidadUsuario.mIdUsuario = Convert.ToInt32(frmLista.getUsuario());
                tbNombreUsuario.Text = frmLista.getUsuario(); // para cargar
                mConsultaUsuario();

            }


        }

        public void mConsultaUsuario()
        {
            dtrUsuario = usuario.mConsultaIdUsuario(conexion, entidadUsuario);
            if (dtrUsuario != null)
            {
                if (dtrUsuario.Read())//si existe
                {
                    this.tbNombreUsuario.Text = dtrUsuario.GetString(0);
                }//Fin del if si existe

            }//Fin del if dtrEstudiante!=null

        }


        private void frmBitacora_Load(object sender, EventArgs e)
        {
            dtrUsuario = clbitacora.mConsultaGeneral(conexion);
            if (clbitacora.mTrigger(conexion, entidadUsuario) == true)

                lvBitacora.Items.Clear();
            if (dtrUsuario != null)
                while (dtrUsuario.Read())
                {
                    ListViewItem item = new ListViewItem(dtrUsuario.GetString(0));
                    item.SubItems.Add(dtrUsuario.GetString(1));
                    item.SubItems.Add(dtrUsuario.GetString(2));
                    item.SubItems.Add(dtrUsuario.GetString(3));
                    item.SubItems.Add(dtrUsuario.GetString(4));
                    lvBitacora.Items.Add(item);
                }
        }
    }
}
