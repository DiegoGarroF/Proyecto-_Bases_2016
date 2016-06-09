using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsEntidadPrestamo
    {
        #region Atributos
        private string fecha;
        private int idUsuario;
        private int idLibro;
        private int idUsuarioCliente;
        #endregion

        #region Set y get

        public string setGetFecha 
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int setGetIdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public int setGetidLibro
        {
            get { return idLibro; }
            set { idLibro = value; }
        }

        public int setGetIdUsuariocliente
        {
            get { return idUsuarioCliente; }
            set { idUsuarioCliente = value; }
        }


        #endregion

    }
}
