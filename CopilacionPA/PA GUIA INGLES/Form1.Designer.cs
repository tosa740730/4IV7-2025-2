namespace PA_GUIA_INGLES
{
    partial class FrmInicio
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
            LblTitulo = new Label();
            BtnSalir = new Button();
            BtnVerTemas = new Button();
            BtnEjercicios = new Button();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.BackColor = Color.PaleGreen;
            LblTitulo.Font = new Font("Baskerville Old Face", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            LblTitulo.Location = new Point(291, 109);
            LblTitulo.Margin = new Padding(4, 0, 4, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(537, 54);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Guía de estudio Inglés IV";
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(255, 192, 192);
            BtnSalir.Location = new Point(477, 465);
            BtnSalir.Margin = new Padding(4);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(234, 56);
            BtnSalir.TabIndex = 1;
            BtnSalir.Text = "Salir de la guía";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnVerTemas
            // 
            BtnVerTemas.BackColor = Color.FromArgb(255, 192, 192);
            BtnVerTemas.Location = new Point(157, 283);
            BtnVerTemas.Margin = new Padding(4);
            BtnVerTemas.Name = "BtnVerTemas";
            BtnVerTemas.Size = new Size(234, 56);
            BtnVerTemas.TabIndex = 2;
            BtnVerTemas.Text = "Ver temas";
            BtnVerTemas.UseVisualStyleBackColor = false;
            BtnVerTemas.Click += BtnVerTemas_Click;
            // 
            // BtnEjercicios
            // 
            BtnEjercicios.BackColor = Color.FromArgb(255, 192, 192);
            BtnEjercicios.Location = new Point(801, 283);
            BtnEjercicios.Margin = new Padding(4);
            BtnEjercicios.Name = "BtnEjercicios";
            BtnEjercicios.Size = new Size(196, 56);
            BtnEjercicios.TabIndex = 3;
            BtnEjercicios.Text = "Hacer ejercicios";
            BtnEjercicios.UseVisualStyleBackColor = false;
            BtnEjercicios.Click += BtnEjercicios_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1232, 710);
            Controls.Add(BtnEjercicios);
            Controls.Add(BtnVerTemas);
            Controls.Add(BtnSalir);
            Controls.Add(LblTitulo);
            Font = new Font("Baskerville Old Face", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private Button BtnSalir;
        private Button BtnVerTemas;
        private Button BtnEjercicios;
    }
}
