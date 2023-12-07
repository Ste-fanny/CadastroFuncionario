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
            this.textRG = new System.Windows.Forms.MaskedTextBox();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textEstadCivil = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.texEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.texNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textComplemento = new System.Windows.Forms.TextBox();
            this.textCiti = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.textNcasa = new System.Windows.Forms.TextBox();
            this.textRuaAv = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textSalario = new System.Windows.Forms.TextBox();
            this.textFuncao = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textRG
            // 
            this.textRG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textRG.Location = new System.Drawing.Point(47, 347);
            this.textRG.Mask = "00,000,000-00";
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(110, 22);
            this.textRG.TabIndex = 26;
            // 
            // textCPF
            // 
            this.textCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCPF.Location = new System.Drawing.Point(178, 347);
            this.textCPF.Mask = "000,000,000-00";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(110, 22);
            this.textCPF.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LavenderBlush;
            this.label6.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(47, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "RG";
            // 
            // textEstadCivil
            // 
            this.textEstadCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEstadCivil.FormattingEnabled = true;
            this.textEstadCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Solteiro(a)",
            "Viuvo(a)",
            "Divorciado(a)"});
            this.textEstadCivil.Location = new System.Drawing.Point(47, 223);
            this.textEstadCivil.Name = "textEstadCivil";
            this.textEstadCivil.Size = new System.Drawing.Size(86, 24);
            this.textEstadCivil.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(298, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 26);
            this.button1.TabIndex = 31;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LavenderBlush;
            this.label7.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(178, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "CPF";
            // 
            // textTelefone
            // 
            this.textTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTelefone.Location = new System.Drawing.Point(47, 277);
            this.textTelefone.Mask = "(00) 0 0000-0000";
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(110, 22);
            this.textTelefone.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(149, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Dados Pessoal";
            // 
            // texEmail
            // 
            this.texEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.texEmail.Location = new System.Drawing.Point(107, 102);
            this.texEmail.Name = "texEmail";
            this.texEmail.Size = new System.Drawing.Size(219, 22);
            this.texEmail.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado Civil";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(497, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Dados De Enderço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LavenderBlush;
            this.label5.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(495, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Dados Empresarial";
            // 
            // texNome
            // 
            this.texNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.texNome.Location = new System.Drawing.Point(107, 66);
            this.texNome.Name = "texNome";
            this.texNome.Size = new System.Drawing.Size(219, 22);
            this.texNome.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textComplemento);
            this.panel1.Controls.Add(this.textCiti);
            this.panel1.Controls.Add(this.textEstado);
            this.panel1.Controls.Add(this.textBairro);
            this.panel1.Controls.Add(this.textNcasa);
            this.panel1.Controls.Add(this.textRuaAv);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(410, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 180);
            this.panel1.TabIndex = 21;
            // 
            // textComplemento
            // 
            this.textComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textComplemento.Location = new System.Drawing.Point(156, 134);
            this.textComplemento.Name = "textComplemento";
            this.textComplemento.Size = new System.Drawing.Size(173, 22);
            this.textComplemento.TabIndex = 20;
            // 
            // textCiti
            // 
            this.textCiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCiti.Location = new System.Drawing.Point(196, 81);
            this.textCiti.Name = "textCiti";
            this.textCiti.Size = new System.Drawing.Size(133, 22);
            this.textCiti.TabIndex = 15;
            // 
            // textEstado
            // 
            this.textEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEstado.Location = new System.Drawing.Point(196, 26);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(133, 22);
            this.textEstado.TabIndex = 16;
            // 
            // textBairro
            // 
            this.textBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBairro.Location = new System.Drawing.Point(3, 134);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(114, 22);
            this.textBairro.TabIndex = 18;
            // 
            // textNcasa
            // 
            this.textNcasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNcasa.Location = new System.Drawing.Point(3, 81);
            this.textNcasa.Name = "textNcasa";
            this.textNcasa.Size = new System.Drawing.Size(115, 22);
            this.textNcasa.TabIndex = 19;
            // 
            // textRuaAv
            // 
            this.textRuaAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textRuaAv.Location = new System.Drawing.Point(3, 25);
            this.textRuaAv.Name = "textRuaAv";
            this.textRuaAv.Size = new System.Drawing.Size(118, 22);
            this.textRuaAv.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.LavenderBlush;
            this.label20.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(3, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 19);
            this.label20.TabIndex = 8;
            this.label20.Text = "Número";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.LavenderBlush;
            this.label19.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(3, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 19);
            this.label19.TabIndex = 7;
            this.label19.Text = "Bairro/Região";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.LavenderBlush;
            this.label18.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(196, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 19);
            this.label18.TabIndex = 6;
            this.label18.Text = "Cidade/Município";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LavenderBlush;
            this.label16.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(196, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 19);
            this.label16.TabIndex = 4;
            this.label16.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Complemento (opcional)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LavenderBlush;
            this.label12.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(3, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Rua/Avenida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LavenderBlush;
            this.label8.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(47, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Data De Nascimento";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textSalario);
            this.panel3.Controls.Add(this.textFuncao);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(443, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 64);
            this.panel3.TabIndex = 19;
            // 
            // textSalario
            // 
            this.textSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSalario.Location = new System.Drawing.Point(131, 28);
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(123, 22);
            this.textSalario.TabIndex = 21;
            // 
            // textFuncao
            // 
            this.textFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textFuncao.FormattingEnabled = true;
            this.textFuncao.Items.AddRange(new object[] {
            "Desenvolvedor de software",
            "Analista de dados",
            "",
            "Especialista em segurança cibernética",
            "Administrador de sistemas",
            "",
            "Saúde ",
            "",
            "Enfermeiro especializado em UTI",
            "6",
            " Fisioterapeuta",
            "",
            " Nutricionista clínico",
            "",
            " Psicólogo clínico",
            "",
            "",
            " Analista financeiro",
            "",
            "Gerente de marketing digital",
            "",
            "Consultor de gestão",
            "",
            "",
            "Construção e Engenharia:",
            "Engenheiro civil",
            "",
            "Arquiteto",
            "",
            "Mecânico de aeronaves",
            "",
            "Técnico em eletrônica",
            "",
            "",
            "Professor de inglês como segunda língua (ESL)",
            "",
            " Instrutor de música",
            "",
            "Orientador educacional",
            "",
            "Professor de educação física"});
            this.textFuncao.Location = new System.Drawing.Point(5, 28);
            this.textFuncao.Name = "textFuncao";
            this.textFuncao.Size = new System.Drawing.Size(110, 24);
            this.textFuncao.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LavenderBlush;
            this.label14.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(131, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Salário";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LavenderBlush;
            this.label13.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(5, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Função";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(419, 388);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 26);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.Font = new System.Drawing.Font("Caladea", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(664, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 26);
            this.button2.TabIndex = 36;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textEstadCivil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.texEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.texNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label2);
            this.Name = "Cadastro";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label5;
        private Label label9;
        private TextBox texNome;
        private Panel panel1;
        private TextBox textComplemento;
        private TextBox textCiti;
        private TextBox textEstado;
        private TextBox textBairro;
        private TextBox textNcasa;
        private TextBox textRuaAv;
        private Label label20;
        private Label label19;
        private Label label18;
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
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}