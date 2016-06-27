using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
namespace Controlador
{
    public class clsLibro
    {
      
        private string strSentencia;
        private SqlCommand comando;
        public clsLibro()
        {
         
        }

        public Boolean mInsertarLibro(clsConexion conexion, clsEntidadLibro pEntidadLibro)
        {
            strSentencia = "INSERT INTO tbLibro(nombre,isbn,creadoPor, fechaCreacion) VALUES(@nombre , @isbn , @creadoPor ,@fechaCreacion)";

            return conexion.mEjecutar(strSentencia, conexion,pEntidadLibro);
        }


        public SqlDataReader mSeleccionarLibroID(clsConexion conexion, clsEntidadLibro pEntidadLibro)
        {
            strSentencia = "SELECT * FROM tbLibro where idLibro=@codigo";
            return conexion.mSeleccionarTipoString(strSentencia,""+pEntidadLibro.getIdLibro());
        }
        public SqlDataReader mSeleccionarLibroISBN(clsConexion conexion, clsEntidadLibro pEntidadLibro)
        {
            strSentencia = "SELECT * FROM tbLibro where isbn=@codigo";
            return conexion.mSeleccionarTipoString(strSentencia, pEntidadLibro.getISBN());
        }
        public SqlDataReader mSeleccionarTodos(clsConexion conexion)
        {
            strSentencia ="SELECT * FROM tbLibro";
            return conexion.mSeleccionarGeneral(conexion,strSentencia);
        }
        public Boolean mModificarLibro(clsConexion conexion, clsEntidadLibro pEntidadLibro)
        {
            strSentencia = "update tbLibro set modificadoPor=@modificadoPor , fechaModificacion=@fechaModificacion, nombre=@nombre, isbn=@isbn where idLibro=@idLibro ; ";
            return conexion.mEjecutar(strSentencia, conexion,pEntidadLibro);
        }
        public Boolean mEliminarLibro(clsConexion conexion, clsEntidadLibro pEntidadLibro)
        {
            strSentencia = "DELETE FROM tbLibro where idLibro=@idLibro ;";
            return conexion.mEjecutar(strSentencia, conexion,pEntidadLibro);
        }

        public SqlDataReader mSeleccionarRolPantalla(clsConexion conexion, String nombre)
        {
            strSentencia = "SELECT rP.idPantalla,rP.consultar,rP.eliminar,rP.insertar,rP.modificar FROM tbRolPantalla rP, tbPantalla p where p.idPantalla = rP.idPantalla and p.nombre =@codigo";
            return conexion.mSeleccionarTipoString(strSentencia, nombre);
        }
        public SqlDataReader mSeleccionarIdUsuario(clsConexion conexion, String usuario)
        {
            strSentencia = "SELECT idUsuario from tbUsuario where usuario=@codigo";
            return conexion.mSeleccionarTipoString(strSentencia, usuario);
        }
        public SqlDataReader mObtenerRolesUsuario(clsConexion conexion, String codigo,String contrasena)
        {
            strSentencia = "SELECT modificar,insertar,consultar,eliminar from tbRolPantalla RP , tbRol R  ,tbPantalla P ,tbUsuarioRol  UR  , tbUsuario U  where U.idUsuario=UR.idUsuario and P.idPantalla=RP.idPantalla and R.idRol=UR.idRol and R.idRol=RP.idRol and U.idUsuario=@codigo and P.nombre=@contrasena";
            return conexion.mSeleccionarLogueo(strSentencia, codigo, contrasena);
        }
    }
}
