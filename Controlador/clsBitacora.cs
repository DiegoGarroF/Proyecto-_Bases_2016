using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
  public class clsBitacora
    {
        private string sentencia = "";

        public Boolean mTrigger(clsConexion conexion, clsEntidadUsuario pEntidadUsuario)
        {
           // sentencia = "create trigger bitacora before insert on tbBitacora  ";
            return conexion.mEjecutar(sentencia, conexion, pEntidadUsuario);
        }

    }
}
