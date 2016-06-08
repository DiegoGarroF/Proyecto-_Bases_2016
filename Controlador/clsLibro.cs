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
            strSentencia = "INSERT INTO tbLibro(nombre,isbn) VALUES("+pEntidadLibro.getNombre()+"' , '"+pEntidadLibro.getISBN()+"')";
            return conexion.mEjecutar(strSentencia, conexion);
        }


        public SqlDataReader mSeleccionar(clsConexion conexion, clsEntidadLibro pEntidadLibro)
        {
            strSentencia = "SELECT * FROM tbLibro where idLibro=@"+pEntidadLibro.getIdLibro()+" ;";
            return conexion.mSeleccionar(strSentencia,pEntidadLibro.getIdLibro());
        }
        public SqlDataReader mSeleccionarTodos(clsConexion conexion)
        {
            strSentencia ="SELECT * FROM tbLibro";
            return conexion.mSeleccionarGeneral(strSentencia);
        }
        public Boolean mModificarLibro(clsConexion conexion, clsEntidadLibro pEntidadLibro)
        {
             strSentencia = "UPDATE tbLibro set ";
            return conexion.mEjecutar(strSentencia, conexion);
        }
        public Boolean mEliminarLibro(clsConexion conexion, clsEntidadLibro pEntidadLibro)
        {
            strSentencia = "DELETE FROM tbLibro where idLibro="+pEntidadLibro.getIdLibro()+" ;";
            return conexion.mEjecutar(strSentencia, conexion);
        }
    }
}
