using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsEntidadPantalla
    {
        private int idPantalla;
        private string nombrePantalla;

        public int mIdPantalla
        {
            get { return idPantalla; }
            set { idPantalla = value; }
        }

        public string mNombreRol
        {
            get { return nombrePantalla; }
            set { nombrePantalla = value; }
        }
    }
}
