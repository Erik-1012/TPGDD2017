﻿using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Devolucion
{
    public partial class FormDevolucion : Form
    {

        FormDevolucionVM formDevolucionVM;

        public FormDevolucion()
        {
            InitializeComponent();
            formDevolucionVM = new FormDevolucionVM();
        }

        private void textNumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) // Permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    // El resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }

        }

        private void buttonDevolverFactura_Click(object sender, EventArgs e)
        {

            try
            {
                formDevolucionVM.devolver(this.textNumeroFactura.Text, this.textMotivo.Text);
                MessageBox.Show("Se ha devuelto correctamente");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Los argumentos ingresados son invalidos");
            }
            catch (FormatException)
            {
                MessageBox.Show("Los argumentos ingresados son invalidos");
            }
            catch (SqlException)
            {
                MessageBox.Show("La factura ingresada es incorrecta");
            }

        }


    }
}
