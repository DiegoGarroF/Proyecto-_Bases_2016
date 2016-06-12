using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Controlador
{
    public class clsUsuario
    {
        private string sentencia = "";        

        public SqlDataReader mBuscarUsuario(clsConexion conexion,clsEntidadUsuario pEntidadUsuario)
        {
            sentencia = "select idUsuario, usuario, contrasena, nombre, apellidos, tipoUsuario from tbUsuario where idUsuario=@codigo";

           
            return conexion.mSeleccionar(sentencia,pEntidadUsuario.mIdUsuario);
        }

        public SqlDataReader mConsultaGeneral(clsConexion conexion)
        {
            sentencia = "select idUsuario, usuario, contrasena from tbUsuario";           
            return conexion.mSeleccionarGeneral(conexion,sentencia);
        }

        //Creo que este método no va en esta clase
        public SqlDataReader mConsultarListaBitacora(clsConexion conexion)
        {
            sentencia = "select nombre, apellidos, tipoUsuario from tbUsuario";
            return conexion.mSeleccionarGeneral(conexion, sentencia);
        }

        public Boolean mInsertarUsuario(clsConexion conexion, clsEntidadUsuario pEntidadUsuario)
        {
            sentencia = "insert into tbUsuario(usuario, contrasena, nombre, tipoUsuario, apellidos) values (@usuario, @contrasena, @nombre, @tipoUsuario, @apellidos) ";
            return conexion.mEjecutar(sentencia,conexion, pEntidadUsuario); 
        }

        public SqlDataReader mConsultaIdUsuario(clsConexion conexion, clsEntidadUsuario pEntidadUsuario)
        {
            sentencia = "select idUsuario from tbUsuario where  usuario=@codigo";
            return conexion.mSeleccionarTipoString(sentencia, pEntidadUsuario.mUsuario);
        }

        public Boolean mEliminarUsuario(clsConexion conexion, clsEntidadUsuario pEntidadUsuario, string tipo)
        {
            sentencia = "delete from tbUsuario where idUsuario=@idUsuario";
            return conexion.mEjecutarElimModif(sentencia, conexion, pEntidadUsuario, tipo);
        }
    }
}
