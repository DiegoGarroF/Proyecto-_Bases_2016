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

        public SqlDataReader mPrivilegiosRol(clsConexion conexion, clsEntidadRolPantalla pEntidadRolPantalla)
        {
            sentencia = "select idRol, idPantalla, modificar, insertar, consultar, eliminar from tbRolPantalla where idRol=@codigo";
            return conexion.mSeleccionar(sentencia,pEntidadRolPantalla.mIdRol);
        }
    }
}
