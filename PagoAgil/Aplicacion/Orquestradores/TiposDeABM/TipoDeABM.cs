﻿using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.View.Empresas;
using PagoAgil.Aplicacion.View.Facturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.Orquestradores.TiposDeABM
{
    public interface TipoDeABM<E>
    {
        string[] completado(string abm);

        string[] confirmado(string abm);

        string[] ok(string abm);

        void mostrar(FormABMAdapter form);

        void realizate(Repositorio<E> repositorio, E entidad);
    }
}
