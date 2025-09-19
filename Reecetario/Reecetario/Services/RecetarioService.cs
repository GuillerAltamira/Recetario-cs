using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetarioInteligente.Models;


using System;
using System.Collections.Generic;
using System.Linq;
using RecetarioInteligente.Models;

namespace RecetarioInteligente.Services
{
    public class RecetarioService
    {
        private readonly List<Ingrediente> _ingredientesUsuario = new List<Ingrediente>();
        private readonly HistorialService _historial = new HistorialService();
        private readonly SugerenciaService _sugerencias = new SugerenciaService();
        private Dictionary<string, Receta> _recetas = new Dictionary<string, Receta>();

        public RecetarioService()
        {
            InicializarRecetas();
        }

        public Receta ObtenerRecetaPorNombre(string nombre)
        {
            return _recetas.ContainsKey(nombre) ? _recetas[nombre] : null;
        }

        public void AgregarReceta(Receta receta)
        {
            _recetas[receta.Nombre] = receta;
        }

        public void AgregarIngredienteUsuario(string nombreIngrediente)
        {
            if (!_ingredientesUsuario.Any(i => i.Nombre.ToLower() == nombreIngrediente.ToLower()))
            {
                _ingredientesUsuario.Add(new Ingrediente(nombreIngrediente.ToLower()));
                _sugerencias.AgregarIngredienteRotativo(nombreIngrediente);
            }
        }

        public List<Receta> BuscarRecetas()
        {
            var recetasPosibles = _recetas.Values
                .Where(r => r.Ingredientes.Any(i => _ingredientesUsuario.Any(u => u.Nombre == i.Nombre)))
                .ToList();

            if (recetasPosibles.Any())
            {
                _historial.AgregarBusqueda($"Búsqueda: {string.Join(", ", _ingredientesUsuario.Select(i => i.Nombre))}");
                recetasPosibles.ForEach(r => _sugerencias.AgregarRecetaSugerida(r.Nombre));
            }

            return recetasPosibles;
        }

        public void LimpiarTodo()
        {
            _ingredientesUsuario.Clear();
            _historial.LimpiarHistorial();
        }

        public List<Ingrediente> ObtenerIngredientesUsuario() => _ingredientesUsuario;
        public IEnumerable<string> ObtenerHistorial() => _historial.ObtenerHistorial();
        public string ObtenerSiguienteRecetaSugerida() => _sugerencias.ObtenerSiguienteReceta();
        public string RotarIngredientePrincipal() => _sugerencias.RotarIngredientePrincipal();

