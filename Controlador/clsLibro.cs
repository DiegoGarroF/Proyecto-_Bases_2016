using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
namespace Controlador
{
    public class clsLibro
    {
      
        private string strSentencia;
        private SqlCommand comando;
        public clsLibro()
        {
         
        }

        public Boolean mInsertarLibro(clsConexion conexion, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "";
            return conexion.mEjecutar(strSentencia, conexion);
        }


        public SqlDataReader mSeleccionar(clsConexion conexion, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "";
            comando = new SqlCommand(strSentencia, conexion.mRetornarConexion(conexion));
            comando.CommandType = System.Data.CommandType.Text;
            return conexion.mSeleccionar(comando);
        }
        public Boolean mModificarLibro(clsConexion conexion, clsEntidadUsuario pEntidadUsuario)
        {
             strSentencia = "";
            return conexion.mEjecutar(strSentencia, conexion);
        }
        public Boolean mEliminarLibro(clsConexion conexion, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "";
            return conexion.mEjecutar(strSentencia, conexion);
        }
    }
}
