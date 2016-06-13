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

        public Boolean mTrigger(clsConexion conexion, clsEntidadUsuario pEntidadUsuario)
        {
            sentencia = " IF OBJECT_ID ('CONTROL_BITACORA') IS NOT NULL BEGIN DROP TRIGGER CONTROL_BITACORA;  END; CREATE TRIGGER CONTROL_BITACORA ON tbUsuario FOR INSERT AS BEGIN DECLARE @FECHA DATE, @HORA TIME(7), @TABLA NVARCHAR(50), @DESCRIPCION NVARCHAR(50), @IDUSUARIO INT;    SET @FECHA = (SELECT FECHA FROM DELETED); SET  @HORA = (SELECT HORA FROM DELETED); SET @DESCRIPCION = (SELECT DESCRIPCION FROM DELETED); SET @IDUSUARIO = (SELECT @IDUSUARIO FROM DELETED))  INSERT INTO BITACORA VALUES (@FECHA, HORA, @DESCRIPCION, @IDUSUARIO) END; ";
            return conexion.mEjecutar(sentencia, conexion, pEntidadUsuario);
        }

        public SqlDataReader mConsultaGeneral(clsConexion conexion)
        {
            sentencia = "select fecha, hora, descripcion,tabla,idUsuario from tbBitacora";
            return conexion.mSeleccionarGeneral(conexion, sentencia);
        }

    }
}
