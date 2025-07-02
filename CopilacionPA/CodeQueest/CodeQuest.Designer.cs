namespace CodeQueest
{
    partial class CodeQuest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeQuest));
            PnlPreguntas = new Panel();
            LblVidas = new Label();
            LblInsisoD = new Label();
            LblInsisoC = new Label();
            LblInsisoB = new Label();
            LblInsisoA = new Label();
            TxBoxPre10 = new TextBox();
            BtnAceptar = new Button();
            RtnRespuestaD = new RadioButton();
            RtnRespuestaC = new RadioButton();
            RtnRespuestaB = new RadioButton();
            RtnRespuestaA = new RadioButton();
            LblPregunta = new Label();
            PnlRetroali = new Panel();
            LblRetro = new Label();
            LblVidaserr = new Label();
            LblAdvertenciaerror = new Label();
            BtncontinuarError = new Button();
            PnlRespCorre = new Panel();
            BtnContinuarCorr = new Button();
            label1 = new Label();
            PnlPreguntas.SuspendLayout();
            PnlRetroali.SuspendLayout();
            PnlRespCorre.SuspendLayout();
            SuspendLayout();
            // 
            // PnlPreguntas
            // 
            PnlPreguntas.BackgroundImage = Properties.Resources.puerta_cerrada;
            PnlPreguntas.BackgroundImageLayout = ImageLayout.Stretch;
            PnlPreguntas.Controls.Add(LblVidas);
            PnlPreguntas.Controls.Add(LblInsisoD);
            PnlPreguntas.Controls.Add(LblInsisoC);
            PnlPreguntas.Controls.Add(LblInsisoB);
            PnlPreguntas.Controls.Add(LblInsisoA);
            PnlPreguntas.Controls.Add(TxBoxPre10);
            PnlPreguntas.Controls.Add(BtnAceptar);
            PnlPreguntas.Controls.Add(RtnRespuestaD);
            PnlPreguntas.Controls.Add(RtnRespuestaC);
            PnlPreguntas.Controls.Add(RtnRespuestaB);
            PnlPreguntas.Controls.Add(RtnRespuestaA);
            PnlPreguntas.Controls.Add(LblPregunta);
            PnlPreguntas.Location = new Point(158, 103);
            PnlPreguntas.Name = "PnlPreguntas";
            PnlPreguntas.Size = new Size(795, 418);
            PnlPreguntas.TabIndex = 0;
            PnlPreguntas.VisibleChanged += PnlPreguntas_VisibleChanged;
            // 
            // LblVidas
            // 
            LblVidas.BackColor = Color.Transparent;
            LblVidas.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblVidas.ForeColor = SystemColors.ButtonHighlight;
            LblVidas.Location = new Point(578, 368);
            LblVidas.Name = "LblVidas";
            LblVidas.Size = new Size(83, 39);
            LblVidas.TabIndex = 5;
            LblVidas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblInsisoD
            // 
            LblInsisoD.AutoSize = true;
            LblInsisoD.BackColor = Color.Transparent;
            LblInsisoD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LblInsisoD.ForeColor = SystemColors.ButtonHighlight;
            LblInsisoD.Location = new Point(63, 386);
            LblInsisoD.Name = "LblInsisoD";
            LblInsisoD.Size = new Size(14, 21);
            LblInsisoD.TabIndex = 4;
            LblInsisoD.Text = ".";
            LblInsisoD.Click += LblInsisoD_Click;
            // 
            // LblInsisoC
            // 
            LblInsisoC.AutoSize = true;
            LblInsisoC.BackColor = Color.Transparent;
            LblInsisoC.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LblInsisoC.ForeColor = SystemColors.ButtonHighlight;
            LblInsisoC.Location = new Point(63, 356);
            LblInsisoC.Name = "LblInsisoC";
            LblInsisoC.Size = new Size(14, 21);
            LblInsisoC.TabIndex = 4;
            LblInsisoC.Text = ".";
            LblInsisoC.Click += LblInsisoC_Click;
            // 
            // LblInsisoB
            // 
            LblInsisoB.AutoSize = true;
            LblInsisoB.BackColor = Color.Transparent;
            LblInsisoB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LblInsisoB.ForeColor = SystemColors.ButtonHighlight;
            LblInsisoB.Location = new Point(63, 326);
            LblInsisoB.Name = "LblInsisoB";
            LblInsisoB.Size = new Size(14, 21);
            LblInsisoB.TabIndex = 4;
            LblInsisoB.Text = ".";
            LblInsisoB.Click += LblInsisoB_Click;
            // 
            // LblInsisoA
            // 
            LblInsisoA.AutoSize = true;
            LblInsisoA.BackColor = Color.Transparent;
            LblInsisoA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LblInsisoA.ForeColor = SystemColors.ButtonHighlight;
            LblInsisoA.Location = new Point(63, 296);
            LblInsisoA.Name = "LblInsisoA";
            LblInsisoA.Size = new Size(14, 21);
            LblInsisoA.TabIndex = 4;
            LblInsisoA.Text = ".";
            LblInsisoA.Click += LblInsisoA_Click;
            // 
            // TxBoxPre10
            // 
            TxBoxPre10.Cursor = Cursors.IBeam;
            TxBoxPre10.Location = new Point(216, 203);
            TxBoxPre10.Multiline = true;
            TxBoxPre10.Name = "TxBoxPre10";
            TxBoxPre10.ReadOnly = true;
            TxBoxPre10.ScrollBars = ScrollBars.Both;
            TxBoxPre10.Size = new Size(356, 204);
            TxBoxPre10.TabIndex = 3;
            TxBoxPre10.Text = resources.GetString("TxBoxPre10.Text");
            TxBoxPre10.Visible = false;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(667, 368);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(118, 41);
            BtnAceptar.TabIndex = 2;
            BtnAceptar.Text = "Validar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // RtnRespuestaD
            // 
            RtnRespuestaD.AutoSize = true;
            RtnRespuestaD.BackColor = Color.Transparent;
            RtnRespuestaD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            RtnRespuestaD.ForeColor = SystemColors.ButtonHighlight;
            RtnRespuestaD.Location = new Point(12, 386);
            RtnRespuestaD.Name = "RtnRespuestaD";
            RtnRespuestaD.Size = new Size(46, 24);
            RtnRespuestaD.TabIndex = 1;
            RtnRespuestaD.TabStop = true;
            RtnRespuestaD.Text = "D)";
            RtnRespuestaD.UseVisualStyleBackColor = false;
            RtnRespuestaD.Click += LblInsisoD_Click;
            // 
            // RtnRespuestaC
            // 
            RtnRespuestaC.AutoSize = true;
            RtnRespuestaC.BackColor = Color.Transparent;
            RtnRespuestaC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            RtnRespuestaC.ForeColor = SystemColors.ButtonHighlight;
            RtnRespuestaC.Location = new Point(12, 356);
            RtnRespuestaC.Name = "RtnRespuestaC";
            RtnRespuestaC.Size = new Size(45, 24);
            RtnRespuestaC.TabIndex = 1;
            RtnRespuestaC.TabStop = true;
            RtnRespuestaC.Text = "C)";
            RtnRespuestaC.UseVisualStyleBackColor = false;
            RtnRespuestaC.Click += LblInsisoC_Click;
            // 
            // RtnRespuestaB
            // 
            RtnRespuestaB.AutoSize = true;
            RtnRespuestaB.BackColor = Color.Transparent;
            RtnRespuestaB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            RtnRespuestaB.ForeColor = SystemColors.ButtonHighlight;
            RtnRespuestaB.Location = new Point(12, 326);
            RtnRespuestaB.Name = "RtnRespuestaB";
            RtnRespuestaB.Size = new Size(45, 24);
            RtnRespuestaB.TabIndex = 1;
            RtnRespuestaB.TabStop = true;
            RtnRespuestaB.Text = "B)";
            RtnRespuestaB.UseVisualStyleBackColor = false;
            RtnRespuestaB.Click += LblInsisoB_Click;
            // 
            // RtnRespuestaA
            // 
            RtnRespuestaA.AutoSize = true;
            RtnRespuestaA.BackColor = Color.Transparent;
            RtnRespuestaA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            RtnRespuestaA.ForeColor = SystemColors.ButtonHighlight;
            RtnRespuestaA.Location = new Point(12, 296);
            RtnRespuestaA.Name = "RtnRespuestaA";
            RtnRespuestaA.Size = new Size(45, 24);
            RtnRespuestaA.TabIndex = 1;
            RtnRespuestaA.TabStop = true;
            RtnRespuestaA.Text = "A)";
            RtnRespuestaA.UseVisualStyleBackColor = false;
            RtnRespuestaA.Click += LblInsisoA_Click;
            // 
            // LblPregunta
            // 
            LblPregunta.BackColor = Color.Transparent;
            LblPregunta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            LblPregunta.ForeColor = Color.White;
            LblPregunta.Location = new Point(52, 15);
            LblPregunta.Name = "LblPregunta";
            LblPregunta.Size = new Size(665, 267);
            LblPregunta.TabIndex = 0;
            LblPregunta.Text = "-";
            // 
            // PnlRetroali
            // 
            PnlRetroali.BackgroundImage = Properties.Resources.puerta_cerrada;
            PnlRetroali.BackgroundImageLayout = ImageLayout.Stretch;
            PnlRetroali.Controls.Add(LblRetro);
            PnlRetroali.Controls.Add(LblVidaserr);
            PnlRetroali.Controls.Add(LblAdvertenciaerror);
            PnlRetroali.Controls.Add(BtncontinuarError);
            PnlRetroali.Location = new Point(207, 103);
            PnlRetroali.Name = "PnlRetroali";
            PnlRetroali.Size = new Size(674, 418);
            PnlRetroali.TabIndex = 1;
            PnlRetroali.VisibleChanged += PnlRetroali_VisibleChanged;
            // 
            // LblRetro
            // 
            LblRetro.BackColor = Color.Transparent;
            LblRetro.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            LblRetro.ForeColor = SystemColors.ButtonHighlight;
            LblRetro.Location = new Point(18, 13);
            LblRetro.Name = "LblRetro";
            LblRetro.Size = new Size(636, 206);
            LblRetro.TabIndex = 3;
            // 
            // LblVidaserr
            // 
            LblVidaserr.BackColor = Color.Transparent;
            LblVidaserr.Font = new Font("Microsoft YaHei", 15F, FontStyle.Bold | FontStyle.Italic);
            LblVidaserr.ForeColor = SystemColors.ButtonHighlight;
            LblVidaserr.Location = new Point(236, 297);
            LblVidaserr.Name = "LblVidaserr";
            LblVidaserr.Size = new Size(186, 45);
            LblVidaserr.TabIndex = 2;
            LblVidaserr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblAdvertenciaerror
            // 
            LblAdvertenciaerror.BackColor = Color.Transparent;
            LblAdvertenciaerror.CausesValidation = false;
            LblAdvertenciaerror.Font = new Font("Microsoft YaHei", 15F, FontStyle.Bold | FontStyle.Italic);
            LblAdvertenciaerror.ForeColor = SystemColors.ButtonHighlight;
            LblAdvertenciaerror.Location = new Point(3, 360);
            LblAdvertenciaerror.Name = "LblAdvertenciaerror";
            LblAdvertenciaerror.Size = new Size(668, 38);
            LblAdvertenciaerror.TabIndex = 1;
            LblAdvertenciaerror.Text = "*Sientes que una fuerza invisible te lleva a la prueba anterior*";
            LblAdvertenciaerror.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtncontinuarError
            // 
            BtncontinuarError.Font = new Font("SimSun-ExtB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtncontinuarError.Location = new Point(236, 231);
            BtncontinuarError.Name = "BtncontinuarError";
            BtncontinuarError.Size = new Size(186, 63);
            BtncontinuarError.TabIndex = 0;
            BtncontinuarError.Text = "<-----";
            BtncontinuarError.UseVisualStyleBackColor = true;
            BtncontinuarError.Click += BtncontinuarError_Click;
            // 
            // PnlRespCorre
            // 
            PnlRespCorre.BackgroundImage = Properties.Resources.Puerta_abierta;
            PnlRespCorre.BackgroundImageLayout = ImageLayout.Stretch;
            PnlRespCorre.Controls.Add(BtnContinuarCorr);
            PnlRespCorre.Controls.Add(label1);
            PnlRespCorre.Location = new Point(204, 103);
            PnlRespCorre.Name = "PnlRespCorre";
            PnlRespCorre.Size = new Size(674, 418);
            PnlRespCorre.TabIndex = 2;
            // 
            // BtnContinuarCorr
            // 
            BtnContinuarCorr.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnContinuarCorr.Location = new Point(262, 286);
            BtnContinuarCorr.Name = "BtnContinuarCorr";
            BtnContinuarCorr.Size = new Size(151, 56);
            BtnContinuarCorr.TabIndex = 1;
            BtnContinuarCorr.Text = "------->";
            BtnContinuarCorr.UseVisualStyleBackColor = true;
            BtnContinuarCorr.Click += BtnContinuarCorr_Click_1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 29);
            label1.Name = "label1";
            label1.Size = new Size(668, 196);
            label1.TabIndex = 0;
            label1.Text = "Felicidades, la respuesta es correcta \r\nAvance a la siguiente prueba";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CodeQuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1073, 624);
            Controls.Add(PnlPreguntas);
            Controls.Add(PnlRetroali);
            Controls.Add(PnlRespCorre);
            Name = "CodeQuest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeQuest";
            Click += Form1_Load;
            PnlPreguntas.ResumeLayout(false);
            PnlPreguntas.PerformLayout();
            PnlRetroali.ResumeLayout(false);
            PnlRespCorre.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlPreguntas;
        private RadioButton RtnRespuestaA;
        private Label LblPregunta;
        private Button BtnAceptar;
        private RadioButton RtnRespuestaD;
        private RadioButton RtnRespuestaC;
        private RadioButton RtnRespuestaB;
        private TextBox TxBoxPre10;
        private Label LblVidas;
        private Label LblInsisoD;
        private Label LblInsisoC;
        private Label LblInsisoB;
        private Label LblInsisoA;
        private Panel PnlRetroali;
        private Label LblRetro;
        private Label LblVidaserr;
        private Label LblAdvertenciaerror;
        private Button BtncontinuarError;
        private Panel PnlRespCorre;
        private Label label1;
        private Button BtnContinuarCorr;
    }
}
