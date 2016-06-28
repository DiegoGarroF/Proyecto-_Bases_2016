using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Controlador
{
    public class clsRolPantalla
    {
        private string sentencia = "";

        public void mInsertarRolPantalla(clsConexion conexion, clsEntidadRolPantalla pEntidadRolPantalla, SqlConnection connection)
        {
                sentencia = "insert into tbRolPantalla(idRol, idPantalla, modificar, insertar, consultar, eliminar, creadoPor, fechaCreacion, modificadoPor, fechaModificacion) values (@idRol,@idPantalla,@modificar,@insertar,@consultar,@eliminar,@creadoPor,@fechaCreacion,@modificadoPor,@fechaModificacion)";
                conexion.mEjecutarTransaction(sentencia, connection, pEntidadRolPantalla);       
        }
    }
}
