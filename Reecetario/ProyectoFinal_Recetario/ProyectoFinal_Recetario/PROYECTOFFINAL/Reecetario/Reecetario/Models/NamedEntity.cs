using System;

namespace RecetarioInteligente.Models
{
    /// <summary>
    /// Clase base abstracta para entidades que tienen un nombre.
    /// Proporciona comparación e igualdad basada en el nombre normalizado.
    /// </summary>
    public abstract class NamedEntity
    {
        /// <summary>
        /// Constructor protegido. Inicializa la propiedad Nombre.
        /// </summary>
        /// <param name="nombre">Nombre de la entidad.</param>
        protected NamedEntity(string nombre)
        {
            // Si el nombre es null, se asigna una cadena vacía para evitar errores.
            Nombre = nombre ?? string.Empty;
        }

        /// <summary>
        /// Nombre de la entidad.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Nombre normalizado (sin espacios y en minúsculas) para comparaciones.
        /// </summary>
        public string NombreNormalizado => (Nombre ?? string.Empty).Trim().ToLowerInvariant();

        /// <summary>
        /// Devuelve el nombre de la entidad como cadena.
        /// </summary>
        /// <returns>Nombre de la entidad.</returns>
        public override string ToString() => Nombre;

        /// <summary>
        /// Compara la entidad actual con otra por el nombre normalizado.
        /// </summary>
        /// <param name="obj">Otra entidad para comparar.</param>
        /// <returns>True si los nombres normalizados son iguales, false en caso contrario.</returns>
        public override bool Equals(object obj)
        {
            var other = obj as NamedEntity;
            if (other == null) return false;
            return string.Equals(NombreNormalizado, other.NombreNormalizado, StringComparison.Ordinal);
        }

        /// <summary>
        /// Obtiene el código hash basado en el nombre normalizado.
        /// </summary>
        /// <returns>Código hash de la entidad.</returns>
        public override int GetHashCode()
        {
            return NombreNormalizado.GetHashCode();
        }
    }
}