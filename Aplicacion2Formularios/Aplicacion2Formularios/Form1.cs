using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacion2Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            //form2 = null;
            Show();

        }

        public class Form2 : Form
        {
            private Label etSaludo;
            private ListBox Ls1;
            public Form2()
            {
                IniciarComponentes();
            }

            private void IniciarComponentes()
            {
                Text = "Segundo_Formulario";
                Ls1 = new ListBox();
                etSaludo = new Label();
                etSaludo.Name = "etSaludo";
                etSaludo.Text = "etiqueta";
                etSaludo.Font = new Font("Microsoft Sans Serif", 14,
                FontStyle.Regular);
                etSaludo.TextAlign = ContentAlignment.MiddleCenter;
                etSaludo.Location = new Point(53, 48);
                etSaludo.Size = new Size(187, 35);
                etSaludo.TabIndex = 1;
                Controls.Add(etSaludo);
                Class1 Datos = new Class1();
                this.Ls1.Items.AddRange(Datos.elemento);
                Ls1.Location = new Point(100, 100);
                Controls.Add(Ls1);
                
             }



            private void Ls1_SelectedIndexChanged(object sender, EventArgs e)
            {
                Ls1 = new ListBox();
                if (Ls1.SelectedIndex < 0) return;
                object elementoSeleccionado;
                elementoSeleccionado = Ls1.SelectedItem;
                MessageBox.Show(elementoSeleccionado.ToString());
            }
            



        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 Datos = new Class1();
            this.listBox1.Items.AddRange(Datos.elemento);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

       

       

       
    }
}
