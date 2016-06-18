using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Controlador
{
   public class clsUsuarioRol
    {
        private string sentencia = "";

        public Boolean mInsertarUsuarioRol(clsConexion conexion, clsEntidadUsuarioRol pEntidadUsuarioRol)
        {
            sentencia = "insert into tbUsuarioRol(idUsuario, idRol, creadoPor, fechaCreacion) values (@idUsuario, @idRol, @creadoPor, @fechaCreacion) ";
            return conexion.mEjecutar(sentencia, conexion, pEntidadUsuarioRol);
        }

        public Boolean mEliminarRolesUsuario(clsConexion conexion, clsEntidadUsuarioRol pEntidadUsuarioRol, string tipo)
        {
            sentencia = "delete from tbUsuarioRol where idUsuario=@idUsuario";
            return conexion.mEjecutarElimModif(sentencia, conexion, pEntidadUsuarioRol,tipo);
        }
    }
}
