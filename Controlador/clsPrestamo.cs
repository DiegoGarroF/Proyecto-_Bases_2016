using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Controlador
{
    public class clsPrestamo
    {
        private string strSentencia;

        public Boolean mInsertarCliente( clsEntidadPrestamo pEntidadPrestamo)
        {
            strSentencia = "insert into prestamo(fechaInicio,fechaFin, nombreEstudiante, carnet) values('"+ pEntidadPrestamo.setGetFecha +"')";
            return false;
        }


        public SqlDataReader mConsultaGeneralCliente(clsConexion conexion)
        {
            strSentencia = "select * from tbUsuario where tipoUsuario='Estudiante'";
            return conexion.mSeleccionarGeneral(conexion, strSentencia);
        }

    }
}
