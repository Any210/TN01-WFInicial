namespace WFInicial
{
    partial class FormEx6
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
            txtValor = new TextBox();
            lblValor = new Label();
            txtQuant = new TextBox();
            lblQuant = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            btnCalcule = new Button();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.Location = new Point(518, 222);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 20;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(305, 222);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(141, 15);
            lblValor.TabIndex = 19;
            lblValor.Text = "Valor da Hora Trabalhada:";
            // 
            // txtQuant
            // 
            txtQuant.Location = new Point(518, 190);
            txtQuant.Name = "txtQuant";
            txtQuant.Size = new Size(100, 23);
            txtQuant.TabIndex = 18;
            // 
            // lblQuant
            // 
            lblQuant.AutoSize = true;
            lblQuant.Location = new Point(305, 190);
            lblQuant.Name = "lblQuant";
            lblQuant.Size = new Size(187, 15);
            lblQuant.TabIndex = 17;
            lblQuant.Text = "Quantidade de Horas Trabalhadas:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(518, 161);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 16;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(305, 162);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 15;
            lblNome.Text = "Nome:";
            // 
            // btnCalcule
            // 
            btnCalcule.Location = new Point(350, 266);
            btnCalcule.Name = "btnCalcule";
            btnCalcule.Size = new Size(145, 23);
            btnCalcule.TabIndex = 14;
            btnCalcule.Text = "Calcule";
            btnCalcule.UseVisualStyleBackColor = true;
            btnCalcule.Click += btnCalcule_Click;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(txtQuant);
            Controls.Add(lblQuant);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnCalcule);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor;
        private Label lblValor;
        private TextBox txtQuant;
        private Label lblQuant;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnCalcule;
    }
}