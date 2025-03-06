namespace WFInicial
{
    partial class FormEx7
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
            btnCadastrar = new Button();
            txtProd = new TextBox();
            txtValor = new TextBox();
            lblProd = new Label();
            lblValor = new Label();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(49, 101);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtProd
            // 
            txtProd.Location = new Point(71, 12);
            txtProd.Name = "txtProd";
            txtProd.Size = new Size(100, 23);
            txtProd.TabIndex = 1;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(71, 57);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 2;
            // 
            // lblProd
            // 
            lblProd.AutoSize = true;
            lblProd.Location = new Point(12, 9);
            lblProd.Name = "lblProd";
            lblProd.Size = new Size(53, 15);
            lblProd.TabIndex = 3;
            lblProd.Text = "Produto:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(12, 57);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor:";
            // 
            // FormEx7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 352);
            Controls.Add(lblValor);
            Controls.Add(lblProd);
            Controls.Add(txtValor);
            Controls.Add(txtProd);
            Controls.Add(btnCadastrar);
            Name = "FormEx7";
            Text = "FormEx7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private TextBox txtProd;
        private TextBox txtValor;
        private Label lblProd;
        private Label lblValor;
    }
}