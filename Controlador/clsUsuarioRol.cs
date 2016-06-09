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
            sentencia = "insert into tbUsuarioRol(idUsuario, idRol) values (@idUsuario, @idRol) ";
            return conexion.mEjecutar(sentencia, conexion, pEntidadUsuarioRol);
        }
    }
}
