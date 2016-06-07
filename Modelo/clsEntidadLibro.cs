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
        #endregion
    }
}
