﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        CheckBox miCheckbox;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            miCheckbox = new CheckBox();
            miCheckbox.Location = new System.Drawing.Point(50, 50);
            miCheckbox.Name = "miCheckbox";
            miCheckbox.Size = new System.Drawing.Size(100, 20);
            miCheckbox.Text = "Mi Checkbox";
            this.Controls.Add(miCheckbox);

            MessageBox.Show("¡Hola, mundo!");
            MessageBox.Show("Soy Sebastian, Buenos dias!");
            MessageBox.Show("Sebastian estuvo aquí.");
            MessageBox.Show("Luis estuvo aquí");

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}