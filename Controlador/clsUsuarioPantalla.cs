using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Controlador
{
   public  class clsUsuarioPantalla
    {
        private string sentencia = "";

        public Boolean mInsertarUsuarioPantalla(clsConexion conexion, clsEntidadUsuarioPantalla pEntidadUsuarioPantalla)
        {
            sentencia = "insert into tbUsuarioPantalla(idUsuario, idPantalla, modificar,insertar, consultar, eliminar, creadoPor, fechaCreacion) values (@idUsuario, @idPantalla, @modificar, @insertar, @consultar, @eliminar, @creadoPor, @fechaCreacion) ";
            return conexion.mEjecutar(sentencia, conexion, pEntidadUsuarioPantalla);
        }

        public Boolean mEliminarPantallasUsuario(clsConexion conexion, clsEntidadUsuarioPantalla pEntidadUsuarioPantalla, string tipo)
        {
            sentencia = "delete from tbUsuarioPantalla where idUsuario=@idUsuario";
            return conexion.mEjecutarElimModif(sentencia, conexion, pEntidadUsuarioPantalla, tipo);
        }
    }
}
