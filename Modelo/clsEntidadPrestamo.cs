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
        private DateTime fecha;
        private int idUsuario;
        private int idLibro;
        private int idUsuarioCliente;
        private int idPrestamo;
        #endregion

        #region Constructor
        public clsEntidadPrestamo()
        {
            idUsuario = 0;
            idLibro = 0;
            idUsuarioCliente = 0;
            idPrestamo = 0;
        }
        #endregion

        #region Set y get

        public int setGetIdPrestamo
        {
            get { return idPrestamo; }
            set { idPrestamo = value; }
        }
        public DateTime setGetFecha 
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
