namespace PA_GUIA_INGLES
{
    partial class FrmTemas
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
            LblTemas = new Label();
            BtnRegresar = new Button();
            panel1 = new Panel();
            LblResultados = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CmbTemas
            // 
            CmbTemas.BackColor = Color.FromArgb(255, 192, 255);
            CmbTemas.FormattingEnabled = true;
            CmbTemas.Location = new Point(94, 25);
            CmbTemas.Name = "CmbTemas";
            CmbTemas.Size = new Size(325, 23);
            CmbTemas.TabIndex = 0;
            CmbTemas.SelectedIndexChanged += CmbTemas_SelectedIndexChanged;
            // 
            // LblTemas
            // 
            LblTemas.AutoSize = true;
            LblTemas.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTemas.Location = new Point(12, 25);
            LblTemas.Name = "LblTemas";
            LblTemas.Size = new Size(66, 18);
            LblTemas.TabIndex = 1;
            LblTemas.Text = "TEMAS:";
            // 
            // BtnRegresar
            // 
            BtnRegresar.Location = new Point(666, 528);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(189, 23);
            BtnRegresar.TabIndex = 3;
            BtnRegresar.Text = "Regresar al menú principal";
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(LblResultados);
            panel1.Location = new Point(12, 75);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 446);
            panel1.TabIndex = 4;
            // 
            // LblResultados
            // 
            LblResultados.AutoSize = true;
            LblResultados.Font = new Font("Baskerville Old Face", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LblResultados.Location = new Point(32, 33);
            LblResultados.MaximumSize = new Size(830, 0);
            LblResultados.Name = "LblResultados";
            LblResultados.Size = new Size(39, 16);
            LblResultados.TabIndex = 0;
            LblResultados.Text = "label1";
            // 
            // FrmTemas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(865, 561);
            Controls.Add(panel1);
            Controls.Add(BtnRegresar);
            Controls.Add(LblTemas);
            Controls.Add(CmbTemas);
            Name = "FrmTemas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Temas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbTemas;
        private Label LblTemas;
        private Button BtnRegresar;
        private Panel panel1;
        private Label LblResultados;
    }
}