﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class clsEntidadUsuarioRol
    {
        private int idUsuario;
        private int idRol;
        private string creadoPor;
        private string fechaCreacion;
        private string modificadoPor;
        private string fechaModificacion;

        public int mIdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public int mIdRol
        {
            get { return idRol; }
            set { idRol = value; }
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

    }
}
