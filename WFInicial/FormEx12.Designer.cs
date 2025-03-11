namespace WFInicial
{
    partial class FormEx12
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
            lblNumero = new Label();
            lblContador = new Label();
            txtNumero = new TextBox();
            btnAdicionar = new Button();
            lblNumeros = new Label();
            lblImpar = new Label();
            lblPar = new Label();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(25, 23);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número:";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(239, 23);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(13, 15);
            lblContador.TabIndex = 1;
            lblContador.Text = "0";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(108, 23);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(108, 66);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lblNumeros
            // 
            lblNumeros.BorderStyle = BorderStyle.Fixed3D;
            lblNumeros.Location = new Point(25, 106);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(227, 23);
            lblNumeros.TabIndex = 4;
            lblNumeros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblImpar
            // 
            lblImpar.BorderStyle = BorderStyle.Fixed3D;
            lblImpar.Location = new Point(25, 182);
            lblImpar.Name = "lblImpar";
            lblImpar.Size = new Size(227, 23);
            lblImpar.TabIndex = 5;
            lblImpar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPar
            // 
            lblPar.BorderStyle = BorderStyle.Fixed3D;
            lblPar.Location = new Point(25, 143);
            lblPar.Name = "lblPar";
            lblPar.Size = new Size(227, 23);
            lblPar.TabIndex = 6;
            lblPar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormEx12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 262);
            Controls.Add(lblPar);
            Controls.Add(lblImpar);
            Controls.Add(lblNumeros);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNumero);
            Controls.Add(lblContador);
            Controls.Add(lblNumero);
            Name = "FormEx12";
            Text = "FormEx12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblContador;
        private TextBox txtNumero;
        private Button btnAdicionar;
        private Label lblNumeros;
        private Label lblImpar;
        private Label lblPar;
    }
}