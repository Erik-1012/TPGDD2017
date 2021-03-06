﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.ViewModel;
using PagoAgil.Aplicacion.View.Roles;
using PagoAgil.Aplicacion.BD.Repositorios;

namespace PagoAgil.Aplicacion.View.Roles
{
    public partial class FormModificacionRol : Form
    {
        Rol rol;
        RolesBuilder builder;
        ModificacionRolVM VM;
        HomeVM VMHome;

        public FormModificacionRol(Rol rolElegido, HomeVM vm)
        {
            InitializeComponent();
            this.CenterToScreen();

            rol = rolElegido;
            builder = new RolesBuilder();
            VM = new ModificacionRolVM();
            VMHome = vm;

            this.cargarCampos();
        }

        private void cargarCampos() 
        {
            textBoxNombre.Text = rol.nombre;

            List<Funcionalidad> funcionalidades = VM.obtenerFuncionalidades();

            //Agregar funcionalidades al checked list box
            foreach (Funcionalidad f in funcionalidades)
            {
                checkedListBoxFuncionalidades.Items.Add(f);
            }

            List<Funcionalidad> funcionalidadesDelRol = rol.funcionalidades;

            for (int i = 0; i < checkedListBoxFuncionalidades.Items.Count; i++)
            {
                Funcionalidad fun = (Funcionalidad)checkedListBoxFuncionalidades.Items[i];

                //Esto es para marcar de todas las funcionalidades las que tiene el rol seleccionado
                if (funcionalidadesDelRol.Any(f => f.nombre.Equals(fun.nombre)))
                {
                    checkedListBoxFuncionalidades.SetItemCheckState(i, CheckState.Checked);
                }
                else 
                {
                    checkedListBoxFuncionalidades.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            if (rol.habilitado == false)
            {
                checkBoxEstado.Checked = false;
                checkBoxEstado.Enabled = true;
            }
            else
            {
                checkBoxEstado.Checked = true;
                checkBoxEstado.Enabled = false;
            }

            builder.funcionalidades = rol.funcionalidades;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Trim().Length==0) buttonConfirmarCambios.Enabled = false;
            else buttonConfirmarCambios.Enabled = true;

            builder.nombre = textBoxNombre.Text;
        }

        private void checkedListBoxFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Funcionalidad> funcionalidadesElegidas = new List<Funcionalidad>();

            for (int i = 0; i < checkedListBoxFuncionalidades.Items.Count; i++)
            {
                if (checkedListBoxFuncionalidades.GetItemChecked(i))
                {
                    Funcionalidad f = (Funcionalidad)checkedListBoxFuncionalidades.Items[i];
                    funcionalidadesElegidas.Add(f);
                }
            }

            builder.funcionalidades = funcionalidadesElegidas;
        }

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {
            builder.habilitado = checkBoxEstado.Checked;
        }

        private void buttonConfirmarCambios_Click(object sender, EventArgs e)
        {

            Rol rolModificado = builder.crearRolModificado();
            rolModificado.id = rol.id;

            RepositorioRoles.getInstancia().getAlmacenamiento().modificar(rolModificado);

            if(Sesion.usuario.rol.id == rolModificado.id){
            Sesion.usuario.rol = rolModificado;

            VMHome.notificarCambios();
            }

            this.Hide();
        }
    }
}
