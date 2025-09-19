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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtIngrediente = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstIngredientes = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstRecetas = new System.Windows.Forms.ListBox();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.btnRotar = new System.Windows.Forms.Button();
            this.lblIngredientePrincipal = new System.Windows.Forms.Label();
            this.btnSugerencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lstFaltante = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIngrediente
            // 
            this.txtIngrediente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIngrediente.Location = new System.Drawing.Point(13, 68);
            this.txtIngrediente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngrediente.Name = "txtIngrediente";
            this.txtIngrediente.Size = new System.Drawing.Size(265, 22);
            this.txtIngrediente.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(100, 144);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstIngredientes
            // 
            this.lstIngredientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIngredientes.FormattingEnabled = true;
            this.lstIngredientes.ItemHeight = 16;
            this.lstIngredientes.Location = new System.Drawing.Point(55, 329);
            this.lstIngredientes.Margin = new System.Windows.Forms.Padding(4);
            this.lstIngredientes.Name = "lstIngredientes";
            this.lstIngredientes.Size = new System.Drawing.Size(253, 180);
            this.lstIngredientes.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(55, 542);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(267, 28);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar Recetas";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstRecetas
            // 
            this.lstRecetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecetas.FormattingEnabled = true;
            this.lstRecetas.ItemHeight = 16;
            this.lstRecetas.Location = new System.Drawing.Point(437, 329);
            this.lstRecetas.Margin = new System.Windows.Forms.Padding(4);
            this.lstRecetas.Name = "lstRecetas";
            this.lstRecetas.Size = new System.Drawing.Size(637, 180);
            this.lstRecetas.TabIndex = 4;
            // 
            // lstHistorial
            // 
            this.lstHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 16;
            this.lstHistorial.Location = new System.Drawing.Point(1191, 169);
            this.lstHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(237, 52);
            this.lstHistorial.TabIndex = 5;
            // 
            // btnRotar
            // 
            this.btnRotar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRotar.Location = new System.Drawing.Point(1391, 44);
            this.btnRotar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(24, 10);
            this.btnRotar.TabIndex = 6;
            this.btnRotar.Text = "Rotar Ingrediente Principal";
            this.btnRotar.UseVisualStyleBackColor = false;
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // lblIngredientePrincipal
            // 
            this.lblIngredientePrincipal.AutoSize = true;
            this.lblIngredientePrincipal.Location = new System.Drawing.Point(363, 450);
            this.lblIngredientePrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredientePrincipal.Name = "lblIngredientePrincipal";
            this.lblIngredientePrincipal.Size = new System.Drawing.Size(0, 16);
            this.lblIngredientePrincipal.TabIndex = 7;
            // 
            // btnSugerencia
            // 
            this.btnSugerencia.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSugerencia.Location = new System.Drawing.Point(638, 542);
            this.btnSugerencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnSugerencia.Name = "btnSugerencia";
            this.btnSugerencia.Size = new System.Drawing.Size(333, 28);
            this.btnSugerencia.TabIndex = 8;
            this.btnSugerencia.Text = "Siguiente Sugerencia";
            this.btnSugerencia.UseVisualStyleBackColor = false;
            this.btnSugerencia.Click += new System.EventHandler(this.btnSugerencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Ravie", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(558, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "RECETARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(598, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "INTELIGENTE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(51, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingrese su Ingrediente\r\n";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(1275, 533);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 46);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "🧹 Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lstFaltante
            // 
            this.lstFaltante.FormattingEnabled = true;
            this.lstFaltante.ItemHeight = 16;
            this.lstFaltante.Location = new System.Drawing.Point(1191, 329);
            this.lstFaltante.Name = "lstFaltante";
            this.lstFaltante.Size = new System.Drawing.Size(261, 196);
            this.lstFaltante.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1185, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "TE FALTAN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1185, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "BUSCASTE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1490, 635);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstFaltante);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSugerencia);
            this.Controls.Add(this.lblIngredientePrincipal);
            this.Controls.Add(this.btnRotar);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.lstRecetas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lstIngredientes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIngrediente);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "RecetarioInteligente";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lstFaltante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

