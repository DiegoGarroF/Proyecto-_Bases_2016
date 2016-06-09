using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class clsEntidadUsuarioRol
    {
        private int idUsuario;
        private int idRol;

        public int mIdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public int mIdRol
        {
            get { return idRol; }
            set { idRol = value; }
        }

    }
}
