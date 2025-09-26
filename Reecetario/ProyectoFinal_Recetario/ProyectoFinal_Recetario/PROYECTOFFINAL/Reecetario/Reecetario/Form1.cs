using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecetarioInteligente.Services;
namespace RecetarioInteligente
{
    public partial class MainForm : Form
    {
        private readonly RecetarioService _recetario = new RecetarioService();

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
            var sugerencia = _recetario.ObtenerSiguienteRecetaSugerida();
            MessageBox.Show(sugerencia ?? "No hay más sugerencias", "Receta Sugerida");
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
    }
}