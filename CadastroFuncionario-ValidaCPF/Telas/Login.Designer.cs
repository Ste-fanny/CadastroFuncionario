namespace CadastroFuncionario_ValidaCPF
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(269, 190);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(58, 153);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Entar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 2;
            label1.Text = "Faça Login!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(138, 40);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 5;
            label4.Text = "X2A emprsarial";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(58, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 16);
            textBox1.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.Location = new Point(58, 73);
            maskedTextBox1.Mask = "000,000,000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(75, 16);
            maskedTextBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 194);
            label5.Name = "label5";
            label5.Size = new Size(217, 15);
            label5.TabIndex = 8;
            label5.Text = "Ainda não tem um cadastro? Click aqui ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Wingdings 3", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(235, 193);
            label6.Name = "label6";
            label6.Size = new Size(28, 23);
            label6.TabIndex = 9;
            label6.Text = "e";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 241);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Label label6;
    }
}