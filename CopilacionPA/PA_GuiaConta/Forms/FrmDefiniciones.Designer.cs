namespace PA_GuiaConta.Forms
{
    partial class FrmDefiniciones
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
            cmbCategoria = new ComboBox();
            rtbDefinicion = new RichTextBox();
            lblDefinicion = new Label();
            SuspendLayout();
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(210, 40);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 0;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // rtbDefinicion
            // 
            rtbDefinicion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbDefinicion.Location = new Point(41, 69);
            rtbDefinicion.Name = "rtbDefinicion";
            rtbDefinicion.ReadOnly = true;
            rtbDefinicion.Size = new Size(500, 224);
            rtbDefinicion.TabIndex = 1;
            rtbDefinicion.Text = "";
            // 
            // lblDefinicion
            // 
            lblDefinicion.AutoSize = true;
            lblDefinicion.Location = new Point(58, 43);
            lblDefinicion.Name = "lblDefinicion";
            lblDefinicion.Size = new Size(123, 15);
            lblDefinicion.TabIndex = 2;
            lblDefinicion.Text = "Selecciona Definicion:";
            // 
            // FrmDefiniciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 307);
            Controls.Add(lblDefinicion);
            Controls.Add(rtbDefinicion);
            Controls.Add(cmbCategoria);
            Name = "FrmDefiniciones";
            Text = "FrmDefiniciones";
            Load += FrmDefiniciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategoria;
        private RichTextBox rtbDefinicion;
        private Label lblDefinicion;
    }
}