namespace PA_GuiaConta.Forms
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            lblTituloMenu = new Label();
            btnDefiniciones = new Button();
            btnAsientos = new Button();
            btnCuentasT = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTituloMenu
            // 
            lblTituloMenu.AutoSize = true;
            lblTituloMenu.BackColor = Color.Transparent;
            lblTituloMenu.BorderStyle = BorderStyle.FixedSingle;
            lblTituloMenu.Font = new Font("Broadway", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloMenu.Location = new Point(69, 22);
            lblTituloMenu.Name = "lblTituloMenu";
            lblTituloMenu.Size = new Size(219, 26);
            lblTituloMenu.TabIndex = 0;
            lblTituloMenu.Text = "Menu De Opciones";
            lblTituloMenu.Click += label1_Click;
            // 
            // btnDefiniciones
            // 
            btnDefiniciones.Location = new Point(118, 107);
            btnDefiniciones.Name = "btnDefiniciones";
            btnDefiniciones.Size = new Size(108, 23);
            btnDefiniciones.TabIndex = 1;
            btnDefiniciones.Text = "Definiciones";
            btnDefiniciones.UseVisualStyleBackColor = true;
            btnDefiniciones.Click += btnDefiniciones_Click;
            // 
            // btnAsientos
            // 
            btnAsientos.Location = new Point(118, 154);
            btnAsientos.Name = "btnAsientos";
            btnAsientos.Size = new Size(108, 23);
            btnAsientos.TabIndex = 2;
            btnAsientos.Text = "Asientos";
            btnAsientos.UseVisualStyleBackColor = true;
            btnAsientos.Click += btnAsientos_Click;
            // 
            // btnCuentasT
            // 
            btnCuentasT.Location = new Point(118, 198);
            btnCuentasT.Name = "btnCuentasT";
            btnCuentasT.Size = new Size(108, 23);
            btnCuentasT.TabIndex = 3;
            btnCuentasT.Text = "Cuentas T";
            btnCuentasT.UseVisualStyleBackColor = true;
            btnCuentasT.Click += btnCuentasT_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(256, 257);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(343, 303);
            Controls.Add(btnSalir);
            Controls.Add(btnCuentasT);
            Controls.Add(btnAsientos);
            Controls.Add(btnDefiniciones);
            Controls.Add(lblTituloMenu);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloMenu;
        private Button btnDefiniciones;
        private Button btnAsientos;
        private Button btnCuentasT;
        private Button btnSalir;
    }
}