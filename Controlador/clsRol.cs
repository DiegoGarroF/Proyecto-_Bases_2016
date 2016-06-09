using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Controlador
{
   public class clsRol
    {
        private string sentencia = "";

        public SqlDataReader mConsultaRolesUsuario(clsConexion conexion)
        {
            sentencia = "select r.nombre from tbRol r, tbUsuarioRol ur, tbUsuario u where r.idRol=ur.idRol and u.idUsuario=ur.idUsuario";
            return conexion.mSeleccionarGeneral(conexion, sentencia);
        }
    }
}
