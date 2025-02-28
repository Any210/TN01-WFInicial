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
            txtNum3 = new TextBox();
            lblNum3 = new Label();
            txtNum2 = new TextBox();
            lblQuant = new Label();
            txtNum1 = new TextBox();
            lblNome = new Label();
            btnMaiorEMenor = new Button();
            SuspendLayout();
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(395, 222);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 23);
            txtNum3.TabIndex = 20;
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(305, 222);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(63, 15);
            lblNum3.TabIndex = 19;
            lblNum3.Text = "Número 3:";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(395, 190);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 18;
            // 
            // lblQuant
            // 
            lblQuant.AutoSize = true;
            lblQuant.Location = new Point(305, 193);
            lblQuant.Name = "lblQuant";
            lblQuant.Size = new Size(187, 15);
            lblQuant.TabIndex = 17;
            lblQuant.Text = "Quantidade de Horas Trabalhadas:";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(395, 161);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 16;
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
            // btnMaiorEMenor
            // 
            btnMaiorEMenor.Location = new Point(350, 266);
            btnMaiorEMenor.Name = "btnMaiorEMenor";
            btnMaiorEMenor.Size = new Size(145, 23);
            btnMaiorEMenor.TabIndex = 14;
            btnMaiorEMenor.Text = "Número Maior e Menor";
            btnMaiorEMenor.UseVisualStyleBackColor = true;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNum3);
            Controls.Add(lblNum3);
            Controls.Add(txtNum2);
            Controls.Add(lblQuant);
            Controls.Add(txtNum1);
            Controls.Add(lblNome);
            Controls.Add(btnMaiorEMenor);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum3;
        private Label lblNum3;
        private TextBox txtNum2;
        private Label lblQuant;
        private TextBox txtNum1;
        private Label lblNome;
        private Button btnMaiorEMenor;
    }
}