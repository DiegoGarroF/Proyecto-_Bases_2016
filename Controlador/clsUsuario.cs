using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class clsUsuario
    {
        private string sentencia = "";


        public void mBuscarUsuario(clsConexion conexion,clsEntidadUsuario pEntidadUsuario)
        {
            sentencia = "select idUsuario, usuario, contrasena from tbUsuario where idUsuario=?";
        }
    }
}
