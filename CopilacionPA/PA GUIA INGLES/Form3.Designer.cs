namespace PA_GUIA_INGLES
{
    partial class FrmEjercicios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CmbTemas = new ComboBox();
            LblPregunta = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            BtnValidar = new Button();
            LblResultado = new Label();
            BtnSiguiente = new Button();
            BtnRegresar = new Button();
            SuspendLayout();
            // 
            // CmbTemas
            // 
            CmbTemas.BackColor = Color.FromArgb(255, 192, 192);
            CmbTemas.FormattingEnabled = true;
            CmbTemas.Location = new Point(23, 22);
            CmbTemas.Margin = new Padding(3, 2, 3, 2);
            CmbTemas.Name = "CmbTemas";
            CmbTemas.Size = new Size(171, 23);
            CmbTemas.TabIndex = 0;
            CmbTemas.SelectedIndexChanged += CmbTemas_SelectedIndexChanged;
            // 
            // LblPregunta
            // 
            LblPregunta.AutoSize = true;
            LblPregunta.BackColor = Color.FromArgb(255, 192, 192);
            LblPregunta.Location = new Point(23, 88);
            LblPregunta.Name = "LblPregunta";
            LblPregunta.Size = new Size(38, 15);
            LblPregunta.TabIndex = 1;
            LblPregunta.Text = "label1";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.FromArgb(255, 192, 192);
            radioButton1.Location = new Point(91, 146);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.FromArgb(255, 192, 192);
            radioButton2.Location = new Point(91, 184);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.FromArgb(255, 192, 192);
            radioButton3.Location = new Point(91, 219);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // BtnValidar
            // 
            BtnValidar.BackColor = Color.FromArgb(255, 192, 192);
            BtnValidar.Location = new Point(274, 279);
            BtnValidar.Margin = new Padding(3, 2, 3, 2);
            BtnValidar.Name = "BtnValidar";
            BtnValidar.Size = new Size(82, 22);
            BtnValidar.TabIndex = 5;
            BtnValidar.Text = "Validar";
            BtnValidar.UseVisualStyleBackColor = false;
            BtnValidar.Click += BtnValidar_Click;
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.BackColor = Color.FromArgb(255, 192, 192);
            LblResultado.Location = new Point(461, 286);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(38, 15);
            LblResultado.TabIndex = 6;
            LblResultado.Text = "label1";
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.BackColor = Color.FromArgb(255, 192, 192);
            BtnSiguiente.Location = new Point(274, 340);
            BtnSiguiente.Margin = new Padding(3, 2, 3, 2);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(82, 22);
            BtnSiguiente.TabIndex = 7;
            BtnSiguiente.Text = "Siguiente";
            BtnSiguiente.UseVisualStyleBackColor = false;
            BtnSiguiente.Click += BtnSiguiente_Click;
            // 
            // BtnRegresar
            // 
            BtnRegresar.BackColor = Color.FromArgb(255, 192, 192);
            BtnRegresar.Location = new Point(580, 362);
            BtnRegresar.Margin = new Padding(3, 2, 3, 2);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(192, 22);
            BtnRegresar.TabIndex = 8;
            BtnRegresar.Text = "Regresar al menú principal";
            BtnRegresar.UseVisualStyleBackColor = false;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // FrmEjercicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnRegresar);
            Controls.Add(BtnSiguiente);
            Controls.Add(LblResultado);
            Controls.Add(BtnValidar);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(LblPregunta);
            Controls.Add(CmbTemas);
            Name = "FrmEjercicios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicios";
            Load += FrmEjercicios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbTemas;
        private Label LblPregunta;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button BtnValidar;
        private Label LblResultado;
        private Button BtnSiguiente;
        private Button BtnRegresar;
    }
}