namespace CalcDifer
{
    partial class FrmCalcDifer
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
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelNavegacion = new Panel();
            panelSubMenu = new Panel();
            btnEjemplo = new Button();
            btnTeoria = new Button();
            btnUnidad7 = new Button();
            btnUnidad6 = new Button();
            btnUnidad5 = new Button();
            btnUnidad4 = new Button();
            btnUnidad2 = new Button();
            btnUnidad3 = new Button();
            btnUnidad1 = new Button();
            panelContenido = new Panel();
            richTextBoxContenido = new RichTextBox();
            panelHeader.SuspendLayout();
            panelNavegacion.SuspendLayout();
            panelSubMenu.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(64, 0, 0);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1184, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(320, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(511, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GUÍA DE CÁLCULO DIFERENCIAL - CECYT 13";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelNavegacion
            // 
            panelNavegacion.BackColor = Color.FromArgb(37, 37, 38);
            panelNavegacion.Controls.Add(panelSubMenu);
            panelNavegacion.Controls.Add(btnUnidad7);
            panelNavegacion.Controls.Add(btnUnidad6);
            panelNavegacion.Controls.Add(btnUnidad5);
            panelNavegacion.Controls.Add(btnUnidad4);
            panelNavegacion.Controls.Add(btnUnidad2);
            panelNavegacion.Controls.Add(btnUnidad3);
            panelNavegacion.Controls.Add(btnUnidad1);
            panelNavegacion.Dock = DockStyle.Left;
            panelNavegacion.Location = new Point(0, 80);
            panelNavegacion.Name = "panelNavegacion";
            panelNavegacion.Padding = new Padding(10);
            panelNavegacion.Size = new Size(320, 631);
            panelNavegacion.TabIndex = 1;
            // 
            // panelSubMenu
            // 
            panelSubMenu.BackColor = Color.FromArgb(50, 50, 50);
            panelSubMenu.Controls.Add(btnEjemplo);
            panelSubMenu.Controls.Add(btnTeoria);
            panelSubMenu.Location = new Point(10, 430);
            panelSubMenu.Name = "panelSubMenu";
            panelSubMenu.Size = new Size(300, 80);
            panelSubMenu.TabIndex = 7;
            panelSubMenu.Visible = false;
            // 
            // btnEjemplo
            // 
            btnEjemplo.BackColor = Color.FromArgb(204, 122, 0);
            btnEjemplo.Cursor = Cursors.Hand;
            btnEjemplo.FlatStyle = FlatStyle.Flat;
            btnEjemplo.ForeColor = Color.White;
            btnEjemplo.Location = new Point(160, 10);
            btnEjemplo.Name = "btnEjemplo";
            btnEjemplo.Size = new Size(140, 35);
            btnEjemplo.TabIndex = 1;
            btnEjemplo.Text = "Ejemplo";
            btnEjemplo.UseVisualStyleBackColor = false;
            btnEjemplo.Click += btnEjemplo_Click;
            // 
            // btnTeoria
            // 
            btnTeoria.BackColor = Color.FromArgb(0, 153, 76);
            btnTeoria.Cursor = Cursors.Hand;
            btnTeoria.FlatStyle = FlatStyle.Flat;
            btnTeoria.ForeColor = Color.White;
            btnTeoria.Location = new Point(10, 10);
            btnTeoria.Name = "btnTeoria";
            btnTeoria.Size = new Size(140, 35);
            btnTeoria.TabIndex = 0;
            btnTeoria.Text = "Teoría";
            btnTeoria.UseVisualStyleBackColor = false;
            btnTeoria.Click += btnTeoria_Click;
            // 
            // btnUnidad7
            // 
            btnUnidad7.BackColor = Color.FromArgb(60, 60, 60);
            btnUnidad7.Cursor = Cursors.Hand;
            btnUnidad7.FlatStyle = FlatStyle.Flat;
            btnUnidad7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUnidad7.ForeColor = Color.Gainsboro;
            btnUnidad7.Location = new Point(10, 370);
            btnUnidad7.Name = "btnUnidad7";
            btnUnidad7.Size = new Size(300, 50);
            btnUnidad7.TabIndex = 6;
            btnUnidad7.Text = "UNIDAD 7: Diferenciales";
            btnUnidad7.TextAlign = ContentAlignment.MiddleLeft;
            btnUnidad7.UseVisualStyleBackColor = false;
            btnUnidad7.Click += btnUnidad7_Click;
            // 
            // btnUnidad6
            // 
            btnUnidad6.BackColor = Color.FromArgb(60, 60, 60);
            btnUnidad6.Cursor = Cursors.Hand;
            btnUnidad6.FlatStyle = FlatStyle.Flat;
            btnUnidad6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUnidad6.ForeColor = Color.Gainsboro;
            btnUnidad6.Location = new Point(10, 310);
            btnUnidad6.Name = "btnUnidad6";
            btnUnidad6.Size = new Size(300, 50);
            btnUnidad6.TabIndex = 5;
            btnUnidad6.Text = "UNIDAD 6: Derivadas Trigonométricas";
            btnUnidad6.TextAlign = ContentAlignment.MiddleLeft;
            btnUnidad6.UseVisualStyleBackColor = false;
            btnUnidad6.Click += btnUnidad6_Click;
            // 
            // btnUnidad5
            // 
            btnUnidad5.BackColor = Color.FromArgb(60, 60, 60);
            btnUnidad5.Cursor = Cursors.Hand;
            btnUnidad5.FlatStyle = FlatStyle.Flat;
            btnUnidad5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUnidad5.ForeColor = Color.Gainsboro;
            btnUnidad5.Location = new Point(10, 250);
            btnUnidad5.Name = "btnUnidad5";
            btnUnidad5.Size = new Size(300, 50);
            btnUnidad5.TabIndex = 4;
            btnUnidad5.Text = "UNIDAD 5: Derivadas Exponenciales";
            btnUnidad5.TextAlign = ContentAlignment.MiddleLeft;
            btnUnidad5.UseVisualStyleBackColor = false;
            btnUnidad5.Click += btnUnidad5_Click;
            // 
            // btnUnidad4
            // 
            btnUnidad4.BackColor = Color.FromArgb(60, 60, 60);
            btnUnidad4.Cursor = Cursors.Hand;
            btnUnidad4.FlatStyle = FlatStyle.Flat;
            btnUnidad4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUnidad4.ForeColor = Color.Gainsboro;
            btnUnidad4.Location = new Point(10, 190);
            btnUnidad4.Name = "btnUnidad4";
            btnUnidad4.Size = new Size(300, 50);
            btnUnidad4.TabIndex = 3;
            btnUnidad4.Text = "UNIDAD 4: Aplicaciones (Máx/Mín)";
            btnUnidad4.TextAlign = ContentAlignment.MiddleLeft;
            btnUnidad4.UseVisualStyleBackColor = false;
            btnUnidad4.Click += btnUnidad4_Click;
            // 
            // btnUnidad2
            // 
            btnUnidad2.BackColor = Color.FromArgb(60, 60, 60);
            btnUnidad2.Cursor = Cursors.Hand;
            btnUnidad2.FlatStyle = FlatStyle.Flat;
            btnUnidad2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUnidad2.ForeColor = Color.Gainsboro;
            btnUnidad2.Location = new Point(10, 70);
            btnUnidad2.Name = "btnUnidad2";
            btnUnidad2.Size = new Size(300, 50);
            btnUnidad2.TabIndex = 2;
            btnUnidad2.Text = "UNIDAD 2: La Derivada (4 Pasos)";
            btnUnidad2.TextAlign = ContentAlignment.MiddleLeft;
            btnUnidad2.UseVisualStyleBackColor = false;
            btnUnidad2.Click += button2_Click;
            // 
            // btnUnidad3
            // 
            btnUnidad3.BackColor = Color.FromArgb(60, 60, 60);
            btnUnidad3.Cursor = Cursors.Hand;
            btnUnidad3.FlatStyle = FlatStyle.Flat;
            btnUnidad3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUnidad3.ForeColor = Color.Gainsboro;
            btnUnidad3.Location = new Point(10, 130);
            btnUnidad3.Name = "btnUnidad3";
            btnUnidad3.Size = new Size(300, 50);
            btnUnidad3.TabIndex = 1;
            btnUnidad3.Text = "UNIDAD 3: Derivadas Algebraicas";
            btnUnidad3.TextAlign = ContentAlignment.MiddleLeft;
            btnUnidad3.UseVisualStyleBackColor = false;
            btnUnidad3.Click += btnUnidad3_Click;
            // 
            // btnUnidad1
            // 
            btnUnidad1.BackColor = Color.FromArgb(60, 60, 60);
            btnUnidad1.Cursor = Cursors.Hand;
            btnUnidad1.FlatStyle = FlatStyle.Flat;
            btnUnidad1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUnidad1.ForeColor = Color.Gainsboro;
            btnUnidad1.Location = new Point(10, 10);
            btnUnidad1.Name = "btnUnidad1";
            btnUnidad1.Size = new Size(300, 50);
            btnUnidad1.TabIndex = 0;
            btnUnidad1.Text = "UNIDAD 1: Funciones y Límites";
            btnUnidad1.TextAlign = ContentAlignment.MiddleLeft;
            btnUnidad1.UseVisualStyleBackColor = false;
            btnUnidad1.Click += btnUnidad1_Click;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(30, 30, 30);
            panelContenido.Controls.Add(richTextBoxContenido);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(320, 80);
            panelContenido.Name = "panelContenido";
            panelContenido.Padding = new Padding(20);
            panelContenido.Size = new Size(864, 631);
            panelContenido.TabIndex = 2;
            // 
            // richTextBoxContenido
            // 
            richTextBoxContenido.BackColor = Color.FromArgb(30, 30, 30);
            richTextBoxContenido.BorderStyle = BorderStyle.None;
            richTextBoxContenido.Dock = DockStyle.Fill;
            richTextBoxContenido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxContenido.ForeColor = Color.Gainsboro;
            richTextBoxContenido.Location = new Point(20, 20);
            richTextBoxContenido.Name = "richTextBoxContenido";
            richTextBoxContenido.ReadOnly = true;
            richTextBoxContenido.Size = new Size(824, 591);
            richTextBoxContenido.TabIndex = 0;
            richTextBoxContenido.Text = "";
            // 
            // FrmCalcDifer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1184, 711);
            Controls.Add(panelContenido);
            Controls.Add(panelNavegacion);
            Controls.Add(panelHeader);
            MinimumSize = new Size(1000, 700);
            Name = "FrmCalcDifer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guía: Cálculo Diferencial";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavegacion.ResumeLayout(false);
            panelSubMenu.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelNavegacion;
        private Panel panelContenido;
        private RichTextBox richTextBoxContenido;
        private Button btnUnidad7;
        private Button btnUnidad6;
        private Button btnUnidad5;
        private Button btnUnidad4;
        private Button btnUnidad2;
        private Button btnUnidad3;
        private Button btnUnidad1;
        private Panel panelSubMenu;
        private Button btnEjemplo;
        private Button btnTeoria;
    }
}
