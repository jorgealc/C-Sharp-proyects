using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BindingSourceApplication1.Clases;
using Equin.ApplicationFramework;
namespace BindingSourceApplication1
{
    public partial class Form1 : Form
    {
        private List<CTelefono> colTfnos;
        private BindingSource bs;
     
        BindingListView<CTelefono> vista;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            colTfnos = FactoriaCTelefono.ObtenerColeccionCTelefono();
            vista = new BindingListView<CTelefono>(colTfnos);
            bs = new BindingSource();
           
            bs.DataSource = vista;
            listBox1.DataSource =bs;
            listBox1.DisplayMember = "Nombre";
           
            textBox1.DataBindings.Add("Text", bs, "Telefono");// Enlace entre la propiedad TEXT de la caja de texto y la propiedad(sety get) Telefono de los objetos Ctelefono de la coleecion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tef = 0;
                if (textBox2.Text.Length != 0 && textBox3.Text.Length != 0 &&
                    Decimal.TryParse(textBox3.Text, out tef))
                  {
                         colTfnos.Add(FactoriaCTelefono.CrearCTelefono(textBox2.Text, tef));
                         bs.Position = bs.Count;
                         bs.CurrencyManager.Refresh(); // Para actualizar el control listbox
                   }
         }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bs.Position < 0) return;
             colTfnos.RemoveAt(bs.Position);
             bs.Position = bs.Count - 1;
            bs.CurrencyManager.Refresh();
         //   bs.Position = bs.Count + 10;
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool cambios = false;
            if (textBox2.Text.Length != 0)
            {
                ObjectView<CTelefono> telefono = bs.Current as ObjectView<CTelefono>;// (bs.Current as CTelefono).Nombre = textBox2.Text;
                telefono.Object._nombre = textBox2.Text;
                cambios = true; 
            }
            decimal tef = 0;
            if (textBox3.Text.Length != 0 && Decimal.TryParse(textBox3.Text, out tef))
            {
                ObjectView<CTelefono> telefono = bs.Current as ObjectView<CTelefono>;
                decimal numero = Convert.ToDecimal(textBox3.Text);

                telefono.Object._telefono = numero;
                cambios = true;
            }
            if (cambios) bs.CurrencyManager.Refresh();
.
        }

     /*   private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjectView<CTelefono> obVista =
                                            bs.Current as ObjectView<CTelefono>;
            CTelefono TelefonoActual = obVista.Object;
            MessageBox.Show(TelefonoActual._nombre);
        }*/

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!bs.SupportsAdvancedSorting) return;
            if (checkBox1.Checked == true)
                vista.ApplySort("Nombre ASC");
            else
                vista.ApplySort("Nombre");

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!bs.SupportsSearching) return;
            if (checkBox2.Checked == true)
                bs.Position =
                vista.Find("Nombre", textBox4.Text);
            else
                textBox4.Text = "";
        }



        
}

}

