using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;


namespace Controlador
{
   public class clsRol
    {
        private string sentencia = "";

        public SqlDataReader mConsultaRolesUsuario(clsConexion conexion, clsEntidadUsuario pEntidadUsuario)
        {
            sentencia = "select r.nombre, r.idRol from tbRol r, tbUsuarioRol ur, tbUsuario u where r.idRol=ur.idRol and u.idUsuario=ur.idUsuario and u.idUsuario=@codigo";
            return conexion.mSeleccionar(sentencia, pEntidadUsuario.mIdUsuario);
        }

        public void mInsertarRol(clsConexion conexion, clsEntidadRol pEntidadRol)
        {
            using (SqlConnection connection = new SqlConnection(conexion.retornarSentenciaConeccion(conexion)))
            {
                sentencia = "insert into tbRol(nombre) values (@nombre)";
                connection.Open();
                conexion.mEjecutarTransaction(sentencia, connection, pEntidadRol);
            }
                
            //return conexion.mEjecutar(sentencia, conexion, pEntidadRol);
        }
        public SqlDataReader mConsultaIdRolScope(clsConexion conexion, clsEntidadRol pEntidadRol, SqlConnection connection)
        {
                sentencia = "select idRol from tbRol where  nombre=@nombre";
                return conexion.mSeleccionarScope(sentencia, connection, pEntidadRol);    
        }

        
        public SqlDataReader mConsultaIdRoles(clsConexion conexion, clsEntidadRol pEntidadRol)
        {
            sentencia = "select idRol from tbRol where  nombre=@codigo";
            return conexion.mSeleccionarTipoString(sentencia, pEntidadRol.mNombreRol);
        }

        public SqlDataReader mConsultarRoles(clsConexion conexion)
        {
            sentencia = "select nombre from tbRol";
            return conexion.mSeleccionarGeneral(conexion, sentencia);
        }
        public SqlDataReader mConsultarRolesPriv(clsConexion conexion, clsEntidadRol pEntidadRol)
        {
            sentencia = "select r.nombre,p.nombre, rp.insertar,rp.consultar,rp.modificar, rp.eliminar from tbRol r, tbRolPantalla rp, tbPantalla p where r.idRol = rp.idRol and rp.idPantalla = p.idPantalla and r.nombre = @codigo";
            return conexion.mSeleccionarTipoString(sentencia, pEntidadRol.mNombreRol);
        }

        public Boolean mEliminarRol(clsConexion conexion, clsEntidadRol pEntidadRol)
        {
            sentencia = "delete from tbRol where nombre=@nombre";
            return conexion.mEjecutarElimModif(sentencia,conexion, pEntidadRol,"");
        }
    }
}
