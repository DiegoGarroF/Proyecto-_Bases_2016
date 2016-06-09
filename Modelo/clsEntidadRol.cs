using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class clsEntidadRol
    {
        private int idRol;
        private string nombreRol;

        public int mIdRol
        {
            get { return idRol; }
            set { idRol = value; }
        }

        public string mNombreRol
        {
            get { return nombreRol; }
            set { nombreRol = value; }
        }
    }
}
