using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsEntidadLibro
    {
        #region Atributos

        private int idLibro;
        private String nombre;
        private String ISBN;
        private String autor;
        private string creadoPor;
        private string fechaCreacion;
        private string modificadoPor;
        private string fechaModificacion;
        #endregion

        #region Constructor
        public clsEntidadLibro()
        {
            this.idLibro = 0;
            this.nombre = "";
            this.ISBN = "";
            this.autor = "";
        }
        #endregion

        //Metodos Set para los atributos
        #region Metodos Set
        public void setIdLibro(int idLibro)
        {
            this.idLibro = idLibro;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setISBN(String ISBN)
        {
            this.ISBN = ISBN;
        }

        public void setAutor(String autor)
        {
            this.autor = autor;
        }
        public void setCreadoPor(String creadoPor)
        {
            this.creadoPor = creadoPor;
        }
        public void setFechaCreacion(String fechaCreacion)
        {
            this.fechaCreacion = fechaCreacion;
        }
        public void setModificadoPor(String modificadoPor)
        {
            this.modificadoPor = modificadoPor;
        }
        public void setFechaModificacion(String fechaModificacion)
        {
            this.fechaModificacion = fechaModificacion;
        }
        #endregion
        //Metodos Get para los atributos
        #region Metodos Get
        public int getIdLibro()
        {
            return idLibro;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getISBN()
        {
            return ISBN;
        }

        public String getAutor()
        {
            return autor;
        }

        public String getCreadoPor()
        {
            return creadoPor;
        }
        public String getFechaCreacion()
        {
            return fechaCreacion;
        }

        public String getModificadoPor()
        {
            return modificadoPor;
        }
        public String getFechaModificacion()
        {
            return fechaModificacion;
        }
        #endregion




       
    }
}
