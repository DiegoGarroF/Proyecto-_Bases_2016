using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
namespace Modelo
{
    public class clsConexion
    {
        //Area de la declaracion de todas las variables
        #region Atributos
        private string _codigo;
        private string _clave;
        private string _perfil;
        private string _baseDatos;

        private SqlConnection conexion; //Guardar la cadena de conexion del usuario con la BD
        private SqlCommand comando; //permite ejecutar los IMEC
        #endregion

        //Establecemos el metodo nicial
        #region Constructor

        public clsConexion()
        {
            this._codigo = "123";
            this._clave = "123";
            this._perfil = "";
            this._baseDatos = "BDBiblioteca";
        }

        #endregion

        //Propiedade de lectura y escritura
        #region GetySet

        public string codigo
        {
            set { this._codigo = value; }
            get { return this._codigo; }
        }
        public string clave
        {
            set { this._clave = value; }
            get { return this._clave; }
        }
        public string perfil
        {
            set { this._perfil = value; }
            get { return this._perfil; }
        }
        public string baseDatos
        {
            set { this._baseDatos = value; }
            get { return this._baseDatos; }
        }

        #endregion

        //Metodo para la conexion con la base de datos
        #region Metodos



        //Este metodo permitira ejecutar los select
        public SqlDataReader mSeleccionar(String sentencia, int codigo)
        {
            try
            {
                if (mConectar(this))
                {

                    comando = new SqlCommand(sentencia, conexion);
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@codigo", codigo);
                    return comando.ExecuteReader();
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }// fin del metodo mSeleccionar

        public SqlDataReader mSeleccionarTipoString(String sentencia, string codigo)//string strSentencia, clsConexion cone, int id)
        {
            try
            {
                if (mConectar(this))
                {

                    comando = new SqlCommand(sentencia, conexion);
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@codigo", codigo);
                    return comando.ExecuteReader();
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }// fin del metodo mSeleccionar

        public SqlDataReader mSeleccionarLogueo(String sentencia, string codigo, string contrasena)//string strSentencia, clsConexion cone, int id)
        {
            try
            {
                if (mConectar(this))
                {

                    comando = new SqlCommand(sentencia, conexion);
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@codigo", codigo);
                    comando.Parameters.AddWithValue("@contrasena", contrasena);
                    return comando.ExecuteReader();
                }
                else
                    return null;
            }
            catch
            {
                return null;
      }
        }// fin del metodo mSeleccionar

        public Boolean mEjecutarElimModif(string strSentencia, clsConexion cone, Object objeto, string tipo)
        {
            try
            {
                if (mConectar(cone))
                {
                    comando = new SqlCommand(strSentencia, conexion);
                    comando.CommandType = System.Data.CommandType.Text;
                                       
                        if (objeto is clsEntidadUsuarioRol) {

                        clsEntidadUsuarioRol entidadUsuarioRol = (clsEntidadUsuarioRol)objeto;
                        comando.Parameters.AddWithValue("@idUsuario", entidadUsuarioRol.mIdUsuario);
                        comando.ExecuteNonQuery();
                        }
                        else
                        {
                            if (objeto is clsEntidadUsuarioPantalla)
                            {
                                clsEntidadUsuarioPantalla entidadUsuarioPantalla = (clsEntidadUsuarioPantalla)objeto;
                                comando.Parameters.AddWithValue("@idUsuario", entidadUsuarioPantalla.mIdUsuario);
                                comando.ExecuteNonQuery();
                            }
                            else
                            {
                                if(objeto is clsEntidadUsuario)
                                {
                                    clsEntidadUsuario entidadUsuario = (clsEntidadUsuario)objeto;
                                    comando.Parameters.AddWithValue("@idUsuario", entidadUsuario.mIdUsuario);
                                    comando.Parameters.AddWithValue("@usuario", entidadUsuario.mUsuario);
                                comando.ExecuteNonQuery();
                                }

                                //Eliminar un Prestamo
                                else
                                {
                                    if(objeto is clsEntidadPrestamo)
                                    {
                                        clsEntidadPrestamo pEntidadPrestamo = (clsEntidadPrestamo)objeto;
                                        comando.Parameters.AddWithValue("@idLibro", pEntidadPrestamo.setGetidLibro);
                                        comando.Parameters.AddWithValue("@idUsuarioCliente", pEntidadPrestamo.setGetIdUsuariocliente);
                                        comando.ExecuteNonQuery();
                                    }
                                if (objeto is clsEntidadLibro)
                                {
                                    clsEntidadLibro pEntidadLibro = (clsEntidadLibro)objeto;
                                    comando.Parameters.AddWithValue("@id", pEntidadLibro.getIdLibro());
                                    comando.ExecuteNonQuery();
                                }
                                else
                                {
                                    if (objeto is clsEntidadRol)
                                    {
                                        clsEntidadRol pEntidadRol = (clsEntidadRol)objeto;
                                        comando.Parameters.AddWithValue("@nombre", pEntidadRol.mNombreRol);
                                        comando.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        if (objeto is clsEntidadRolPantalla)
                                        {
                                            clsEntidadRolPantalla pEntidadRolPantalla = (clsEntidadRolPantalla)objeto;
                                            comando.Parameters.AddWithValue("@idRol", pEntidadRolPantalla.mIdRol);
                                            comando.ExecuteNonQuery();
                                        }
                                        
                                    }
                                }
                            }
                            }
                        }
                        return true;
                   
                    
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
       }

        public SqlDataReader mSeleccionarGeneral(clsConexion cone, String sentencia)//string strSentencia, clsConexion cone, int id)
        {
            try
            {
                if (mConectar(cone))
                {
                    comando = new SqlCommand(sentencia, conexion);                 
                    return comando.ExecuteReader();
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        //Este metodo permitira ejecutar los Insert
        public Boolean mEjecutar(string strSentencia, clsConexion cone, Object objeto)
        {
            try
            {
                if (mConectar(cone))
                {
                    comando = new SqlCommand(strSentencia, conexion);
                    comando.CommandType = System.Data.CommandType.Text;

                    if (objeto is clsEntidadUsuario)
                    {
                        clsEntidadUsuario entidadUsuario = (clsEntidadUsuario)objeto;

                        comando.Parameters.AddWithValue("@idUsuario", entidadUsuario.mIdUsuario);
                        comando.Parameters.AddWithValue("@usuario", entidadUsuario.mUsuario);
                        comando.Parameters.AddWithValue("@contrasena", entidadUsuario.mContrasena);
                        comando.Parameters.AddWithValue("@nombre", entidadUsuario.mNombre);
                        comando.Parameters.AddWithValue("@tipoUsuario", entidadUsuario.mTipoUsuario);
                        comando.Parameters.AddWithValue("@apellidos", entidadUsuario.mApellidos);

                        comando.Parameters.AddWithValue("@estadoUsuario", entidadUsuario.mEstadoUsuario);
                        comando.Parameters.AddWithValue("@estadoContrasena", entidadUsuario.mEstadoContrasena);
                        comando.Parameters.AddWithValue("@creadoPor", entidadUsuario.mCreadoPor);
                        comando.Parameters.AddWithValue("@fechaCreacion", entidadUsuario.mFechaCreacion);
                        
                        comando.Parameters.AddWithValue("@modificadoPor", entidadUsuario.mModificadoPor);
                        comando.Parameters.AddWithValue("@fechaModificacion", entidadUsuario.mFechaModificacion);


                        comando.ExecuteNonQuery();
                        return true;
                    }
                    else
                    {
                        if (objeto is clsEntidadUsuarioRol)
                        {
                            clsEntidadUsuarioRol entidadUsuarioRol = (clsEntidadUsuarioRol)objeto;
                            comando.Parameters.AddWithValue("@idUsuario", entidadUsuarioRol.mIdUsuario);
                            comando.Parameters.AddWithValue("@idRol", entidadUsuarioRol.mIdRol);
                            comando.Parameters.AddWithValue("@creadoPor", entidadUsuarioRol.mCreadoPor);
                            comando.Parameters.AddWithValue("@fechaCreacion", entidadUsuarioRol.mFechaCreacion);
                            comando.Parameters.AddWithValue("@modificadoPor", entidadUsuarioRol.mModificadoPor);
                            comando.Parameters.AddWithValue("@fechaModificacion", entidadUsuarioRol.mFechaModificacion);
                            comando.ExecuteNonQuery();
                            return true;
                        }
                        else
                        {
                            if (objeto is clsEntidadUsuarioPantalla)
                            {
                                clsEntidadUsuarioPantalla entidadUsuarioPantalla = (clsEntidadUsuarioPantalla)objeto;
                                comando.Parameters.AddWithValue("@idUsuario", entidadUsuarioPantalla.mIdUsuario);
                                comando.Parameters.AddWithValue("@idPantalla", entidadUsuarioPantalla.mIdPantalla);
                                comando.Parameters.AddWithValue("@modificar", entidadUsuarioPantalla.mModificar);
                                comando.Parameters.AddWithValue("@insertar", entidadUsuarioPantalla.mInsertar);
                                comando.Parameters.AddWithValue("@consultar", entidadUsuarioPantalla.mConsultar);
                                comando.Parameters.AddWithValue("@eliminar", entidadUsuarioPantalla.mEliminar);

                                comando.Parameters.AddWithValue("@creadoPor", entidadUsuarioPantalla.mCreadoPor);
                                comando.Parameters.AddWithValue("@fechaCreacion", entidadUsuarioPantalla.mFechaCreacion);
                                comando.Parameters.AddWithValue("@modificadoPor", entidadUsuarioPantalla.mModificadoPor);
                                comando.Parameters.AddWithValue("@fechaModificacion", entidadUsuarioPantalla.mFechaModificacion);
                                
                                comando.ExecuteNonQuery();
                                return true;

                            }
                            //Agregar un Prestamo
                            else
                            {
                                if(objeto is clsEntidadPrestamo)
                                {
                                    clsEntidadPrestamo pEntidadPrestamo = (clsEntidadPrestamo)objeto;
                                    comando.Parameters.AddWithValue("@fecha", pEntidadPrestamo.setGetFecha);
                                    comando.Parameters.AddWithValue("@idUsuario", pEntidadPrestamo.setGetIdUsuario);
                                    comando.Parameters.AddWithValue("@idLibro", pEntidadPrestamo.setGetidLibro);
                                    comando.Parameters.AddWithValue("@idUsuarioCliente", pEntidadPrestamo.setGetIdUsuariocliente);
                                    comando.Parameters.AddWithValue("@creadoPor", pEntidadPrestamo.mCreadoPor);
                                    comando.Parameters.AddWithValue("@fechaCreacion", pEntidadPrestamo.mFechaCreacion);
                                    comando.Parameters.AddWithValue("@modificadoPor", pEntidadPrestamo.mModificadoPor);
                                    //comando.Parameters.AddWithValue("@fechaModificacion", pEntidadPrestamo.mFechaModificado);
                                    comando.ExecuteNonQuery();
                                    return true;

                                }
                                else if (objeto is clsEntidadLibro)
                                {
                                    clsEntidadLibro pEntidadLibro = (clsEntidadLibro)objeto;
                                    comando.Parameters.AddWithValue("@nombre", pEntidadLibro.getNombre());
                                    comando.Parameters.AddWithValue("@isbn", pEntidadLibro.getISBN());
                                    comando.Parameters.AddWithValue("@idLibro", pEntidadLibro.getIdLibro());
                                    comando.Parameters.AddWithValue("@creadoPor", pEntidadLibro.getCreadoPor());
                                    comando.Parameters.AddWithValue("@fechaCreacion", pEntidadLibro.getFechaCreacion());
                                    comando.Parameters.AddWithValue("@modificadoPor", pEntidadLibro.getModificadoPor());
                                    comando.Parameters.AddWithValue("@fechaModificacion", pEntidadLibro.getFechaModificacion());
                                    comando.ExecuteNonQuery();
                                    return true;

                                }else if (objeto is clsEntidadRol)
                                {
                                    clsEntidadRol pEntidadRol = (clsEntidadRol)objeto;
                                    comando.Parameters.AddWithValue("@nombre", pEntidadRol.mNombreRol);                                   
                                    comando.ExecuteNonQuery();
                                    return true;

                                } else if (objeto is clsEntidadRolPantalla)
                                {
                                    clsEntidadRolPantalla pEntidadRolPantalla = (clsEntidadRolPantalla)objeto;
                                    comando.Parameters.AddWithValue("@idRol", pEntidadRolPantalla.mIdRol);
                                    comando.Parameters.AddWithValue("@idPantalla", pEntidadRolPantalla.mIdPantalla);
                                    comando.Parameters.AddWithValue("@modificar", pEntidadRolPantalla.mModificar);
                                    comando.Parameters.AddWithValue("@insertar", pEntidadRolPantalla.mInsertar);
                                    comando.Parameters.AddWithValue("@consultar", pEntidadRolPantalla.mConsultar);
                                    comando.Parameters.AddWithValue("@eliminar", pEntidadRolPantalla.mEliminar);
                                    comando.Parameters.AddWithValue("@creadoPor", pEntidadRolPantalla.mCreadoPor);
                                    comando.Parameters.AddWithValue("@fechaCreacion", pEntidadRolPantalla.mFechaCreacion); 
                                    comando.Parameters.AddWithValue("@modificadoPor", pEntidadRolPantalla.mModificadoPor);
                                    comando.Parameters.AddWithValue("@fechaModificacion", pEntidadRolPantalla.mFechaModificacion);
                                    comando.ExecuteNonQuery();
                                    return true;

                                }
                                else if (objeto is clsEntidadBitacora)
                                {
                                    clsEntidadBitacora pEntidadBitacora = (clsEntidadBitacora)objeto;
                                    comando.Parameters.AddWithValue("@fecha", pEntidadBitacora.getFecha());
                                    comando.Parameters.AddWithValue("@hora", pEntidadBitacora.getHora());
                                    comando.Parameters.AddWithValue("@idUsuario", pEntidadBitacora.getIdUsuario());
                                    comando.ExecuteNonQuery();
                                    return true;

                                }
                            }
                        }
                    }
                }

               
                return false;
           
            }
            catch
            {
                return false;
            }
        }

        public Boolean mEjecutarModificar(String strSentencia, clsConexion cone, Object objeto)
        {
            try
            {
                if (mConectar(cone))
                {
                    comando = new SqlCommand(strSentencia, conexion);
                    comando.CommandType = System.Data.CommandType.Text;

                    if (objeto is clsEntidadUsuario)
                    {
                        clsEntidadUsuario entidadUsuario = (clsEntidadUsuario)objeto;

                        comando.Parameters.AddWithValue("@usuario", entidadUsuario.mUsuario);
                        comando.Parameters.AddWithValue("@contrasena", entidadUsuario.mContrasena);
                        comando.Parameters.AddWithValue("@estadoUsuario", entidadUsuario.mEstadoUsuario);
                        comando.Parameters.AddWithValue("estadoContrasena", true);
                        comando.ExecuteNonQuery();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }

        }
        //Este metodo nos permite abrir y conectarnos con la base de datos
        public Boolean mConectar(clsConexion cone)
        {
            try
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = "user id='" + cone.codigo + "'; password='" + cone.clave + "'; Data Source='" + mNomServidor() + "'; Initial Catalog='" + this.baseDatos + "'";
                conexion.Open();
                return true;

            }
            catch
            {
                return false;
            }
        }

        //Este metodo obtiene el nombre de la maquina de windows
        public string mNomServidor()
        {
            return Dns.GetHostName();
        }

        public SqlConnection mRetornarConexion(clsConexion cone)
        {
            if (mConectar(cone))
            {
                return conexion;
            }
            return null;
        }

        public void mEjecutarTransaction(string strSentencia, SqlConnection cone, Object objeto)
        {
            comando = new SqlCommand(strSentencia, cone);
            comando.CommandType = System.Data.CommandType.Text;
            if (objeto is clsEntidadRol)
            {
                clsEntidadRol entidadRol = (clsEntidadRol)objeto;
                comando.Parameters.AddWithValue("@nombre", entidadRol.mNombreRol);
            }
            else
            {
                if (objeto is clsEntidadRolPantalla)
                {                    
                    clsEntidadRolPantalla pEntidadRolPantalla = (clsEntidadRolPantalla)objeto;
                    comando.Parameters.AddWithValue("@idRol", pEntidadRolPantalla.mIdRol);
                    comando.Parameters.AddWithValue("@idPantalla", pEntidadRolPantalla.mIdPantalla);
                    comando.Parameters.AddWithValue("@modificar", pEntidadRolPantalla.mModificar);
                    comando.Parameters.AddWithValue("@insertar", pEntidadRolPantalla.mInsertar);
                    comando.Parameters.AddWithValue("@consultar", pEntidadRolPantalla.mConsultar);
                    comando.Parameters.AddWithValue("@eliminar", pEntidadRolPantalla.mEliminar);
                    comando.Parameters.AddWithValue("@creadoPor", pEntidadRolPantalla.mCreadoPor);
                    comando.Parameters.AddWithValue("@fechaCreacion", pEntidadRolPantalla.mFechaCreacion);
                    comando.Parameters.AddWithValue("@modificadoPor", pEntidadRolPantalla.mModificadoPor);
                    comando.Parameters.AddWithValue("@fechaModificacion", pEntidadRolPantalla.mFechaModificacion);
                }
            }                
            comando.ExecuteNonQuery();           
        }
        public string retornarSentenciaConeccion(clsConexion cone)
        {
            return "user id='" + cone.codigo+ "';password='" + cone.clave + "'; Data Source='" + mNomServidor() + "'; Initial Catalog='" + this.baseDatos + "'";
        }
        public SqlDataReader mSeleccionarScope(string strSentencia, SqlConnection cone, Object objeto)
        {
            comando = new SqlCommand(strSentencia, cone);
            comando.CommandType = System.Data.CommandType.Text;
                      
            if (objeto is clsEntidadRol)
            {
                clsEntidadRol pEntidadRol = (clsEntidadRol)objeto;
                comando.Parameters.AddWithValue("@nombre", pEntidadRol.mNombreRol);
            }
            if (objeto is clsEntidadPantalla)
            {
                clsEntidadPantalla pEntidadPantalla = (clsEntidadPantalla)objeto;
                comando.Parameters.AddWithValue("@nombre", pEntidadPantalla.mNombrePantalla);
            }
            return comando.ExecuteReader();
        }
        #endregion
    }
}