        private void InicializarRecetas()
        {
                AgregarReceta(new Receta("Ensalada César",
                new List<Ingrediente>
                {
                    new Ingrediente("lechuga"),
                    new Ingrediente("crutones"),
                    new Ingrediente("queso parmesano")
                },
                new List<string>
                {
                    "Lavar bien la lechuga y cortarla en trozos.",
                    "Añadir los crutones y el queso parmesano.",
                    "Mezclar todo con aderezo César y servir."
                }));

                AgregarReceta(new Receta("Tortilla Española",
                    new List<Ingrediente>
                    {
            new Ingrediente("huevos"),
            new Ingrediente("patatas"),
            new Ingrediente("cebolla")
                    },
                    new List<string>
                    {
            "Pelar y cortar las patatas y cebolla.",
            "Freír en aceite hasta dorar.",
            "Batir los huevos, mezclar con las papas y cebolla y cocinar en sartén."
                    }));

                AgregarReceta(new Receta("Sándwich de Queso",
                    new List<Ingrediente>
                    {
            new Ingrediente("pan"),
            new Ingrediente("queso"),
            new Ingrediente("mantequilla")
                    },
                    new List<string>
                    {
            "Untar mantequilla en el pan.",
            "Agregar queso entre las rebanadas.",
            "Cocinar en sartén o sandwichera hasta que se derrita el queso."
                    }));

                AgregarReceta(new Receta("Salteñas",
                    new List<Ingrediente>
                    {
            new Ingrediente("masa de harina"),
            new Ingrediente("carne de res"),
            new Ingrediente("papa"),
            new Ingrediente("ají amarillo"),
            new Ingrediente("aceitunas"),
            new Ingrediente("huevo duro")
                    },
                    new List<string>
                    {
            "Preparar el relleno con carne, papa, ají y condimentos.",
            "Armar las salteñas colocando el relleno en la masa junto con huevo duro y aceitunas.",
            "Cerrar bien y hornear hasta que la masa esté dorada."
                    }));

                AgregarReceta(new Receta("Silpancho",
                    new List<Ingrediente>
                    {
            new Ingrediente("carne empanizada"),
            new Ingrediente("arroz"),
            new Ingrediente("papas"),
            new Ingrediente("huevo frito"),
            new Ingrediente("ensalada de tomate y cebolla")
                    },
                    new List<string>
                    {
            "Freír la carne empanizada hasta que esté dorada.",
            "Preparar arroz blanco y papas fritas.",
            "Servir con huevo frito encima y ensalada fresca de tomate y cebolla."
                    }));

                AgregarReceta(new Receta("Pique Macho",
                    new List<Ingrediente>
                    {
            new Ingrediente("carne de res"),
            new Ingrediente("salchichas"),
            new Ingrediente("papas fritas"),
            new Ingrediente("huevo duro"),
            new Ingrediente("locoto"),
            new Ingrediente("cebolla")
                    },
                    new List<string>
                    {
            "Cortar y freír la carne y las salchichas.",
            "Freír papas y preparar una mezcla con cebolla y locoto.",
            "Servir todo junto y agregar huevo duro en rodajas."
                    }));

                AgregarReceta(new Receta("Sopa de Maní",
                    new List<Ingrediente>
                    {
            new Ingrediente("maní molido"),
            new Ingrediente("carne de res"),
            new Ingrediente("papa"),
            new Ingrediente("arvejas"),
            new Ingrediente("zanahoria"),
            new Ingrediente("fideos"),
            new Ingrediente("perejil")
                    },
                    new List<string>
                    {
            "Tostar y moler el maní.",
            "Cocinar la carne con verduras y maní en agua.",
            "Agregar los fideos al final y decorar con perejil picado."
                    }));

                AgregarReceta(new Receta("Chairo Paceño",
                    new List<Ingrediente>
                    {
            new Ingrediente("chalona"),
            new Ingrediente("papa deshidratada (chuño)"),
            new Ingrediente("arvejas"),
            new Ingrediente("zanahoria"),
            new Ingrediente("hierbas andinas")
                    },
                    new List<string>
                    {
            "Hervir la chalona con chuño en bastante agua.",
            "Añadir arvejas, zanahoria picada y hierbas andinas.",
            "Cocinar hasta que todos los ingredientes estén suaves."
                    }));

                AgregarReceta(new Receta("Majadito",
                    new List<Ingrediente>
                    {
            new Ingrediente("arroz"),
            new Ingrediente("charque"),
            new Ingrediente("plátano frito"),
            new Ingrediente("huevo frito"),
            new Ingrediente("cebolla"),
            new Ingrediente("pimiento")
                    },
                    new List<string>
                    {
            "Freír el charque desmenuzado con cebolla y pimiento.",
            "Agregar arroz cocido y mezclar bien.",
            "Servir con plátano frito y huevo frito encima."
                    }));

                AgregarReceta(new Receta("Pollo a la Brasa",
                    new List<Ingrediente>
                    {
            new Ingrediente("pollo entero"),
            new Ingrediente("ajo"),
            new Ingrediente("comino"),
            new Ingrediente("pimienta"),
            new Ingrediente("cerveza"),
            new Ingrediente("vinagre"),
            new Ingrediente("sal")
                    },
                    new List<string>
                    {
            "Marinar el pollo con ajo, comino, pimienta, cerveza y vinagre.",
            "Dejar reposar por al menos 4 horas.",
            "Hornear hasta que el pollo esté bien cocido y dorado."
                    }));

                AgregarReceta(new Receta("Arroz Chaufa",
                    new List<Ingrediente>
                    {
            new Ingrediente("arroz cocido"),
            new Ingrediente("pollo"),
            new Ingrediente("huevo"),
            new Ingrediente("cebolla verde"),
            new Ingrediente("sillao"),
            new Ingrediente("ajo"),
            new Ingrediente("jengibre")
                    },
                    new List<string>
                    {
            "Freír el ajo y jengibre.",
            "Agregar pollo y luego arroz cocido.",
            "Añadir huevo batido, sillao y cebolla verde.",
            "Saltear todo junto y servir caliente."
                    }));

                AgregarReceta(new Receta("Empanadas de Queso",
                    new List<Ingrediente>
                    {
            new Ingrediente("harina"),
            new Ingrediente("manteca"),
            new Ingrediente("agua"),
            new Ingrediente("queso"),
            new Ingrediente("azúcar"),
            new Ingrediente("huevo")
                    },
                    new List<string>
                    {
            "Preparar la masa con harina, manteca y agua.",
            "Rellenar con queso y cerrar en media luna.",
            "Hornear hasta dorar y espolvorear con azúcar."
                    }));

                AgregarReceta(new Receta("Chairo Paceño",
                    new List<Ingrediente>
                    {
            new Ingrediente("carne de cordero"),
            new Ingrediente("chuño"),
            new Ingrediente("zanahoria"),
            new Ingrediente("papa"),
            new Ingrediente("cebolla"),
            new Ingrediente("trigo pelado"),
            new Ingrediente("ajo")
                    },
                    new List<string>
                    {
            "Hervir la carne con el trigo y chuño.",
            "Agregar las verduras picadas.",
            "Cocinar hasta que todo esté tierno.",
            "Servir con hierba buena encima."
                    }));

                AgregarReceta(new Receta("Papa a la Huancaína",
                    new List<Ingrediente>
                    {
            new Ingrediente("papas"),
            new Ingrediente("queso fresco"),
            new Ingrediente("ají amarillo"),
            new Ingrediente("galletas"),
            new Ingrediente("leche evaporada"),
            new Ingrediente("sal")
                    },
                    new List<string>
                    {
            "Licuar queso, ají, galletas, leche y sal.",
            "Cocer las papas y cortarlas en rodajas.",
            "Servir con la salsa por encima."
                    }));

                AgregarReceta(new Receta("Suspiros de Limeña",
                    new List<Ingrediente>
                    {
            new Ingrediente("leche condensada"),
            new Ingrediente("leche evaporada"),
            new Ingrediente("yemas"),
            new Ingrediente("claras"),
            new Ingrediente("azúcar"),
            new Ingrediente("vainilla")
                    },
                    new List<string>
                    {
            "Hervir las leches hasta espesar.",
            "Agregar yemas y cocinar sin dejar de mover.",
            "Batir claras con azúcar a punto de nieve.",
            "Servir la crema con el merengue encima."
                    }));

                AgregarReceta(new Receta("Enrollado de Pollo",
                    new List<Ingrediente>
                    {
            new Ingrediente("pechuga de pollo"),
            new Ingrediente("queso"),
            new Ingrediente("jamón"),
            new Ingrediente("espinaca"),
            new Ingrediente("sal"),
            new Ingrediente("pimienta")
                    },
                    new List<string>
                    {
            "Rellenar la pechuga con queso, jamón y espinaca.",
            "Enrollar y asegurar con palillos.",
            "Hornear hasta que esté bien cocido."
                    }));

                AgregarReceta(new Receta("Arroz con Leche",
                    new List<Ingrediente>
                    {
            new Ingrediente("arroz"),
            new Ingrediente("leche"),
            new Ingrediente("canela"),
            new Ingrediente("azúcar"),
            new Ingrediente("clavo de olor"),
            new Ingrediente("pasas")
                    },
                    new List<string>
                    {
            "Hervir arroz con canela y clavo.",
            "Agregar leche y azúcar.",
            "Cocinar hasta espesar y añadir pasas."
                    }));


        }
    }

}

