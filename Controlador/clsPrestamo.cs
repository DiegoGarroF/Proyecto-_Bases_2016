﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class clsPrestamo
    {
        private string strSentencia;

        public Boolean mInsertarCliente( clsEntidadPrestamo pEntidadPrestamo)
        {
            strSentencia = "insert into prestamo(fechaInicio,fechaFin, nombreEstudiante, carnet) values('"+ pEntidadPrestamo.setGetFechaInicio +"')";
            return false;
        }


    }
}
