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

        public SqlDataReader mConsultaPrivPantaUsuario(clsConexion conexion)
        {
            sentencia = "select p.nombre,up.insertar,up.consultar,up.modificar,up.eliminar from tbPantalla p, tbUsuario u, tbUsuarioPantalla up where u.idUsuario = up.idUsuario and p.idPantalla = up.idPantalla";
            return conexion.mSeleccionarGeneral(conexion, sentencia);
        }
    }
}
