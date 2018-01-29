using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQWindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.sqlDataAdapter1.Fill(this.dataSet11);
            // comboBox1.DataSource = alumnosBindingSource1;
            // comboBox1.DisplayMember = "nombre";
            

        }


        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        /*{
             
           // textBox1.DataBindings.Clear();
            //textBox1.DataBindings.Add("Text", alumnosBindingSource.Current, "id_alumno");

            
        }*/
        { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
            textBox1.DataBindings.Clear();
            string texto;
             texto = comboBox1.SelectedValue.ToString();
          //  textBox1.Text = comboBox1.SelectedValue.ToString();
           
            sqlDataAdapter2.SelectCommand.Parameters["@IDAlumno"].Value = texto;
            
            this.sqlDataAdapter2.Fill(this.dataSet21);
            listBox1.Focus();
            
           
            

        }

        
   
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show("La nota que has obtenido en la asignatura" + " ha sido: " + listBox1.SelectedValue.ToString());

             
            }
            catch (NullReferenceException er)
            {
            }

          }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
             try
            {
                dataSet21.Clear();// borra el conjunto de datos actual
            }
             catch (NullReferenceException er)
             {
             }
        }   

    }   

}
       
        

        
    

