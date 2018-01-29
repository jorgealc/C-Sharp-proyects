using System;
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
        public Form1()//Constructor que a su vez llamaa a los metodos que se presentan a continuacion Initialize y AsingarDatos
        {
            InitializeComponent();
            AsignarDatosTabla();
        }

        private void AsignarDatosTabla()
        {
            object[] fila0 = { "../../Imagenes/Foto.jpg",
                             "Alfons González Pérez",
                                "Argentona, Barcelona", "933333333", true };
            object[] fila1 = { "../../Imagenes/Foto.jpg",
                              "Ana María Cuesta Suñer",
                             "Gijón, Asturias", "984454545", false };
            object[] fila2 = { "../../Imagenes/Foto.jpg",
                                "Elena Veiguela Suárez",
                                "Pontevedra", "986678678", false };
            object[] fila3 = { "../../Imagenes/Foto.jpg",
                                "Pedro Aguado Rodríguez",
                                   "Madrid", "912804574", true };
            // Añadir las filas a la tabla
            TablaTfnos.Rows.Add(fila0);
            TablaTfnos.Rows.Add(fila1);
            TablaTfnos.Rows.Add(fila2);
            TablaTfnos.Rows.Add(fila3);
        }

        private void TablaTfnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.TablaTfnos.Columns[e.ColumnIndex].Name)
            {
                case "colFoto":
                    if (e.Value != null) // e.Value : valor de la celda
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    break;
            }
        }

        private void TablaTfnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object valorCelda = TablaTfnos.CurrentCell.Value;
            if (valorCelda != null) MessageBox.Show(valorCelda.ToString());
        }
    }





}

