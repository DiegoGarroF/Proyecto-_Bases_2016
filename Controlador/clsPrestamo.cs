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
        public SqlDataReader mConsultaGeneral(clsConexion conexion)
        {
            strSentencia= "select * from tbPestamo";
            return conexion.mSeleccionarGeneral(conexion, strSentencia);
        }


       

        //Consultas individuales
        public SqlDataReader mConsultarPrestamo(clsConexion conexion, clsEntidadPrestamo pEntidadPrestamo)
        {
            strSentencia = "select * from tbPestamo where idPrestamo=@codigo";
            return conexion.mSeleccionar(strSentencia, pEntidadPrestamo.setGetIdPrestamo);
        }
        public Boolean mInsertarPrestamo(clsConexion conexion, clsEntidadPrestamo pEntidadPrestamo)
        {
            strSentencia = "insert into tbPestamo(fecha, idUsuario, idLibro, idUsuarioCliente) values (@fecha, @idUsuario, @idLibro, @idUsuarioCliente) ";
            return conexion.mEjecutar(strSentencia, conexion, pEntidadPrestamo);
        }

        public Boolean mEliminarPrestamo(clsConexion conexion, clsEntidadPrestamo pEntidadPrestamo, string tipo)
        {
            strSentencia = "delete from tbPestamo where idLibro=@idLibro and idUsuarioCliente=@idUsuarioCliente";
            return conexion.mEjecutarElimModif(strSentencia, conexion, pEntidadPrestamo, tipo);
        }
        
    }
}
