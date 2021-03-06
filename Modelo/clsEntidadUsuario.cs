﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsEntidadUsuario
    {
        #region atributos
        private int idUsuario;
        private string usuario;
        private string contrasena;

        private string nombre;
        private string apellidos;
        private string tipoUsuario;

        private int estadoUsuario;
        private Boolean estadoContrasena;
        private string creadoPor;
        private string fechaCreacion;
        private string modificadoPor;
        private string fechaModificacion;

        #endregion

        #region Propiedades
        public int mIdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string mUsuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string mContrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public string mNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string mApellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string mTipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

        public int mEstadoUsuario
        { 
            get { return estadoUsuario; }
            set { estadoUsuario = value; }
        }
        public Boolean mEstadoContrasena
        {
            get { return estadoContrasena; }
            set { estadoContrasena = value; }
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
