using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class clsEntidadTrabajador
    {
        #region Atributos
        private int idTrabajador;
        private string nombreTrabajador;
        private string apellidosTrabajdor;
        private string cedula;
        private string telefono;
        #endregion

        #region Set y get

        public int setGetIdTrabajador
        {
            get { return idTrabajador; }
            set { idTrabajador = value; }
        }

        public string setGetNombreTrabajador
        {
            get { return nombreTrabajador; }
            set { nombreTrabajador = value; }
        }

        public string setGetApellidoTrabajador
        {
            get { return apellidosTrabajdor; }
            set { apellidosTrabajdor = value; }
        }

        public string setGetCedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string setGetTelefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        #endregion


    }
}
