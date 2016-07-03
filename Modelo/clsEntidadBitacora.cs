using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Globalization;


namespace Modelo
{
    public class clsEntidadBitacora
    {
        #region Atributos

        private int idBitacora;
        private DateTime fecha;
        private string hora;
        private int idUsuario;
        #endregion

        #region Constructor
        public clsEntidadBitacora()
        {
            this.idBitacora = 0;
            //this.fecha ="";
            //this.hora = "";
            this.idUsuario = 0;
        }
        #endregion



        //Metodos Set para los atributos
        #region Metodos Set
        public void setIdBitacora(int idBitacora)
        {
            this.idBitacora = idBitacora;
        }

        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public void setHora(string hora)
        {
            this.hora = hora;
        }


        public void setIdiUsuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }


        #endregion
        //Metodos Get para los atributos
        #region Metodos Get
        public int getIdBitacora()
        {
            return idBitacora;
        }

        public DateTime getFecha()
        {
            return fecha;
        }

        public string getHora()
        {
            return hora;
        }
       
        public int getIdUsuario()
        {
            return idUsuario;
        }       
        #endregion
    }
}
