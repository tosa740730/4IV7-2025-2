namespace PA_TELE
{
    partial class Agradecimientos
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
            Lbl2 = new Label();
            label1 = new Label();
            Regreso = new Button();
            SuspendLayout();
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Lbl2.Location = new Point(171, 165);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(455, 180);
            Lbl2.TabIndex = 24;
            Lbl2.Text = "Este programa fue elaborado por el Grupo : 4IV7 .\r\nPor los integrantes :\r\n >Montes García Iván Emiliano \r\n >Jimenéz Acosta Juan Pablo\r\n >Guzmán Torres Arturo\r\n >Lopez Cabello Stybenth";
            Lbl2.TextAlign = ContentAlignment.MiddleCenter;
            Lbl2.Click += Lbl2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 32);
            label1.Name = "label1";
            label1.Size = new Size(534, 133);
            label1.TabIndex = 25;
            label1.Text = "Muchas Gracias por su atención.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Regreso
            // 
            Regreso.BackColor = SystemColors.Menu;
            Regreso.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Regreso.Location = new Point(332, 391);
            Regreso.Name = "Regreso";
            Regreso.Size = new Size(149, 23);
            Regreso.TabIndex = 26;
            Regreso.Text = "Regresar  a los temas";
            Regreso.UseVisualStyleBackColor = false;
            Regreso.Click += Regreso_Click;
            // 
            // Agradecimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(Regreso);
            Controls.Add(label1);
            Controls.Add(Lbl2);
            Name = "Agradecimientos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Agradecimientos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Lbl2;
        private Label label1;
        private Button Regreso;
    }
}