using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
namespace Controlador
{
  public class clsBitacora
    {
        private string sentencia = "";


        public Boolean mInsertarBitacora(clsConexion conexion,clsEntidadBitacora pEntidadBitacora)
        {
            sentencia = "insert into tbBitacora(fecha,hora,idUsuario) VALUES(@fecha,@hora,@idUsuario)";

            return conexion.mEjecutar(sentencia, conexion, pEntidadBitacora);
        }


        public SqlDataReader mConsultaGeneral(clsConexion conexion )
        {
            sentencia = "select fecha, hora,idUsuario from tbBitacora";
            return conexion.mSeleccionarGeneral(conexion, sentencia);
        }
        public SqlDataReader mHoraServidor(clsConexion conexion)
        {
            sentencia = "SELECT Convert(varchar(5),GetDate(), 108)";
            return conexion.mSeleccionarGeneral(conexion, sentencia);
        }
        public SqlDataReader mConsultaEspecifica(clsConexion conexion, clsEntidadBitacora pEntidadBitacora)
        {
            sentencia = "select fecha, hora,idUsuario from tbBitacora where idUsuario=@codigo";
            return conexion.mSeleccionar(sentencia, pEntidadBitacora.getIdUsuario());
        }
    }
}
