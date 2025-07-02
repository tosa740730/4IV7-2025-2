namespace Usuarios
{
    partial class Inicio_de_sesion
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
            label1 = new Label();
            label2 = new Label();
            TbxUsuario = new TextBox();
            TbxContraseña = new TextBox();
            BtnIniciar = new Button();
            BtnCrear = new Button();
            BtnCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(10, 18);
            label1.Name = "label1";
            label1.Size = new Size(307, 30);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su Usuario\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(10, 93);
            label2.Name = "label2";
            label2.Size = new Size(307, 30);
            label2.TabIndex = 0;
            label2.Text = "Ingrese su Contraseña";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TbxUsuario
            // 
            TbxUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbxUsuario.Location = new Point(22, 50);
            TbxUsuario.Margin = new Padding(3, 2, 3, 2);
            TbxUsuario.Name = "TbxUsuario";
            TbxUsuario.Size = new Size(278, 29);
            TbxUsuario.TabIndex = 1;
            // 
            // TbxContraseña
            // 
            TbxContraseña.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbxContraseña.Location = new Point(22, 125);
            TbxContraseña.Margin = new Padding(3, 2, 3, 2);
            TbxContraseña.Name = "TbxContraseña";
            TbxContraseña.PasswordChar = '♣';
            TbxContraseña.Size = new Size(278, 28);
            TbxContraseña.TabIndex = 1;
            // 
            // BtnIniciar
            // 
            BtnIniciar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIniciar.Location = new Point(469, 136);
            BtnIniciar.Margin = new Padding(3, 2, 3, 2);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(159, 44);
            BtnIniciar.TabIndex = 2;
            BtnIniciar.Text = "Ingresar";
            BtnIniciar.UseVisualStyleBackColor = true;
            BtnIniciar.Click += BtnIniciar_Click;
            // 
            // BtnCrear
            // 
            BtnCrear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCrear.Location = new Point(469, 192);
            BtnCrear.Margin = new Padding(3, 2, 3, 2);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(159, 44);
            BtnCrear.TabIndex = 2;
            BtnCrear.Text = "Crear usuario";
            BtnCrear.UseVisualStyleBackColor = true;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrar.Location = new Point(22, 192);
            BtnCerrar.Margin = new Padding(3, 2, 3, 2);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(159, 44);
            BtnCerrar.TabIndex = 2;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // Inicio_de_sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 244);
            ControlBox = false;
            Controls.Add(BtnCerrar);
            Controls.Add(BtnCrear);
            Controls.Add(BtnIniciar);
            Controls.Add(TbxContraseña);
            Controls.Add(TbxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Inicio_de_sesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio_de_sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TbxUsuario;
        private TextBox TbxContraseña;
        private Button BtnIniciar;
        private Button BtnCrear;
        private Button BtnCerrar;
    }
}