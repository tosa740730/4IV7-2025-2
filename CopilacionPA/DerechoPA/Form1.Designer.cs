namespace DerechoPA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCalcular = new Button();
            BtnLimpiar = new Button();
            BtnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            lblGuia = new Label();
            lblExamen = new Label();
            lblLibros = new Label();
            lblContrato = new Label();
            lblPlanetario = new Label();
            lblResultado = new Label();
            txtGuia = new TextBox();
            txtExamen = new TextBox();
            txtLibros = new TextBox();
            txtContrato = new TextBox();
            txtPlanetario = new TextBox();
            SuspendLayout();
            // 
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(107, 195);
            BtnCalcular.Margin = new Padding(2, 2, 2, 2);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(88, 30);
            BtnCalcular.TabIndex = 0;
            BtnCalcular.Text = "CALCULAR";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(224, 195);
            BtnLimpiar.Margin = new Padding(2, 2, 2, 2);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(88, 30);
            BtnLimpiar.TabIndex = 1;
            BtnLimpiar.Text = "LIMPIAR";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(341, 195);
            BtnSalir.Margin = new Padding(2, 2, 2, 2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(88, 30);
            BtnSalir.TabIndex = 2;
            BtnSalir.Text = "SALIR";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 3;
            label1.Text = "Calculadora de Calificaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(233, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingresa las calificaciones: (Examen sobre 5)";
            // 
            // lblGuia
            // 
            lblGuia.AutoSize = true;
            lblGuia.Location = new Point(42, 67);
            lblGuia.Margin = new Padding(2, 0, 2, 0);
            lblGuia.Name = "lblGuia";
            lblGuia.Size = new Size(125, 15);
            lblGuia.TabIndex = 5;
            lblGuia.Text = "Guia Completa (10%) :";
            // 
            // lblExamen
            // 
            lblExamen.AutoSize = true;
            lblExamen.Location = new Point(42, 90);
            lblExamen.Margin = new Padding(2, 0, 2, 0);
            lblExamen.Name = "lblExamen";
            lblExamen.Size = new Size(88, 15);
            lblExamen.TabIndex = 6;
            lblExamen.Text = "Examen (50%) :";
            // 
            // lblLibros
            // 
            lblLibros.AutoSize = true;
            lblLibros.Location = new Point(42, 112);
            lblLibros.Margin = new Padding(2, 0, 2, 0);
            lblLibros.Name = "lblLibros";
            lblLibros.Size = new Size(78, 15);
            lblLibros.TabIndex = 7;
            lblLibros.Text = "Libros (10%) :";
            // 
            // lblContrato
            // 
            lblContrato.AutoSize = true;
            lblContrato.Location = new Point(42, 134);
            lblContrato.Margin = new Padding(2, 0, 2, 0);
            lblContrato.Name = "lblContrato";
            lblContrato.Size = new Size(93, 15);
            lblContrato.TabIndex = 8;
            lblContrato.Text = "Contrato (20%) :";
            // 
            // lblPlanetario
            // 
            lblPlanetario.AutoSize = true;
            lblPlanetario.Location = new Point(42, 156);
            lblPlanetario.Margin = new Padding(2, 0, 2, 0);
            lblPlanetario.Name = "lblPlanetario";
            lblPlanetario.Size = new Size(99, 15);
            lblPlanetario.TabIndex = 9;
            lblPlanetario.Text = "Planetario (10%) :";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Location = new Point(196, 240);
            lblResultado.Margin = new Padding(2, 0, 2, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(139, 17);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "\"Promedio final: -- / 10\";\n";
            // 
            // txtGuia
            // 
            txtGuia.AcceptsReturn = true;
            txtGuia.Location = new Point(196, 67);
            txtGuia.Margin = new Padding(2, 2, 2, 2);
            txtGuia.Name = "txtGuia";
            txtGuia.Size = new Size(133, 23);
            txtGuia.TabIndex = 11;
            // 
            // txtExamen
            // 
            txtExamen.AcceptsReturn = true;
            txtExamen.Location = new Point(196, 89);
            txtExamen.Margin = new Padding(2, 2, 2, 2);
            txtExamen.Name = "txtExamen";
            txtExamen.Size = new Size(133, 23);
            txtExamen.TabIndex = 12;
            // 
            // txtLibros
            // 
            txtLibros.AcceptsReturn = true;
            txtLibros.Location = new Point(196, 112);
            txtLibros.Margin = new Padding(2, 2, 2, 2);
            txtLibros.Name = "txtLibros";
            txtLibros.Size = new Size(133, 23);
            txtLibros.TabIndex = 13;
            // 
            // txtContrato
            // 
            txtContrato.AcceptsReturn = true;
            txtContrato.Location = new Point(196, 134);
            txtContrato.Margin = new Padding(2, 2, 2, 2);
            txtContrato.Name = "txtContrato";
            txtContrato.Size = new Size(133, 23);
            txtContrato.TabIndex = 14;
            // 
            // txtPlanetario
            // 
            txtPlanetario.AcceptsReturn = true;
            txtPlanetario.Location = new Point(196, 156);
            txtPlanetario.Margin = new Padding(2, 2, 2, 2);
            txtPlanetario.Name = "txtPlanetario";
            txtPlanetario.Size = new Size(133, 23);
            txtPlanetario.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(txtPlanetario);
            Controls.Add(txtContrato);
            Controls.Add(txtLibros);
            Controls.Add(txtExamen);
            Controls.Add(txtGuia);
            Controls.Add(lblResultado);
            Controls.Add(lblPlanetario);
            Controls.Add(lblContrato);
            Controls.Add(lblLibros);
            Controls.Add(lblExamen);
            Controls.Add(lblGuia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSalir);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnCalcular);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        // Add the missing event handler method for btnLimpiar_Click in the code-behind file.  
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Clear all textboxes  
            txtGuia.Text = string.Empty;
            txtExamen.Text = string.Empty;
            txtLibros.Text = string.Empty;
            txtContrato.Text = string.Empty;
            txtPlanetario.Text = string.Empty;

            // Reset the result label  
            lblResultado.Text = "Promedio final: -- / 10";
        }

        #endregion

        private Button BtnCalcular;
        private Button BtnLimpiar;
        private Button BtnSalir;
        private Label label1;
        private Label label2;
        private Label lblGuia;
        private Label lblExamen;
        private Label lblLibros;
        private Label lblContrato;
        private Label lblPlanetario;
        private Label lblResultado;
        private TextBox txtGuia;
        private TextBox txtExamen;
        private TextBox txtLibros;
        private TextBox txtContrato;
        private TextBox txtPlanetario;
    }
}
