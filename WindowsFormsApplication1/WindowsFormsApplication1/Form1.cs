﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // label1.Text="";
            label1.Text = "Esto tendrá que aparecer en el label cuando se haya pulsado el boton";
            textBox1.Text = label1.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Esto aparece en el label cuando se carga el formulario";
        }
   
    }
}
