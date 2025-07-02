namespace PA_GuiaConta.Forms
{
    partial class FrmAsientos
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
            dgvAsientos = new DataGridView();
            clmFecha = new DataGridViewTextBoxColumn();
            clmCuenta = new DataGridViewTextBoxColumn();
            clmParcial = new DataGridViewTextBoxColumn();
            clmDebe = new DataGridViewTextBoxColumn();
            clmHaber = new DataGridViewTextBoxColumn();
            lblConcepto = new Label();
            rtbConcepto = new RichTextBox();
            lblSumasIguales = new Label();
            txtSumas = new TextBox();
            lblSeleccionar = new Label();
            cmbEjemplos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAsientos).BeginInit();
            SuspendLayout();
            // 
            // dgvAsientos
            // 
            dgvAsientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsientos.Columns.AddRange(new DataGridViewColumn[] { clmFecha, clmCuenta, clmParcial, clmDebe, clmHaber });
            dgvAsientos.Location = new Point(12, 50);
            dgvAsientos.Name = "dgvAsientos";
            dgvAsientos.Size = new Size(699, 300);
            dgvAsientos.TabIndex = 0;
            // 
            // clmFecha
            // 
            clmFecha.HeaderText = "Fecha";
            clmFecha.Name = "clmFecha";
            // 
            // clmCuenta
            // 
            clmCuenta.HeaderText = "Cuenta";
            clmCuenta.Name = "clmCuenta";
            // 
            // clmParcial
            // 
            clmParcial.HeaderText = "Parcial";
            clmParcial.Name = "clmParcial";
            // 
            // clmDebe
            // 
            clmDebe.HeaderText = "Debe";
            clmDebe.Name = "clmDebe";
            // 
            // clmHaber
            // 
            clmHaber.HeaderText = "Haber";
            clmHaber.Name = "clmHaber";
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.Location = new Point(12, 353);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(59, 15);
            lblConcepto.TabIndex = 1;
            lblConcepto.Text = "Concepto";
            // 
            // rtbConcepto
            // 
            rtbConcepto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbConcepto.Location = new Point(12, 371);
            rtbConcepto.Name = "rtbConcepto";
            rtbConcepto.ReadOnly = true;
            rtbConcepto.Size = new Size(699, 96);
            rtbConcepto.TabIndex = 2;
            rtbConcepto.Text = "";
            // 
            // lblSumasIguales
            // 
            lblSumasIguales.AutoSize = true;
            lblSumasIguales.Location = new Point(12, 470);
            lblSumasIguales.Name = "lblSumasIguales";
            lblSumasIguales.Size = new Size(82, 15);
            lblSumasIguales.TabIndex = 3;
            lblSumasIguales.Text = "Sumas Iguales";
            // 
            // txtSumas
            // 
            txtSumas.Location = new Point(100, 462);
            txtSumas.Name = "txtSumas";
            txtSumas.ReadOnly = true;
            txtSumas.Size = new Size(611, 23);
            txtSumas.TabIndex = 4;
            txtSumas.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSeleccionar
            // 
            lblSeleccionar.AutoSize = true;
            lblSeleccionar.Location = new Point(12, 9);
            lblSeleccionar.Name = "lblSeleccionar";
            lblSeleccionar.Size = new Size(126, 15);
            lblSeleccionar.TabIndex = 5;
            lblSeleccionar.Text = "Selecciona un ejemplo";
            // 
            // cmbEjemplos
            // 
            cmbEjemplos.FormattingEnabled = true;
            cmbEjemplos.Location = new Point(144, 9);
            cmbEjemplos.Name = "cmbEjemplos";
            cmbEjemplos.Size = new Size(121, 23);
            cmbEjemplos.TabIndex = 6;
            cmbEjemplos.SelectedIndexChanged += cmbEjemplos_SelectedIndexChanged;
            // 
            // FrmAsientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 761);
            Controls.Add(cmbEjemplos);
            Controls.Add(lblSeleccionar);
            Controls.Add(txtSumas);
            Controls.Add(lblSumasIguales);
            Controls.Add(rtbConcepto);
            Controls.Add(lblConcepto);
            Controls.Add(dgvAsientos);
            Name = "FrmAsientos";
            Text = "FrmAsientos";
            Load += FrmAsientos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAsientos;
        private DataGridViewTextBoxColumn clmFecha;
        private DataGridViewTextBoxColumn clmCuenta;
        private DataGridViewTextBoxColumn clmParcial;
        private DataGridViewTextBoxColumn clmDebe;
        private DataGridViewTextBoxColumn clmHaber;
        private Label lblConcepto;
        private RichTextBox rtbConcepto;
        private Label lblSumasIguales;
        private TextBox txtSumas;
        private Label lblSeleccionar;
        private ComboBox cmbEjemplos;
    }
}