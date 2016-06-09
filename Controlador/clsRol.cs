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

        public SqlDataReader mConsultaRolesUsuario(clsConexion conexion, clsEntidadUsuario pEntidadUsuario)
        {
            sentencia = "select r.nombre from tbRol r, tbUsuarioRol ur, tbUsuario u where r.idRol=ur.idRol and u.idUsuario=ur.idUsuario and u.idUsuario=@codigo";
            return conexion.mSeleccionar(sentencia, pEntidadUsuario.mIdUsuario);
        }

        public Boolean mInsertarRol(clsConexion conexion, clsEntidadRol pEntidadRol)
        {
            sentencia = "insert into tbRol(nombre) values (@nombre)";
            return conexion.mEjecutar(sentencia, conexion, pEntidadRol);
        }

        public SqlDataReader mConsultaIdRoles(clsConexion conexion, clsEntidadRol pEntidadRol)
        {
            sentencia = "select idRol from tbRol where  nombre=@codigo";
            return conexion.mSeleccionarTipoString(sentencia, pEntidadRol.mNombreRol);
        }
    }
}
