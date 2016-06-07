using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsEntidadUsuario
    {
        #region atributos
        private int idUsuario;
        private string usuario;
        private string contrasena;
        #endregion

        #region Propiedades
        public int mIdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string mUsuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string mContrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        #endregion
    }
}
