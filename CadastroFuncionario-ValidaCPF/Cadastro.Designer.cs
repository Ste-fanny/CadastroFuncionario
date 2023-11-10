namespace CadastroFuncionario_ValidaCPF
{
    partial class Cadastro
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
            textRG = new MaskedTextBox();
            textCPF = new MaskedTextBox();
            label6 = new Label();
            textEstadCivil = new ComboBox();
            button1 = new Button();
            label7 = new Label();
            textTelefone = new MaskedTextBox();
            label10 = new Label();
            texEmail = new TextBox();
            label3 = new Label();
            label11 = new Label();
            textDataNac = new MaskedTextBox();
            label5 = new Label();
            label9 = new Label();
            texNome = new TextBox();
            panel1 = new Panel();
            textComplemento = new TextBox();
            textCiti = new TextBox();
            textEstado = new TextBox();
            textCodigoCep = new TextBox();
            textBairro = new TextBox();
            textNcasa = new TextBox();
            textRuaAv = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label1 = new Label();
            label12 = new Label();
            label4 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            textSalario = new TextBox();
            textFuncao = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            btnCadastrar = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textRG
            // 
            textRG.BorderStyle = BorderStyle.FixedSingle;
            textRG.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textRG.Location = new Point(47, 347);
            textRG.Mask = "00,000,000-00";
            textRG.Name = "textRG";
            textRG.Size = new Size(110, 22);
            textRG.TabIndex = 26;
            // 
            // textCPF
            // 
            textCPF.BorderStyle = BorderStyle.FixedSingle;
            textCPF.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textCPF.Location = new Point(178, 347);
            textCPF.Mask = "000,000,000-00";
            textCPF.Name = "textCPF";
            textCPF.Size = new Size(110, 22);
            textCPF.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LavenderBlush;
            label6.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(47, 325);
            label6.Name = "label6";
            label6.Size = new Size(27, 19);
            label6.TabIndex = 20;
            label6.Text = "RG";
            // 
            // textEstadCivil
            // 
            textEstadCivil.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textEstadCivil.FormattingEnabled = true;
            textEstadCivil.Items.AddRange(new object[] { "Casado(a)", "Solteiro(a)", "Viuvo(a)", "Divorciado(a)" });
            textEstadCivil.Location = new Point(47, 223);
            textEstadCivil.Name = "textEstadCivil";
            textEstadCivil.Size = new Size(86, 24);
            textEstadCivil.TabIndex = 34;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(298, 388);
            button1.Name = "button1";
            button1.Size = new Size(89, 26);
            button1.TabIndex = 31;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LavenderBlush;
            label7.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(178, 325);
            label7.Name = "label7";
            label7.Size = new Size(35, 19);
            label7.TabIndex = 22;
            label7.Text = "CPF";
            // 
            // textTelefone
            // 
            textTelefone.BorderStyle = BorderStyle.FixedSingle;
            textTelefone.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textTelefone.Location = new Point(47, 277);
            textTelefone.Mask = "(00) 0 0000-0000";
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(110, 22);
            textTelefone.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(149, 36);
            label10.Name = "label10";
            label10.Size = new Size(126, 20);
            label10.TabIndex = 28;
            label10.Text = "Dados Pessoal";
            // 
            // texEmail
            // 
            texEmail.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            texEmail.Location = new Point(107, 102);
            texEmail.Name = "texEmail";
            texEmail.Size = new Size(219, 22);
            texEmail.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LavenderBlush;
            label3.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 200);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 16;
            label3.Text = "Estado Civil";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(497, 124);
            label11.Name = "label11";
            label11.Size = new Size(159, 20);
            label11.TabIndex = 25;
            label11.Text = "Dados De Enderço";
            // 
            // textDataNac
            // 
            textDataNac.BorderStyle = BorderStyle.FixedSingle;
            textDataNac.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textDataNac.Location = new Point(47, 164);
            textDataNac.Mask = "00/00/0000";
            textDataNac.Name = "textDataNac";
            textDataNac.Size = new Size(72, 22);
            textDataNac.TabIndex = 29;
            textDataNac.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LavenderBlush;
            label5.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(47, 255);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 18;
            label5.Text = "Telefone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(495, 36);
            label9.Name = "label9";
            label9.Size = new Size(167, 20);
            label9.TabIndex = 23;
            label9.Text = "Dados Empresarial";
            // 
            // texNome
            // 
            texNome.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            texNome.Location = new Point(107, 66);
            texNome.Name = "texNome";
            texNome.Size = new Size(219, 22);
            texNome.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textComplemento);
            panel1.Controls.Add(textCiti);
            panel1.Controls.Add(textEstado);
            panel1.Controls.Add(textCodigoCep);
            panel1.Controls.Add(textBairro);
            panel1.Controls.Add(textNcasa);
            panel1.Controls.Add(textRuaAv);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(410, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 221);
            panel1.TabIndex = 21;
            // 
            // textComplemento
            // 
            textComplemento.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textComplemento.Location = new Point(59, 192);
            textComplemento.Name = "textComplemento";
            textComplemento.Size = new Size(173, 22);
            textComplemento.TabIndex = 20;
            // 
            // textCiti
            // 
            textCiti.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textCiti.Location = new Point(196, 133);
            textCiti.Name = "textCiti";
            textCiti.Size = new Size(133, 22);
            textCiti.TabIndex = 15;
            // 
            // textEstado
            // 
            textEstado.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textEstado.Location = new Point(196, 80);
            textEstado.Name = "textEstado";
            textEstado.Size = new Size(133, 22);
            textEstado.TabIndex = 16;
            // 
            // textCodigoCep
            // 
            textCodigoCep.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textCodigoCep.Location = new Point(196, 25);
            textCodigoCep.Name = "textCodigoCep";
            textCodigoCep.Size = new Size(133, 22);
            textCodigoCep.TabIndex = 17;
            // 
            // textBairro
            // 
            textBairro.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBairro.Location = new Point(3, 134);
            textBairro.Name = "textBairro";
            textBairro.Size = new Size(114, 22);
            textBairro.TabIndex = 18;
            // 
            // textNcasa
            // 
            textNcasa.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textNcasa.Location = new Point(3, 81);
            textNcasa.Name = "textNcasa";
            textNcasa.Size = new Size(115, 22);
            textNcasa.TabIndex = 19;
            // 
            // textRuaAv
            // 
            textRuaAv.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textRuaAv.Location = new Point(3, 25);
            textRuaAv.Name = "textRuaAv";
            textRuaAv.Size = new Size(118, 22);
            textRuaAv.TabIndex = 15;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.LavenderBlush;
            label20.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(3, 59);
            label20.Name = "label20";
            label20.Size = new Size(64, 19);
            label20.TabIndex = 8;
            label20.Text = "Número";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.LavenderBlush;
            label19.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(3, 112);
            label19.Name = "label19";
            label19.Size = new Size(104, 19);
            label19.TabIndex = 7;
            label19.Text = "Bairro/Região";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.LavenderBlush;
            label18.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(196, 111);
            label18.Name = "label18";
            label18.Size = new Size(126, 19);
            label18.TabIndex = 6;
            label18.Text = "Cidade/Município";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.LavenderBlush;
            label17.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(197, 3);
            label17.Name = "label17";
            label17.Size = new Size(133, 19);
            label17.TabIndex = 5;
            label17.Text = "Código Postal/CEP";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.LavenderBlush;
            label16.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(196, 56);
            label16.Name = "label16";
            label16.Size = new Size(54, 19);
            label16.TabIndex = 4;
            label16.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LavenderBlush;
            label1.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 170);
            label1.Name = "label1";
            label1.Size = new Size(173, 19);
            label1.TabIndex = 3;
            label1.Text = "Complemento (opcional)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LavenderBlush;
            label12.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(3, 4);
            label12.Name = "label12";
            label12.Size = new Size(93, 19);
            label12.TabIndex = 2;
            label12.Text = "Rua/Avenida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LavenderBlush;
            label4.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(47, 105);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 17;
            label4.Text = "E-mail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LavenderBlush;
            label8.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(47, 142);
            label8.Name = "label8";
            label8.Size = new Size(145, 19);
            label8.TabIndex = 24;
            label8.Text = "Data De Nascimento";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textSalario);
            panel3.Controls.Add(textFuncao);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(443, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 64);
            panel3.TabIndex = 19;
            // 
            // textSalario
            // 
            textSalario.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textSalario.Location = new Point(131, 28);
            textSalario.Name = "textSalario";
            textSalario.Size = new Size(123, 22);
            textSalario.TabIndex = 21;
            // 
            // textFuncao
            // 
            textFuncao.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textFuncao.FormattingEnabled = true;
            textFuncao.Items.AddRange(new object[] { "Casado(a)", "Solteiro(a)", "Viuvo(a)", "Divorciado(a)" });
            textFuncao.Location = new Point(5, 28);
            textFuncao.Name = "textFuncao";
            textFuncao.Size = new Size(110, 24);
            textFuncao.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.LavenderBlush;
            label14.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(131, 6);
            label14.Name = "label14";
            label14.Size = new Size(56, 19);
            label14.TabIndex = 4;
            label14.Text = "Salário";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.LavenderBlush;
            label13.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(5, 6);
            label13.Name = "label13";
            label13.Size = new Size(58, 19);
            label13.TabIndex = 3;
            label13.Text = "Função";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.GradientInactiveCaption;
            btnCadastrar.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastrar.Location = new Point(419, 388);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(89, 26);
            btnCadastrar.TabIndex = 15;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LavenderBlush;
            label2.Font = new Font("Caladea", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 69);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 14;
            label2.Text = "Nome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(textRG);
            Controls.Add(textCPF);
            Controls.Add(label6);
            Controls.Add(textEstadCivil);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textTelefone);
            Controls.Add(label10);
            Controls.Add(texEmail);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(textDataNac);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(texNome);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(panel3);
            Controls.Add(btnCadastrar);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox textRG;
        private MaskedTextBox textCPF;
        private Label label6;
        private ComboBox textEstadCivil;
        private Button button1;
        private Label label7;
        private MaskedTextBox textTelefone;
        private Label label10;
        private TextBox texEmail;
        private Label label3;
        private Label label11;
        private MaskedTextBox textDataNac;
        private Label label5;
        private Label label9;
        private TextBox texNome;
        private Panel panel1;
        private TextBox textComplemento;
        private TextBox textCiti;
        private TextBox textEstado;
        private TextBox textCodigoCep;
        private TextBox textBairro;
        private TextBox textNcasa;
        private TextBox textRuaAv;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label1;
        private Label label12;
        private Label label4;
        private Label label8;
        private Panel panel3;
        private TextBox textSalario;
        private ComboBox textFuncao;
        private Label label14;
        private Label label13;
        private Button btnCadastrar;
        private Label label2;
    }
}