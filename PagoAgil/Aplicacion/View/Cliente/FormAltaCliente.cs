﻿using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View
{
    class FormAltaCliente : Form
    {
        private TextBox nombreTextBox;
        private TextBox apellidoTextBox;
        private TextBox dniTextBox;
        private TextBox mailTextBox;
        private TextBox telefonoTextBox;
        private TextBox direccionTextBox;
        private TextBox codigoPostal;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button limpiarButton;
        private Button guardarButton;
        private Label label8;
        private GroupBox groupBox1;
        FormABMCliente _owner;
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.PerformRefresh();
        }
        public FormAltaCliente(FormABMCliente owner)
        {
            InitializeComponent();
            this.CenterToScreen();
            

            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
        }
        private void InitializeComponent()
        {
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.codigoPostal = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(231, 54);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(201, 26);
            this.nombreTextBox.TabIndex = 0;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(231, 107);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(201, 26);
            this.apellidoTextBox.TabIndex = 1;
            this.apellidoTextBox.TextChanged += new System.EventHandler(this.apellidoTextBox_TextChanged);
            // 
            // dniTextBox
            // 
            this.dniTextBox.Location = new System.Drawing.Point(231, 160);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(201, 26);
            this.dniTextBox.TabIndex = 2;
            this.dniTextBox.TextChanged += new System.EventHandler(this.dniTextBox_TextChanged);
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(231, 213);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(201, 26);
            this.mailTextBox.TabIndex = 3;
            this.mailTextBox.TextChanged += new System.EventHandler(this.mailTextBox_TextChanged);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(231, 266);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(201, 26);
            this.telefonoTextBox.TabIndex = 4;
            this.telefonoTextBox.TextChanged += new System.EventHandler(this.telefonoTextBox_TextChanged);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(231, 319);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(201, 26);
            this.direccionTextBox.TabIndex = 5;
            // 
            // codigoPostal
            // 
            this.codigoPostal.Location = new System.Drawing.Point(231, 372);
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.Size = new System.Drawing.Size(201, 26);
            this.codigoPostal.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(231, 425);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Codigo Postal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha de nacimiento";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(65, 479);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(132, 55);
            this.limpiarButton.TabIndex = 16;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(448, 479);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(132, 55);
            this.guardarButton.TabIndex = 17;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(175, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 450);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // FormAltaCliente
            // 
            this.ClientSize = new System.Drawing.Size(659, 573);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.codigoPostal);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAltaCliente";
            this.Text = "Alta cliente";
            this.Load += new System.EventHandler(this.FormAltaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public FormAltaCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            ClienteDB c = new ClienteDB();
            
            if(dniTextBox.Text.Length>0)
            c.id = Int32.Parse(dniTextBox.Text);

            if (nombreTextBox.Text.Length > 0)
            c.nombre = nombreTextBox.Text;

            if(apellidoTextBox.Text.Length>0)
            c.apellido = apellidoTextBox.Text;

            if (direccionTextBox.Text.Length > 0)
                c.domicilio = direccionTextBox.Text;
            else
                c.domicilio = "NINGUNO";
         
            c.habilitado = true;

            if (mailTextBox.Text.Length > 0)
                c.mail = mailTextBox.Text;
            
            c.nacimiento = DateTime.Parse(dateTimePicker1.Text);

            if (telefonoTextBox.Text.Length > 0)
                c.telefono = Int32.Parse(telefonoTextBox.Text);
            else
                c.telefono = 0;

            if (codigoPostal.Text.Length > 0)
                c.codigoPostal = codigoPostal.Text;
            else
                c.codigoPostal = "NINGUNO";

            if (c.id == 0 || c.nombre == null || c.apellido == null || c.mail==null) 
            {
                MessageBox.Show("Los campos DNI, Nombre, apellido e email no pueden estar vacios");
            }
            else { 
            RepositorioClientes.getInstance().almacenamiento.aniadir(c);
                }
        }

        private void dniTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(dniTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo numeros");
                dniTextBox.Text = dniTextBox.Text.Remove(dniTextBox.Text.Length - 1);
            }
        }

        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = Configuracion.fecha();

            
                
            
        }

        private void telefonoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(telefonoTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo numeros");
                telefonoTextBox.Text = telefonoTextBox.Text.Remove(telefonoTextBox.Text.Length - 1);
            }
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            dniTextBox.Text = null;
            nombreTextBox.Text = null;
           apellidoTextBox.Text = null;
            codigoPostal.Text = null;
            
            mailTextBox.Text = null;
            dateTimePicker1.Text = null;
           telefonoTextBox.Text=null;
            codigoPostal.Text=null;
        }

        private void apellidoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(apellidoTextBox.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Solo texto");
                apellidoTextBox.Text = apellidoTextBox.Text.Remove(apellidoTextBox.Text.Length - 1);
            }
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(nombreTextBox.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Solo texto");
                nombreTextBox.Text = nombreTextBox.Text.Remove(nombreTextBox.Text.Length - 1);
            }
        }

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
