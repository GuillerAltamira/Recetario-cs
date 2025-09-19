using System;
using System.Collections.Generic;

namespace RecetarioInteligente.Models
{

    public class Receta
    {
        public string Nombre { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public List<string> Pasos { get; set; }

        public Receta(string nombre, List<Ingrediente> ingredientes, List<string> pasos = null)
        {
            Nombre = nombre;
            Ingredientes = ingredientes;
            Pasos = pasos ?? new List<string>();
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
