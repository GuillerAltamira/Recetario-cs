using System;
using System.Collections.Generic;
using System.Linq;
using RecetarioInteligente.Utils;

namespace RecetarioInteligente.Services
{
    /// <summary>
    /// Servicio encargado de gestionar sugerencias de recetas e ingredientes rotativos.
    /// Permite encolar recetas sugeridas y manejar ingredientes principales de forma rotativa.
    /// </summary>
    public class SugerenciaService
    {
        // Cola de recetas sugeridas, se procesan en orden de llegada (FIFO).
        private readonly Queue<string> _recetasSugeridas = new Queue<string>();

        // Cola rotativa de ingredientes principales sugeridos, sin duplicados y sin distinguir mayúsculas/minúsculas.
        private readonly RotatingQueue<string> _ingredientesRotativos = new RotatingQueue<string>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Agrega una receta a la cola de sugerencias si el nombre no es nulo ni vacío.
        /// </summary>
        /// <param name="receta">Nombre de la receta sugerida.</param>
        public void AgregarRecetaSugerida(string receta)
        {
            if (!string.IsNullOrWhiteSpace(receta))
                _recetasSugeridas.Enqueue(receta);
        }

        /// <summary>
        /// Obtiene y elimina la siguiente receta sugerida de la cola.
        /// </summary>
        /// <returns>Nombre de la receta sugerida o null si no hay más sugerencias.</returns>
        public string ObtenerSiguienteReceta()
        {
            return _recetasSugeridas.Count > 0 ? _recetasSugeridas.Dequeue() : null;
        }

        /// <summary>
        /// Agrega un ingrediente a la cola rotativa de ingredientes principales si no está vacío ni duplicado.
        /// </summary>
        /// <param name="ingrediente">Nombre del ingrediente a agregar.</param>
        public void AgregarIngredienteRotativo(string ingrediente)
        {
            if (string.IsNullOrWhiteSpace(ingrediente)) return;
            _ingredientesRotativos.EnqueueUnique(ingrediente.Trim());
        }

        /// <summary>
        /// Rota el ingrediente principal: mueve el primero al final y lo devuelve.
        /// </summary>
        /// <returns>Nombre del nuevo ingrediente principal o null si la cola está vacía.</returns>
        public string RotarIngredientePrincipal()
        {
            return _ingredientesRotativos.Count == 0 ? null : _ingredientesRotativos.Rotate();
        }
    }
}
