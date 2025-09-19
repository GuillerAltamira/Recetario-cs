using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecetarioInteligente.Services
{
    public class HistorialService
    {
        private readonly Stack<string> _historial = new Stack<string>();

        public void AgregarBusqueda(string busqueda)
        {
            _historial.Push(busqueda);
        }
        public void LimpiarHistorial()
        {
            _historial.Clear();
        }


        public IEnumerable<string> ObtenerHistorial()
        {
            return _historial;
        }
    }
}