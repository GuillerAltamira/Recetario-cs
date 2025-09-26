using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecetarioInteligente.Models;
using RecetarioInteligente.Services;

namespace RecetarioInteligente
{

    public partial class MainForm : Form
    {
        private readonly RecetarioService _recetario = new RecetarioService();
        private List<Ingrediente> faltantes = new List<Ingrediente>();



        public MainForm()
        {
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIngrediente.Text))
            {
                _recetario.AgregarIngredienteUsuario(txtIngrediente.Text);
                txtIngrediente.Clear();
                ActualizarListas();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lstRecetas.Items.Clear();
            var recetas = _recetario.BuscarRecetas();
            foreach (var receta in recetas)
            {
                lstRecetas.Items.Add(receta);
            }
            ActualizarListas();
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            lblIngredientePrincipal.Text = _recetario.RotarIngredientePrincipal() ?? "Ninguno";
        }

        private void btnSugerencia_Click(object sender, EventArgs e)
        {
           
                var nombreReceta = _recetario.ObtenerSiguienteRecetaSugerida();
                if (nombreReceta == null)
                {
                    MessageBox.Show("No hay más sugerencias", "Receta Sugerida");
                    return;
                }

                var receta = _recetario.ObtenerRecetaPorNombre(nombreReceta);
                if (receta == null)
                {
                    MessageBox.Show("No se encontró la receta completa", "Error");
                    return;
                }

                var ingredientesUsuario = _recetario.ObtenerIngredientesUsuario();
                faltantes = receta.Ingredientes
               .Where(i => !ingredientesUsuario.Any(u => u.Nombre.Equals(i.Nombre, StringComparison.OrdinalIgnoreCase)))
               .ToList();

            // Mostrar solo en lstFaltante
            lstFaltante.Items.Clear();
                foreach (var ing in faltantes)
                {
                    lstFaltante.Items.Add(ing.Nombre);
                }

                string pasosTexto = string.Join("\n", receta.Pasos.Select((p, i) => $"{i + 1}. {p}"));

                string mensaje = $"🍽️ Receta: {receta.Nombre}\n\n" +
                                 $"👨‍🍳 Pasos:\n{pasosTexto}";

                MessageBox.Show(mensaje, "Receta Sugerida");
         



        }
        private void ActualizarListas()
        {
            lstIngredientes.Items.Clear();
            foreach (var ingrediente in _recetario.ObtenerIngredientesUsuario())
            {
                lstIngredientes.Items.Add(ingrediente);
            }

            lstHistorial.Items.Clear();
            foreach (var busqueda in _recetario.ObtenerHistorial())
            {
                lstHistorial.Items.Add(busqueda);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _recetario.LimpiarTodo();
            lstIngredientes.Items.Clear();
            lstRecetas.Items.Clear();
            lstHistorial.Items.Clear();
            lblIngredientePrincipal.Text = "";
            MessageBox.Show("Todo ha sido limpiado correctamente.", "Limpieza completada");
            lstFaltante.Items.Clear();

        }
    }
}