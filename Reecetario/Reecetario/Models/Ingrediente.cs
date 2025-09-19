using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetarioInteligente.Models
{
    public class Ingrediente
    {
        public string Nombre { get; set; }

        public Ingrediente(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}