namespace PA_TELE
{
    partial class Introducción
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
            BtnContinuar = new Button();
            rtbIntroduccion = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnContinuar
            // 
            BtnContinuar.BackColor = SystemColors.MenuBar;
            BtnContinuar.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnContinuar.Location = new Point(412, 532);
            BtnContinuar.Name = "BtnContinuar";
            BtnContinuar.Size = new Size(150, 23);
            BtnContinuar.TabIndex = 0;
            BtnContinuar.Text = "Continuar";
            BtnContinuar.UseVisualStyleBackColor = false;
            BtnContinuar.Click += BtnContinuar_Click;
            // 
            // rtbIntroduccion
            // 
            rtbIntroduccion.BackColor = SystemColors.Menu;
            rtbIntroduccion.BorderStyle = BorderStyle.FixedSingle;
            rtbIntroduccion.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rtbIntroduccion.Location = new Point(12, 42);
            rtbIntroduccion.Name = "rtbIntroduccion";
            rtbIntroduccion.ReadOnly = true;
            rtbIntroduccion.ScrollBars = RichTextBoxScrollBars.Horizontal;
            rtbIntroduccion.Size = new Size(930, 463);
            rtbIntroduccion.TabIndex = 1;
            rtbIntroduccion.Text = "";
            rtbIntroduccion.TextChanged += rtbIntroduccion_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(299, 23);
            label1.TabIndex = 2;
            label1.Text = "Introduccón al contenido de esta Guía de Estudio ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Introducción
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(954, 600);
            Controls.Add(label1);
            Controls.Add(rtbIntroduccion);
            Controls.Add(BtnContinuar);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "Introducción";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Introducción de esta guía";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnContinuar;
        private RichTextBox rtbIntroduccion;
        private Label label1;
    }
}