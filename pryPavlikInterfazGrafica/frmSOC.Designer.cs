namespace pryPavlikInterfazGrafica
{
    partial class frmSOC
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
            lblCritico = new Label();
            lblAlto = new Label();
            lblMedio = new Label();
            lblBajo = new Label();
            lblResultadoCritico = new Label();
            ResultadoAlto = new Label();
            ResultadoMedio = new Label();
            ResultadoBajo = new Label();
            SuspendLayout();
            // 
            // lblCritico
            // 
            lblCritico.AutoSize = true;
            lblCritico.Location = new Point(8, 30);
            lblCritico.Name = "lblCritico";
            lblCritico.Size = new Size(42, 15);
            lblCritico.TabIndex = 0;
            lblCritico.Text = "Crítico";
            // 
            // lblAlto
            // 
            lblAlto.AutoSize = true;
            lblAlto.Location = new Point(8, 61);
            lblAlto.Name = "lblAlto";
            lblAlto.Size = new Size(29, 15);
            lblAlto.TabIndex = 1;
            lblAlto.Text = "Alto";
            // 
            // lblMedio
            // 
            lblMedio.AutoSize = true;
            lblMedio.Location = new Point(8, 92);
            lblMedio.Name = "lblMedio";
            lblMedio.Size = new Size(41, 15);
            lblMedio.TabIndex = 2;
            lblMedio.Text = "Medio";
            // 
            // lblBajo
            // 
            lblBajo.AutoSize = true;
            lblBajo.Location = new Point(8, 122);
            lblBajo.Name = "lblBajo";
            lblBajo.Size = new Size(30, 15);
            lblBajo.TabIndex = 3;
            lblBajo.Text = "Bajo";
            // 
            // lblResultadoCritico
            // 
            lblResultadoCritico.AutoSize = true;
            lblResultadoCritico.Location = new Point(70, 30);
            lblResultadoCritico.Name = "lblResultadoCritico";
            lblResultadoCritico.Size = new Size(12, 15);
            lblResultadoCritico.TabIndex = 4;
            lblResultadoCritico.Text = "-";
            lblResultadoCritico.Click += label1_Click;
            // 
            // ResultadoAlto
            // 
            ResultadoAlto.AutoSize = true;
            ResultadoAlto.Location = new Point(70, 61);
            ResultadoAlto.Name = "ResultadoAlto";
            ResultadoAlto.Size = new Size(12, 15);
            ResultadoAlto.TabIndex = 5;
            ResultadoAlto.Text = "-";
            // 
            // ResultadoMedio
            // 
            ResultadoMedio.AutoSize = true;
            ResultadoMedio.Location = new Point(70, 92);
            ResultadoMedio.Name = "ResultadoMedio";
            ResultadoMedio.Size = new Size(12, 15);
            ResultadoMedio.TabIndex = 6;
            ResultadoMedio.Text = "-";
            // 
            // ResultadoBajo
            // 
            ResultadoBajo.AutoSize = true;
            ResultadoBajo.Location = new Point(70, 122);
            ResultadoBajo.Name = "ResultadoBajo";
            ResultadoBajo.Size = new Size(12, 15);
            ResultadoBajo.TabIndex = 7;
            ResultadoBajo.Text = "-";
            // 
            // frmSOC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 165);
            Controls.Add(ResultadoBajo);
            Controls.Add(ResultadoMedio);
            Controls.Add(ResultadoAlto);
            Controls.Add(lblResultadoCritico);
            Controls.Add(lblBajo);
            Controls.Add(lblMedio);
            Controls.Add(lblAlto);
            Controls.Add(lblCritico);
            Name = "frmSOC";
            Text = "frmSOC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCritico;
        private Label lblAlto;
        private Label lblMedio;
        private Label lblBajo;
        private Label lblResultadoCritico;
        private Label ResultadoAlto;
        private Label ResultadoMedio;
        private Label ResultadoBajo;
    }
}