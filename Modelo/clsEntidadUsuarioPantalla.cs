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

        private string creadoPor;
        private string fechaCreacion;
        private string modificadoPor;
        private string fechaModificacion;
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
        public string mCreadoPor
        {
            get { return creadoPor; }
            set { creadoPor = value; }
        }
        public string mFechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }
        public string mModificadoPor
        {
            get { return modificadoPor; }
            set { modificadoPor = value; }
        }
        public string mFechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }
        #endregion
    }
}
