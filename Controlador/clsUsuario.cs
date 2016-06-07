using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Controlador
{
    public class clsUsuario
    {
        private string sentencia = "";
        private SqlCommand comando;

        public SqlDataReader mBuscarUsuario(clsConexion conexion,clsEntidadUsuario pEntidadUsuario)
        {
            sentencia = "select idUsuario, usuario, contrasena from tbUsuario where idUsuario=@id";

            comando = new SqlCommand(sentencia, conexion.mRetornarConexion(conexion));
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@id", pEntidadUsuario.mIdUsuario);
            return conexion.mSeleccionar(comando);
        }

        public SqlDataReader mConsultaGeneral(clsConexion conexion)
        {
            sentencia = "select idUsuario, usuario, contrasena from tbUsuario";
            comando = new SqlCommand(sentencia, conexion.mRetornarConexion(conexion));
            comando.CommandType = System.Data.CommandType.Text;
            return conexion.mSeleccionar(comando);
        }
    }
}
