using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;

namespace Controlador
{
    public class clsPantalla
    {
        private string sentencia = "";


        public SqlDataReader mConsultaPrivPantaUsuario(clsConexion conexion, clsEntidadUsuario pEntidadUsuario)
        {
            sentencia = "select p.nombre,up.insertar,up.consultar,up.modificar,up.eliminar from tbPantalla p, tbUsuario u, tbUsuarioPantalla up where u.idUsuario = up.idUsuario and p.idPantalla = up.idPantalla and up.idUsuario=@codigo";
            return conexion.mSeleccionar(sentencia, pEntidadUsuario.mIdUsuario);
        }

        public SqlDataReader mConsultarPantallas(clsConexion conexion)
        {
            sentencia = "select nombre from tbPantalla";
            return conexion.mSeleccionarGeneral(conexion, sentencia);
        }

        public SqlDataReader mConsultaIdPantalla(clsConexion conexion, clsEntidadPantalla pEntidadPantalla)
        {
            sentencia = "select idPantalla from tbPantalla where  nombre=@codigo";
            return conexion.mSeleccionarTipoString(sentencia, pEntidadPantalla.mNombrePantalla);
        }

        

    }
}
