﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.View.Pago.Excepciones
{
    class ClienteDeshabilitadoException : Exception
    {
        public ClienteDeshabilitadoException(string message) : base(message)  { }
    }
}