namespace PA_GuiaConta.Forms
{
    partial class FrmCuentasT
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
            flpT = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            cmbCuentas = new ComboBox();
            lblSeleccionT = new Label();
            flpT.SuspendLayout();
            SuspendLayout();
            // 
            // flpT
            // 
            flpT.AutoScroll = true;
            flpT.Controls.Add(groupBox1);
            flpT.Location = new Point(2, 41);
            flpT.Name = "flpT";
            flpT.Size = new Size(316, 267);
            flpT.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cmbCuentas
            // 
            cmbCuentas.FormattingEnabled = true;
            cmbCuentas.Location = new Point(130, 12);
            cmbCuentas.Name = "cmbCuentas";
            cmbCuentas.Size = new Size(133, 23);
            cmbCuentas.TabIndex = 1;
            cmbCuentas.SelectedIndexChanged += cmbCuentas_SelectedIndexChanged;
            // 
            // lblSeleccionT
            // 
            lblSeleccionT.AutoSize = true;
            lblSeleccionT.Location = new Point(12, 15);
            lblSeleccionT.Name = "lblSeleccionT";
            lblSeleccionT.Size = new Size(112, 15);
            lblSeleccionT.TabIndex = 2;
            lblSeleccionT.Text = "Selecciona ejemplo:";
            lblSeleccionT.Click += label1_Click;
            // 
            // FrmCuentasT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 348);
            Controls.Add(lblSeleccionT);
            Controls.Add(cmbCuentas);
            Controls.Add(flpT);
            Name = "FrmCuentasT";
            Text = "FrmCuentasT";
            Load += FrmCuentasT_Load;
            flpT.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpT;
        private GroupBox groupBox1;
        private ComboBox cmbCuentas;
        private Label lblSeleccionT;
    }
}