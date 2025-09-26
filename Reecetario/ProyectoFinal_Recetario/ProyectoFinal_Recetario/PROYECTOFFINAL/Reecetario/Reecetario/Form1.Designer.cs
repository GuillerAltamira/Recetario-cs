namespace RecetarioInteligente
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtIngrediente = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstIngredientes = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstRecetas = new System.Windows.Forms.ListBox();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.btnRotar = new System.Windows.Forms.Button();
            this.lblIngredientePrincipal = new System.Windows.Forms.Label();
            this.btnSugerencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIngrediente
            // 
            this.txtIngrediente.Location = new System.Drawing.Point(16, 15);
            this.txtIngrediente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIngrediente.Name = "txtIngrediente";
            this.txtIngrediente.Size = new System.Drawing.Size(265, 22);
            this.txtIngrediente.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(291, 12);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstIngredientes
            // 
            this.lstIngredientes.FormattingEnabled = true;
            this.lstIngredientes.ItemHeight = 16;
            this.lstIngredientes.Location = new System.Drawing.Point(16, 47);
            this.lstIngredientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstIngredientes.Name = "lstIngredientes";
            this.lstIngredientes.Size = new System.Drawing.Size(265, 196);
            this.lstIngredientes.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(16, 251);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(267, 28);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar Recetas";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstRecetas
            // 
            this.lstRecetas.FormattingEnabled = true;
            this.lstRecetas.ItemHeight = 16;
            this.lstRecetas.Location = new System.Drawing.Point(291, 47);
            this.lstRecetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstRecetas.Name = "lstRecetas";
            this.lstRecetas.Size = new System.Drawing.Size(332, 196);
            this.lstRecetas.TabIndex = 4;
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 16;
            this.lstHistorial.Location = new System.Drawing.Point(632, 47);
            this.lstHistorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(265, 196);
            this.lstHistorial.TabIndex = 5;
            // 
            // btnRotar
            // 
            this.btnRotar.Location = new System.Drawing.Point(632, 251);
            this.btnRotar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(267, 28);
            this.btnRotar.TabIndex = 6;
            this.btnRotar.Text = "Rotar Ingrediente Principal";
            this.btnRotar.UseVisualStyleBackColor = true;
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // lblIngredientePrincipal
            // 
            this.lblIngredientePrincipal.AutoSize = true;
            this.lblIngredientePrincipal.Location = new System.Drawing.Point(632, 283);
            this.lblIngredientePrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredientePrincipal.Name = "lblIngredientePrincipal";
            this.lblIngredientePrincipal.Size = new System.Drawing.Size(57, 16);
            this.lblIngredientePrincipal.TabIndex = 7;
            this.lblIngredientePrincipal.Text = "Ninguno";
            // 
            // btnSugerencia
            // 
            this.btnSugerencia.Location = new System.Drawing.Point(291, 251);
            this.btnSugerencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSugerencia.Name = "btnSugerencia";
            this.btnSugerencia.Size = new System.Drawing.Size(333, 28);
            this.btnSugerencia.TabIndex = 8;
            this.btnSugerencia.Text = "Siguiente Sugerencia";
            this.btnSugerencia.UseVisualStyleBackColor = true;
            this.btnSugerencia.Click += new System.EventHandler(this.btnSugerencia_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(915, 321);
            this.Controls.Add(this.btnSugerencia);
            this.Controls.Add(this.lblIngredientePrincipal);
            this.Controls.Add(this.btnRotar);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.lstRecetas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lstIngredientes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIngrediente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Recetario Inteligente";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtIngrediente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstIngredientes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lstRecetas;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Button btnRotar;
        private System.Windows.Forms.Label lblIngredientePrincipal;
        private System.Windows.Forms.Button btnSugerencia;
    }
}

