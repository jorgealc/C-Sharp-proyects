using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace BindingSourceApplication1.Clases
{
    class FactoriaCTelefono
    {
        private static List<CTelefono> _telefonos;
        // Nuevo CTelefono
        public static CTelefono CrearCTelefono(string nom, decimal tfn)
        {
            CTelefono tfno = new CTelefono();
            tfno.Nombre = nom;
            tfno.Telefono = tfn;
            return tfno;
        }
        public static List<CTelefono> ObtenerColeccionCTelefono()
        {
            _telefonos = new List<CTelefono>();
            Random rnd = new Random();
            for (int i = 1; i < 10; i++)
            {
                _telefonos.Add(CrearCTelefono("Persona " + i,
                rnd.Next(636000000, 636999999)));
            }
            return _telefonos;
        }
    }
}
