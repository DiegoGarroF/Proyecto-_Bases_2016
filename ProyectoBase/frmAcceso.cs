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
        SqlDataReader dtrBitacora;
        int contador = 0;
        clsEntidadUsuario entidadUsuario;
        clsUsuario usuario;
        clsEntidadBitacora entidadBitacora;
        clsBitacora clBitacora;
        string ClaveTemporal;
        #endregion

        //Inicializamos los atributos que utilizaremos en toda la clase
      
        private clsConexion conexion;
        public frmAcceso()
        {
            
            InitializeComponent();
            this.conexion = new clsConexion("123","123", "BDBiblioteca");
            entidadUsuario = new clsEntidadUsuario();
            usuario = new clsUsuario();
            entidadBitacora = new clsEntidadBitacora();
            clBitacora = new clsBitacora();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {//no borrar

        }
        public Boolean mInsertarBitacora()
        {
            entidadBitacora.setFecha(DateTime.Today);
            dtrBitacora = clBitacora.mHoraServidor(conexion);
            if(dtrBitacora!=null)
                if(dtrBitacora.Read())
                      entidadBitacora.setHora(dtrBitacora.GetString(0));

            clsUsuario usuario = new clsUsuario();
            entidadUsuario.mUsuario = clsConstantes.nombreUsuario;
            dtrUsuario = usuario.mConsultaIdUsuario(conexion, entidadUsuario);
            if (dtrUsuario != null)
                if (dtrUsuario.Read())
                {
                    entidadBitacora.setIdiUsuario(dtrUsuario.GetInt32(0));
                }

            return clBitacora.mInsertarBitacora(conexion, entidadBitacora);
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
        public string guardarUsuario()
        {
            return txtUsuario.Text;
        }
        //Este método permite validar la existencia del usuario segun
        //el codigo y clave digitada
        public Boolean mValidarDatos()
        {
            if (contador <= 2)
            {


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
                                       
                        if (dtrUsuario.GetInt32(6) == 0 || dtrUsuario.GetInt32(6) == 1 || dtrUsuario.GetInt32(6) == 2)
                        {
                            entidadUsuario.mEstadoUsuario = dtrUsuario.GetInt32(6);

                            //ClaveTemporal = desencriptar(dtrUsuario.GetString(2));
                            if (mValidarContraseña(dtrUsuario.GetString(2)))
                            {
                                if (dtrUsuario.GetBoolean(7) == false)
                                {
                                    //LLamar ventana para cambiar pw
                                    guardarUsuario();
                                    frmCambioContrsena contraseña = new frmCambioContrsena(this, conexion);
                                    contraseña.Show();
                                    this.Visible = false;

                                    return false;
                                }
                                else
                                {
                                    
                                        btnIngresar.Enabled = true;
                                        this.txtClave.Enabled = false;
                                        this.txtUsuario.Enabled = false;
                                        return true;

                                    
                                   
                                }
                             
                            }//fin del if que valida las contraseñas
                            else
                            {
                                entidadUsuario.mEstadoUsuario = (dtrUsuario.GetInt32(6)+1);
                                usuario.mModificarEstadoUsuario(conexion, entidadUsuario);
                                MessageBox.Show("Intentos Restantes "+(2-dtrUsuario.GetInt32(6)),"Contraseña Incorrecta", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                return false;
                            }
                            
                            
                        }// fin del if de estado usuario
                        else
                        {
                            MessageBox.Show("El usuario esta bloqueado", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            return false;
                        }//Fin del pEntidadUsuario
                    }
                    else {
                        MessageBox.Show("Usuario incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            clsConstantes.nombreUsuario = entidadUsuario.mUsuario;
            frmMenuPrincipal menu = new frmMenuPrincipal(conexion, this);
            menu.Show();
            entidadUsuario.mEstadoUsuario = 0;
            clsConstantes.nombreUsuario = entidadUsuario.mUsuario;
          
            usuario.mModificarEstadoUsuario(conexion, entidadUsuario);
            mInsertarBitacora();
            this.SetVisibleCore(false);
            
        }

        public Boolean verificarEncriptacion(string claveTemporar)
        {
            if(desencriptar(claveTemporar)!= "")
            {
                return true;
            }
            return false;
        }

       public string desencriptar(String claveAlmacenada)
        {
            string resultado = string.Empty;
            byte[] desencriptar = Convert.FromBase64String(claveAlmacenada);
            resultado = System.Text.Encoding.Unicode.GetString(desencriptar);
            return resultado;
        }
        public string encriptar(String contraseña)
        {
            string resultado = string.Empty;
            byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(contraseña);
            resultado = Convert.ToBase64String(encriptar);
            return resultado;
        }
        public Boolean mValidarContraseña(String claveAlmacenada)
        {
            
            if (this.txtClave.Text.Equals(claveAlmacenada))
            {
                return true;
            }
            else
            {

                ClaveTemporal = encriptar(txtClave.Text);

                if (this.txtClave.Text.Equals(desencriptar(ClaveTemporal)))
                {
                    if (encriptar(this.txtClave.Text).Equals(claveAlmacenada))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }                    
                }
                else
                {
                    return false;
                }
            }
        }

        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            this.lbMensaje.Text = "EXIT";
        }

        private void frmAcceso_MouseMove(object sender, MouseEventArgs e)
        {
            this.lbMensaje.Text = "";
        }

        private void btnIngresar_MouseMove(object sender, MouseEventArgs e)
        {
            this.lbMensaje.Text = "MORE";
        }
    }


}
