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
        private DateTime hora;
        private String tabla;
        private String descripcion;
        private int idUsuario;
        #endregion

        #region Constructor
        public clsEntidadBitacora()
        {
            this.idBitacora = 0;
            //this.fecha = 1998 - 01 - 02 00:00:00.000;
            //this.hora = ;
            this.tabla = "";
            this.descripcion = "";
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

        public void setHora(DateTime hora)
        {
            this.hora = hora;
        }

        public void setTabla(String tabla)
        {
            this.tabla = tabla;
        }
        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
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

        public DateTime getHora()
        {
            return hora;
        }

        public String getTabla()
        {
            return tabla;
        }
        public String getDescripcion()
        {
            return descripcion;
        }
        public int getIdUsuario()
        {
            return idUsuario;
        }



       

        #endregion
    }
}
