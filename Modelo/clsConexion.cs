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
        public SqlDataReader mSeleccionar(String sentencia, int codigo)//string strSentencia, clsConexion cone, int id)
        {
            try
            {
                if (conexion!=null)
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

        public SqlDataReader mSeleccionarGeneral(String sentencia)//string strSentencia, clsConexion cone, int id)
        {
            try
            {
                if (conexion != null)
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

        //Este metodo permitira ejecutar los Insert, Update y Delete
        public Boolean mEjecutar(string strSentencia, clsConexion cone)
        {
            try
            {

                comando = new SqlCommand(strSentencia, this.conexion);
                comando.ExecuteNonQuery();
                return true;
           
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
                conexion.ConnectionString = "user id='" + cone.codigo + "'; password='" + cone.clave + "'; Data Source='" + mNomServidor() + "'; Initial Catalog='" + cone.baseDatos + "'";
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
        #endregion
    }
}
