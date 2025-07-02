namespace PA_TELE
{
    partial class SelecciondeTemas
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelContenido = new Panel();
            labelContenidoTema = new Label();
            button1 = new Button();
            label2 = new Label();
            Btn2 = new Button();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.CornflowerBlue;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(7, 68);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(204, 493);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panelContenido
            // 
            panelContenido.AutoScroll = true;
            panelContenido.BackColor = SystemColors.MenuBar;
            panelContenido.BorderStyle = BorderStyle.FixedSingle;
            panelContenido.Controls.Add(labelContenidoTema);
            panelContenido.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            panelContenido.Location = new Point(215, 68);
            panelContenido.Margin = new Padding(3, 4, 3, 4);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(816, 493);
            panelContenido.TabIndex = 1;
            panelContenido.Paint += panelContenido_Paint;
            // 
            // labelContenidoTema
            // 
            labelContenidoTema.AutoSize = true;
            labelContenidoTema.Location = new Point(50, 49);
            labelContenidoTema.Name = "labelContenidoTema";
            labelContenidoTema.Size = new Size(0, 20);
            labelContenidoTema.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(547, 569);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(259, 31);
            button1.TabIndex = 3;
            button1.Text = "Regresar al Inicio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button3_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Lavender;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 33);
            label2.Name = "label2";
            label2.Size = new Size(378, 30);
            label2.TabIndex = 4;
            label2.Text = "Escoja un Tema :\"El orden de los temas  es de arriba a abajo\"";
            // 
            // Btn2
            // 
            Btn2.Location = new Point(829, 569);
            Btn2.Margin = new Padding(3, 4, 3, 4);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(202, 31);
            Btn2.TabIndex = 5;
            Btn2.Text = "Agradeciemtos y creadores";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Btn2_Click;
            // 
            // SelecciondeTemas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1045, 605);
            Controls.Add(Btn2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panelContenido);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SelecciondeTemas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selección de Temas";
            Load += SelecciondeTemas_Load;
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelContenido;
        private Label labelContenidoTema;
        private Button button1;
        private Label label2;
        private Button Btn2;
    }
}