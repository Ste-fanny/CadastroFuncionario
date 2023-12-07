namespace CadastroFuncionario_ValidaCPF
{
    partial class ConsultarFuncionario
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
            dataGridViewFuncionario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionario).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFuncionario
            // 
            dataGridViewFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionario.Location = new Point(12, 69);
            dataGridViewFuncionario.Name = "dataGridViewFuncionario";
            dataGridViewFuncionario.RowTemplate.Height = 25;
            dataGridViewFuncionario.Size = new Size(776, 369);
            dataGridViewFuncionario.TabIndex = 0;
            dataGridViewFuncionario.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ConsultarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewFuncionario);
            Name = "ConsultarFuncionario";
            Text = "ConsultarFuncionario";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewFuncionario;
    }
}