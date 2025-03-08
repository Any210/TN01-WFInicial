namespace WFInicial
{
    partial class FormEx11
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
            btnCalcular = new Button();
            lblSalarioBruto = new Label();
            txtSalarioBruto = new TextBox();
            txtResultado = new RichTextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(157, 79);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblSalarioBruto
            // 
            lblSalarioBruto.AutoSize = true;
            lblSalarioBruto.Location = new Point(49, 41);
            lblSalarioBruto.Name = "lblSalarioBruto";
            lblSalarioBruto.Size = new Size(77, 15);
            lblSalarioBruto.TabIndex = 1;
            lblSalarioBruto.Text = "Sálario Bruto:";
            // 
            // txtSalarioBruto
            // 
            txtSalarioBruto.Location = new Point(132, 38);
            txtSalarioBruto.Name = "txtSalarioBruto";
            txtSalarioBruto.Size = new Size(100, 23);
            txtSalarioBruto.TabIndex = 2;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(46, 120);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(186, 252);
            txtResultado.TabIndex = 3;
            txtResultado.Text = "";
            // 
            // FormEx11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 409);
            Controls.Add(txtResultado);
            Controls.Add(txtSalarioBruto);
            Controls.Add(lblSalarioBruto);
            Controls.Add(btnCalcular);
            Name = "FormEx11";
            Text = "FormEx11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblSalarioBruto;
        private TextBox txtSalarioBruto;
        private RichTextBox txtResultado;
    }
}