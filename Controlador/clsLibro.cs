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
            return conexion.mSeleccionar(strSentencia, conexion);
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
