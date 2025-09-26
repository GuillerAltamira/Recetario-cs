using System;
using System.Collections.Generic;

namespace RecetarioInteligente.Models
{
    /// <summary>
    /// Representa una receta culinaria, que contiene un nombre, una lista de ingredientes y una lista de pasos.
    /// Hereda de NamedEntity para reutilizar la propiedad Nombre y la lógica de comparación.
    /// </summary>
    public class Receta : NamedEntity
    {
        /// <summary>
        /// Lista de ingredientes necesarios para la receta.
        /// </summary>
        public List<Ingrediente> Ingredientes { get; set; }

        /// <summary>
        /// Lista de pasos a seguir para preparar la receta.
        /// </summary>
        public List<string> Pasos { get; set; }

        /// <summary>
        /// Constructor de la clase Receta.
        /// </summary>
        /// <param name="nombre">Nombre de la receta.</param>
        /// <param name="ingredientes">Lista de ingredientes requeridos.</param>
        /// <param name="pasos">Lista de pasos de preparación (opcional).</param>
        public Receta(string nombre, List<Ingrediente> ingredientes, List<string> pasos = null)
            : base(nombre) // Llama al constructor de NamedEntity para inicializar el nombre.
        {
            // Si no se pasan ingredientes, se inicializa con una lista vacía.
            Ingredientes = ingredientes ?? new List<Ingrediente>();
            // Si no se pasan pasos, se inicializa con una lista vacía.
            Pasos = pasos ?? new List<string>();
        }
    }
}
