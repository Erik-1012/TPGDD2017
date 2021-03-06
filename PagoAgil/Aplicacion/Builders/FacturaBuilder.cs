﻿using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.BD.Utils;
using PagoAgil.Aplicacion.Builders.Excepciones;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.View.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Builders
{
    public class FacturaBuilder
    {
        public long numero { get; set; }
        public bool estado { get; set; }
        public DateTime fecha_alta { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public long dni_cliente { get; set; }
        public string cuit_empresa { get; set; }
        public List<Item> items { get; set; }

        public FacturaBuilder()
        {
            items = new List<Item>();
        }

        public Factura crear()
        {
            return new Factura(numero, "", estado, this.montoFactura(), fecha_alta, fecha_vencimiento, dni_cliente, cuit_empresa, items);
        }

        public float montoFactura()
        {
            return this.items.Sum(i => i.montoTotal());
        }

        public void validar()
        {
            revisarLlenado();
            existeOtroIgual();
            noExisteDni();
        }

        private void revisarLlenado()
        {
            List<String> errores = new List<String>();

            if (this.numero == null) errores.Add("Numero");
            if (this.fecha_alta == null) errores.Add("Fecha de alta");
            if (this.fecha_vencimiento == null) errores.Add("Fecha de vencimiento");
            if (this.dni_cliente == null) errores.Add("DNI de cliente");
            if (this.cuit_empresa == null || this.cuit_empresa.Count() == 0) errores.Add("Empresa");
            if (this.items.Count() == 0) errores.Add("Items");

            if (errores.Count != 0) throw new NoSePuedeCrearException(errores);
        }

        private void existeOtroIgual()
        {
            if ( (bool) EjecutadorDeFunciones.instanciar().ejecutarFuncion("buscarFactura", this.numero, SqlDbType.Int))
            {
                YaExisteObjetoConEsaClave excepcion = new YaExisteObjetoConEsaClave();

                excepcion.mensaje = "Ya existe la factura número " + this.numero + ".";

                throw excepcion;
            }
        }

        private void noExisteDni()
        {
            if ( ! (bool) EjecutadorDeFunciones.instanciar().ejecutarFuncion("buscarCliente", this.dni_cliente, SqlDbType.Int))
            {
                NoExisteObjetoConEsaClave excepcion = new NoExisteObjetoConEsaClave();

                excepcion.mensaje = "No existe el DNI " + this.dni_cliente + ".";

                throw excepcion;
            }
        }
    }
}
