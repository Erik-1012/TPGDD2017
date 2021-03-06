﻿using PagoAgil.Aplicacion.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.Modelo.Usuario
{
    public class Rol
    {

        public int id { get; set; }
        public string nombre{get; set;}
        public bool habilitado { get; set; }

        public List<Funcionalidad> funcionalidades{get; set;}

        public Rol(int id, string nuevoNombre, List<Funcionalidad> nuevasFuncionalidades)
        {
            this.id = id;
            this.nombre = nuevoNombre;
            this.funcionalidades = nuevasFuncionalidades;

        }

        public Rol(string nuevoNombre, List<Funcionalidad> nuevasFuncionalidades) {

            this.nombre = nuevoNombre;
            this.funcionalidades = nuevasFuncionalidades;

        }

        public Rol(string nuevoNombre, List<Funcionalidad> nuevasFuncionalidades, bool unEstado)
        {

            this.nombre = nuevoNombre;
            this.funcionalidades = nuevasFuncionalidades;
            this.habilitado = unEstado;

        }

        public Rol(FilaDTO fila)
        {

            List<string> elementos = fila.obtener();

            this.id = int.Parse(elementos.ElementAt(0));
            this.nombre = elementos.ElementAt(1);
            this.habilitado = elementos.ElementAt(2).Equals("True") ? true : false;

        }

        public Boolean posees(string funcionalidad)
        {
            return funcionalidades.Any(f => f.es(funcionalidad));
        }

        public override string ToString()
        {
            return this.nombre;
        }

    }
}
