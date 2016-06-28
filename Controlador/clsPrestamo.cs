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
            strSentencia = "insert into tbPestamo(fecha, idUsuario, idLibro, idUsuarioCliente, creadoPor, fechaCreacion, modificadoPor) values (@fecha, @idUsuario, @idLibro, @idUsuarioCliente, @creadoPor, @fechaCreacion, @modificadoPor) ";
            return conexion.mEjecutar(strSentencia, conexion, pEntidadPrestamo);
        }

        public Boolean mEliminarPrestamo(clsConexion conexion, clsEntidadPrestamo pEntidadPrestamo, string tipo)
        {
            strSentencia = "delete from tbPestamo where idLibro=@idLibro and idUsuarioCliente=@idUsuarioCliente";
            return conexion.mEjecutarElimModif(strSentencia, conexion, pEntidadPrestamo, tipo);
        }

        //Optener los roles del usuario conectado sobre la ventana de Libro
        public SqlDataReader mObtenerRolesUsuario(clsConexion conexion, String codigo, String contrasena)
        {
            strSentencia = "SELECT modificar,insertar,consultar,eliminar  from tbRolPantalla RP , tbRol R  ,tbPantalla P ,tbUsuarioRol  UR  , tbUsuario U  where U.idUsuario=UR.idUsuario and P.idPantalla=RP.idPantalla and R.idRol=UR.idRol and R.idRol=RP.idRol and U.idUsuario=@codigo and P.nombre=@contrasena";
            return conexion.mSeleccionarLogueo(strSentencia, codigo, contrasena);
        }
        public SqlDataReader mObtenerPrivilegiosDirectos(clsConexion conexion, String codigo, String contrasena)
        {
            strSentencia = "SELECT modificar,insertar,consultar,eliminar  from tbUsuarioPantalla UP , tbPantalla P where UP.idUsuario=@codigo and UP.idPantalla=P.idPantalla and P.nombre=@contrasena";
            return conexion.mSeleccionarLogueo(strSentencia, codigo, contrasena);
        }
        public SqlDataReader mSeleccionarIdUsuario(clsConexion conexion, String usuario)
        {
            strSentencia = "SELECT idUsuario from tbUsuario where usuario=@codigo";
            return conexion.mSeleccionarTipoString(strSentencia, usuario);
        }
    }
}
