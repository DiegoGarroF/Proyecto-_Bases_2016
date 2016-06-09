using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;


namespace Modelo
{
    class clsEntidadBitacora
    {
        #region Atributos

        private int idBitacora;
        private String fecha;
        private String hora;
        private String tabla;
        private String descripcion;
        private int idUsuario;
        #endregion

        #region Constructor
        public clsEntidadBitacora()
        {
            this.idBitacora = 0;
            this.fecha ="";
            this.hora ="";
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

        public void setFecha(String fecha)
        {
            this.fecha = fecha;
        }

        public void setHora(String hora)
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

        public String getFecha()
        {
            return fecha;
        }

        public String getHora()
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
}
