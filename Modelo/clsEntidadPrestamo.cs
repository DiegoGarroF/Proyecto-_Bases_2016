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
        private string fechaInicio;
        private string fechaFin;
        private string nombreEstudiante;
        private string carnet;
        #endregion

        #region Set y get

        public string setGetFechaInicio 
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public string setGetFechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public string setGetNombreEstudiante
        {
            get { return nombreEstudiante; }
            set { nombreEstudiante = value; }
        }

        public string setGetCarnet
        {
            get { return carnet; }
            set { carnet = value; }
        }


        #endregion

    }
}
