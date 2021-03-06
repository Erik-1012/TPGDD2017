﻿using PagoAgil.Aplicacion.Orquestradores.TiposDeABM.ABMs;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Empresas
{
    public partial class EmpresasOk : Form
    {
        public EmpresasOk()
        {
            InitializeComponent();
            this.iniciarTitulos();
            this.CenterToScreen();
        }

        private void iniciarTitulos()
        {
            this.Text = EmpresaABM.instanciar().titulosOk()[0];
            this.confirmacionText.Text = EmpresaABM.instanciar().titulosOk()[1];
        }
    }
}
