using System;
using System.Collections.Generic;
using System.Linq;

namespace RecetarioInteligente.Utils
{
    /// Cola rotativa genérica.
    /// Permite encolar elementos únicos (según un comparador),
    /// rotar el elemento principal (sacar y volver a encolar),
    /// y desencolar elementos.
    /// <typeparam name="T">Tipo de los elementos almacenados en la cola.</typeparam>
    public class RotatingQueue<T>
    {
        // Cola interna que contiene los elementos en el orden actual.
        private readonly Queue<T> _queue = new Queue<T>();

        // Comparador usado para evaluar igualdad entre elementos al encolar únicos.
        private readonly IEqualityComparer<T> _comparer;

        /// Crea una nueva instancia de <see cref="RotatingQueue{T}"/>.
        /// </summary>
        /// <param name="comparer">
        /// Comparador de igualdad opcional. Si es null se usa <see cref="EqualityComparer{T}.Default"/>.
        /// Usar un comparador personalizado para comparar cadenas ignorando mayúsculas/minúsculas, por ejemplo.
        /// </param>
        public RotatingQueue(IEqualityComparer<T> comparer = null)
        {
            // Inicializa el comparador (por defecto, el comparador por defecto del tipo).
            _comparer = comparer ?? EqualityComparer<T>.Default;
        }

        
        /// Obtiene el número de elementos actualmente en la cola.
        public int Count => _queue.Count;
        /// Encola el elemento únicamente si no existe ya uno igual en la cola.
        /// La comparación se realiza usando el comparador proporcionado.
        /// <param name="item">Elemento a encolar.</param>
        public void EnqueueUnique(T item)
        {
            // Recorre la cola y compara con el comparador para evitar duplicados.
            // Se utiliza LINQ Any para claridad.
            if (!_queue.Any(x => _comparer.Equals(x, item)))
                _queue.Enqueue(item);
        }
        /// Rota la cola: saca el primer elemento y lo vuelve a encolar al final,
        /// devolviendo dicho elemento. Si la cola está vacía devuelve el valor por defecto.
        /// <returns>Elemento girado (el antiguo primero) o default(T) si está vacía.</returns>
        public T Rotate()
        {
            // Si no hay elementos, devuelve default (null para referencias, valor por defecto para structs).
            if (_queue.Count == 0) return default(T);

            // Extrae el primer elemento.
            var item = _queue.Dequeue();

            // Vuelve a encolarlo al final, logrando la rotación.
            _queue.Enqueue(item);

            // Devuelve el elemento rotado.
            return item;
        }
        /// Desencola y devuelve el primer elemento de la cola.
        /// Si la cola está vacía devuelve el valor por defecto de T.
        /// <returns>Primer elemento o default(T) si la cola está vacía.</returns>
        public T Dequeue()
        {
            // Si hay elementos, devuelve el que corresponde; si no, devuelve default.
            return _queue.Count > 0 ? _queue.Dequeue() : default(T);
        }
    }
}