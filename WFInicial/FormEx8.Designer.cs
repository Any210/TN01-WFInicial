namespace WFInicial
{
    partial class FormEx8
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
            lblNum1 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            lblNum2 = new Label();
            gbxOperacao = new GroupBox();
            rdbRadiciação = new RadioButton();
            rdbPotenciação = new RadioButton();
            rdbDivisão = new RadioButton();
            rdbMultiplicação = new RadioButton();
            rdbSubtração = new RadioButton();
            rdbSoma = new RadioButton();
            btnCalcular = new Button();
            gbxOperacao.SuspendLayout();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(78, 37);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(63, 15);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Numero 1:";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(78, 55);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(78, 112);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 3;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(78, 94);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(63, 15);
            lblNum2.TabIndex = 2;
            lblNum2.Text = "Numero 2:";
            // 
            // gbxOperacao
            // 
            gbxOperacao.Controls.Add(rdbRadiciação);
            gbxOperacao.Controls.Add(rdbPotenciação);
            gbxOperacao.Controls.Add(rdbDivisão);
            gbxOperacao.Controls.Add(rdbMultiplicação);
            gbxOperacao.Controls.Add(rdbSubtração);
            gbxOperacao.Controls.Add(rdbSoma);
            gbxOperacao.Location = new Point(245, 37);
            gbxOperacao.Name = "gbxOperacao";
            gbxOperacao.Size = new Size(276, 98);
            gbxOperacao.TabIndex = 4;
            gbxOperacao.TabStop = false;
            gbxOperacao.Text = "Operação";
            gbxOperacao.Enter += gbxOperacao_Enter;
            // 
            // rdbRadiciação
            // 
            rdbRadiciação.AutoSize = true;
            rdbRadiciação.Location = new Point(114, 72);
            rdbRadiciação.Name = "rdbRadiciação";
            rdbRadiciação.Size = new Size(82, 19);
            rdbRadiciação.TabIndex = 5;
            rdbRadiciação.TabStop = true;
            rdbRadiciação.Text = "Radiciação";
            rdbRadiciação.UseVisualStyleBackColor = true;
            // 
            // rdbPotenciação
            // 
            rdbPotenciação.AutoSize = true;
            rdbPotenciação.Location = new Point(7, 70);
            rdbPotenciação.Name = "rdbPotenciação";
            rdbPotenciação.Size = new Size(90, 19);
            rdbPotenciação.TabIndex = 4;
            rdbPotenciação.TabStop = true;
            rdbPotenciação.Text = "Potenciação";
            rdbPotenciação.UseVisualStyleBackColor = true;
            // 
            // rdbDivisão
            // 
            rdbDivisão.AutoSize = true;
            rdbDivisão.Location = new Point(114, 47);
            rdbDivisão.Name = "rdbDivisão";
            rdbDivisão.Size = new Size(63, 19);
            rdbDivisão.TabIndex = 3;
            rdbDivisão.TabStop = true;
            rdbDivisão.Text = "Divisão";
            rdbDivisão.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicação
            // 
            rdbMultiplicação.AutoSize = true;
            rdbMultiplicação.Location = new Point(7, 47);
            rdbMultiplicação.Name = "rdbMultiplicação";
            rdbMultiplicação.Size = new Size(97, 19);
            rdbMultiplicação.TabIndex = 2;
            rdbMultiplicação.TabStop = true;
            rdbMultiplicação.Text = "Multiplicação";
            rdbMultiplicação.UseVisualStyleBackColor = true;
            // 
            // rdbSubtração
            // 
            rdbSubtração.AutoSize = true;
            rdbSubtração.Location = new Point(114, 22);
            rdbSubtração.Name = "rdbSubtração";
            rdbSubtração.Size = new Size(78, 19);
            rdbSubtração.TabIndex = 1;
            rdbSubtração.TabStop = true;
            rdbSubtração.Text = "Subtração";
            rdbSubtração.UseVisualStyleBackColor = true;
            // 
            // rdbSoma
            // 
            rdbSoma.AutoSize = true;
            rdbSoma.Location = new Point(7, 22);
            rdbSoma.Name = "rdbSoma";
            rdbSoma.Size = new Size(55, 19);
            rdbSoma.TabIndex = 0;
            rdbSoma.TabStop = true;
            rdbSoma.Text = "Soma";
            rdbSoma.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(87, 172);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormEx8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(gbxOperacao);
            Controls.Add(txtNum2);
            Controls.Add(lblNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum1);
            Name = "FormEx8";
            Text = "FormEx8";
            gbxOperacao.ResumeLayout(false);
            gbxOperacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label lblNum2;
        private GroupBox gbxOperacao;
        private RadioButton rdbRadiciação;
        private RadioButton rdbPotenciação;
        private RadioButton rdbDivisão;
        private RadioButton rdbMultiplicação;
        private RadioButton rdbSubtração;
        private RadioButton rdbSoma;
        private Button btnCalcular;
    }
}