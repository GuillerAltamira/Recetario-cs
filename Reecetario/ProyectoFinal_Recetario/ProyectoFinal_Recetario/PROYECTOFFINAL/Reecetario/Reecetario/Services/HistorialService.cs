using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetarioInteligente.Services
{
    /// <summary>
    /// Servicio para gestionar el historial de búsquedas realizadas por el usuario.
    /// Utiliza una pila (Stack) para almacenar las búsquedas en orden LIFO (última en entrar, primera en salir).
    /// </summary>
    public class HistorialService
    {
        // Pila interna que almacena las búsquedas realizadas.
        private readonly Stack<string> _historial = new Stack<string>();

        /// <summary>
        /// Agrega una nueva búsqueda al historial.
        /// </summary>
        /// <param name="busqueda">Texto de la búsqueda realizada.</param>
        public void AgregarBusqueda(string busqueda)
        {
            _historial.Push(busqueda);
        }

        /// <summary>
        /// Elimina todo el historial de búsquedas.
        /// </summary>
        public void LimpiarHistorial()
        {
            _historial.Clear();
        }

        /// <summary>
        /// Obtiene el historial completo de búsquedas.
        /// </summary>
        /// <returns>Enumeración de cadenas con las búsquedas almacenadas.</returns>
        public IEnumerable<string> ObtenerHistorial()
        {
            return _historial;
        }
    }
}