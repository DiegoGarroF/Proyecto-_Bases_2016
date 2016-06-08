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
            sentencia = "select idUsuario, usuario, contrasena from tbUsuario where idUsuario=@codigo";

           
            return conexion.mSeleccionar(sentencia,pEntidadUsuario.mIdUsuario);
        }

        public SqlDataReader mConsultaGeneral(clsConexion conexion)
        {
            sentencia = "select idUsuario, usuario, contrasena from tbUsuario";           
            return conexion.mSeleccionarGeneral(sentencia);
        }
    }
}
