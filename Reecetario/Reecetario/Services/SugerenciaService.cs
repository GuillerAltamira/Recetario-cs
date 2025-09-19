using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RecetarioInteligente.Services
{
    public class SugerenciaService
    {
        private readonly Queue<string> _recetasSugeridas = new Queue<string>();
        private readonly Queue<string> _ingredientesRotativos = new Queue<string>();

        public void AgregarRecetaSugerida(string receta)
        {
            _recetasSugeridas.Enqueue(receta);
        }

        public string ObtenerSiguienteReceta()
        {
            return _recetasSugeridas.Count > 0 ? _recetasSugeridas.Dequeue() : null;
        }

        public void AgregarIngredienteRotativo(string ingrediente)
        {
            if (!_ingredientesRotativos.Any(i => i.ToLower() == ingrediente.ToLower()))
                _ingredientesRotativos.Enqueue(ingrediente);
        }

        public string RotarIngredientePrincipal()
        {
            if (_ingredientesRotativos.Count == 0) return null;

            var ingrediente = _ingredientesRotativos.Dequeue();
            _ingredientesRotativos.Enqueue(ingrediente);
            return ingrediente;
        }
    }
}
