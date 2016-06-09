using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsConstantes
    {
        public const string ELIMINAR  = "Eliminar";
        public const string CONSULTAR = "Consultar";
        public const string MODIFICAR = "Modificar";
        public const string AGREGAR   = "Agregar";

        // Estas variables definiran el tipo de mensaje a mostrar 
        public const int TIPO_GENERAL = 0;
        public const int TIPO_AGREGAR   = 1;
        public const int TIPO_ELIMINAR = 2;
        public const int TIPO_MODIFICAR = 3;
        public const int TIPO_BUSCAR    = 4;


        // Mensajes para la ventana FRM_LIBRO
        public const string TIPO_LIBRO = "LIBRO";
        public const string ELIMINAR_LIBRO  = "Libro Eliminado Correctamente";
        public const string CONSULTAR_LIBRO = "NO Se Encontro El Libro Solicitado";
        public const string MODIFICAR_LIBRO = "Libro Modificado Correctamente";
        public const string AGREGAR_LIBRO   = "Libro Agregado Correctamente";

        public const string COMPLETE_NOMBRE= "Debe de Ingresar Un Nombre";
        public const string COMPLETE_ISBN  = "Debe de Ingresar Un ISBN";

    }    

}
