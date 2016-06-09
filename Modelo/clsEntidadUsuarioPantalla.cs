using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsEntidadUsuarioPantalla
    {
        #region atributos
        private int idUsuario;
        private int idPantalla;

        private Boolean modificar;
        private Boolean insertar;
        private Boolean consultar;
        private Boolean eliminar;
        #endregion

        #region metodos
        public int mIdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public int mIdPantalla
        {
            get { return idPantalla; }
            set { idPantalla = value; }
        }

        public Boolean mModificar
        {
            get { return modificar; }
            set { modificar = value; }
        }
        public Boolean mInsertar
        {
            get { return insertar; }
            set { insertar = value; }
        }

        public Boolean mConsultar
        {
            get { return consultar; }
            set { consultar = value; }
        }
        public Boolean mEliminar
        {
            get { return eliminar; }
            set { eliminar = value; }
        }
        #endregion
    }
}
