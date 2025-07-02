namespace PA_TELE
{
    partial class Bienvenida
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
            BtnIniciar = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // BtnIniciar
            // 
            BtnIniciar.BackColor = Color.Teal;
            BtnIniciar.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnIniciar.Location = new Point(376, 169);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(95, 23);
            BtnIniciar.TabIndex = 1;
            BtnIniciar.Text = "INICIAR GUÍA";
            BtnIniciar.UseVisualStyleBackColor = false;
            BtnIniciar.Click += BtnIniciar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(334, 225);
            button1.Name = "button1";
            button1.Size = new Size(182, 23);
            button1.TabIndex = 2;
            button1.Text = "Cerrar Guía de Teleinformática";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.Teal;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(50, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(743, 33);
            textBox1.TabIndex = 20;
            textBox1.Tag = "";
            textBox1.Text = "Proyecto Aula \r\n\"GUÍA DE ESTUDIO DE TELEINFORMÁTICA\"\r\nGrupo -4Iv7";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = Properties.Resources.imagen_fondo_mismo_tono;
            ClientSize = new Size(838, 454);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(BtnIniciar);
            Name = "Bienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "20";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnIniciar;
        private Button button1;
        private TextBox textBox1;
    }
}
