﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Llamado de las referencias propias del proyecto
using System.Data.SqlClient;
using Modelo;
using Controlador;


namespace Vista
{
    public partial class frmAcceso : Form
    {
        #region
        
        SqlDataReader dtrUsuario; //Retorno de las tuplas
        int contador = 0;
        clsEntidadUsuario entidadUsuario;
        clsUsuario usuario;
        #endregion

        //Inicializamos los atributos que utilizaremos en toda la clase
        private clsConexion conexion;
        public frmAcceso()
        {
            
            InitializeComponent();
            this.conexion = new clsConexion();
            entidadUsuario = new clsEntidadUsuario();
            usuario = new clsUsuario();            
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {//no borrar


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Acción para salir del sistema
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                if (txtUsuario.Text != "")
                {
                    this.txtClave.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese un usuario válido","OJO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }                
                
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                if (mValidarDatos() == true)
                {
                    
                }               
            }
        }//Fin del keyPress


        #region Metodos
        //Este método permite validar la existencia del usuario segun
        //el codigo y clave digitada
        public Boolean mValidarDatos()
        {
            if (contador <= 2)
            {
                //llenado de variables o atributos del servidor para conectarme a la BD
                conexion.codigo="123";
                conexion.clave="123";

                //llenado de los atributos de la clase EntidadUsuario
                entidadUsuario.mUsuario = txtUsuario.Text;
                entidadUsuario.mContrasena = txtClave.Text;

                //Consultamos si el usuario existe
                dtrUsuario = usuario.mLogueoPrincipal(conexion,entidadUsuario);
                                
                //Evaluamos si retorna tuplas o datos
                if (dtrUsuario != null)
                {
                    if (dtrUsuario.Read())
                    {                        
                        if (dtrUsuario.GetBoolean(6) == true)
                        {
                            if (dtrUsuario.GetBoolean(7) == false)
                            {
                                //LLamar ventana para cambiar pw
                                return false;
                            }
                            else
                            {
                                btnIngresar.Enabled = true;
                                return true;
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("El usuario esta bloqueado", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            return false;
                        }//Fin del pEntidadUsuario
                    }
                    else {
                        MessageBox.Show("Usuario o contraseña errónea", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }//Fin del if del Read  
                }
                else {
                    MessageBox.Show("Usuario o contraseña errónea", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }//Fin del if del null

            }
            else {
                MessageBox.Show("Usted dijito 3 veces su usuario de forma erronea","Usuario bloqueado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }//Fin del if del contador
        }//Fin del metodo mValidarDatos
        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal(conexion);
            menu.Show();
            this.SetVisibleCore(false);
            
        }
    }
}
