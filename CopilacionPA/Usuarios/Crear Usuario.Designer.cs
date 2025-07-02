namespace Usuarios
{
    partial class Crear_Usuario
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
            BtnCerrar = new Button();
            BtnIniciar = new Button();
            BtnCrear = new Button();
            TbxContraseña = new TextBox();
            TbxUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnCerrar
            // 
            BtnCerrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrar.Location = new Point(23, 209);
            BtnCerrar.Margin = new Padding(3, 2, 3, 2);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(159, 44);
            BtnCerrar.TabIndex = 7;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // BtnIniciar
            // 
            BtnIniciar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIniciar.Location = new Point(492, 209);
            BtnIniciar.Margin = new Padding(3, 2, 3, 2);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(159, 44);
            BtnIniciar.TabIndex = 8;
            BtnIniciar.Text = "Iniciar sesion";
            BtnIniciar.UseVisualStyleBackColor = true;
            BtnIniciar.Click += BtnIniciar_Click;
            // 
            // BtnCrear
            // 
            BtnCrear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCrear.Location = new Point(492, 153);
            BtnCrear.Margin = new Padding(3, 2, 3, 2);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(159, 44);
            BtnCrear.TabIndex = 9;
            BtnCrear.Text = "Crear";
            BtnCrear.UseVisualStyleBackColor = true;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // TbxContraseña
            // 
            TbxContraseña.Font = new Font("Sitka Subheading", 12F);
            TbxContraseña.Location = new Point(23, 121);
            TbxContraseña.Margin = new Padding(3, 2, 3, 2);
            TbxContraseña.Name = "TbxContraseña";
            TbxContraseña.PasswordChar = '♣';
            TbxContraseña.Size = new Size(278, 28);
            TbxContraseña.TabIndex = 5;
            // 
            // TbxUsuario
            // 
            TbxUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbxUsuario.Location = new Point(23, 46);
            TbxUsuario.Margin = new Padding(3, 2, 3, 2);
            TbxUsuario.Name = "TbxUsuario";
            TbxUsuario.Size = new Size(278, 29);
            TbxUsuario.TabIndex = 6;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(10, 88);
            label2.Name = "label2";
            label2.Size = new Size(307, 30);
            label2.TabIndex = 3;
            label2.Text = "Cree una Contraseña";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(307, 30);
            label1.TabIndex = 4;
            label1.Text = "Cree un Usuario\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Crear_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 262);
            ControlBox = false;
            Controls.Add(BtnCerrar);
            Controls.Add(BtnIniciar);
            Controls.Add(BtnCrear);
            Controls.Add(TbxContraseña);
            Controls.Add(TbxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Crear_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear_Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCerrar;
        private Button BtnIniciar;
        private Button BtnCrear;
        private TextBox TbxContraseña;
        private TextBox TbxUsuario;
        private Label label2;
        private Label label1;
    }
}