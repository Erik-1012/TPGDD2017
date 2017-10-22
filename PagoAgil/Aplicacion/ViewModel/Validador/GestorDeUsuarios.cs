﻿using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.ViewModel.Validador
{
    class GestorDeUsuarios
    {

        private static GestorDeUsuarios instance = new GestorDeUsuarios();

        public static GestorDeUsuarios getInstance()
        {
            return instance;
        }

        int cantidadDeIntentos = 0;

        public UsuarioDB obtenerUsuario(string nombreUsuario, string password)
        {

            if (ValidadorDeInputs.Instance.esValido(nombreUsuario) && ValidadorDeInputs.Instance.esValido(password))
            {

                UsuarioDB usuario = RepositorioUsuarios.getInstance().obtener(nombreUsuario);

                if (usuario != null && usuario.getContrasenia().Equals(password))
                {
                    cantidadDeIntentos = 0;
                    return usuario;
                }

            }

            this.loginErroneo();

            return null;

        }

        public void inhabilitar(string nombre)
        {

            if (ValidadorDeInputs.Instance.esValido(nombre))
            {
                RepositorioUsuarios.getInstance().baja(RepositorioUsuarios.getInstance().obtener(nombre));
            }

        }

        private void loginErroneo()
        {
            cantidadDeIntentos++;

            if (cantidadDeIntentos >= 3)
            {
                cantidadDeIntentos = 0;
                throw new DemasiadosIntentosException("Intentaste logear más de 3 veces");
            }

        }

    }
}