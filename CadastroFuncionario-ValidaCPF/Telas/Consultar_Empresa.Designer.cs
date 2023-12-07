namespace CadastroFuncionario_ValidaCPF.Telas
{
    partial class Consultar_Empresa
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
            dataGridViewEmpresa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpresa).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmpresa
            // 
            dataGridViewEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpresa.Location = new Point(0, 104);
            dataGridViewEmpresa.Name = "dataGridViewEmpresa";
            dataGridViewEmpresa.RowTemplate.Height = 25;
            dataGridViewEmpresa.Size = new Size(799, 348);
            dataGridViewEmpresa.TabIndex = 0;
            dataGridViewEmpresa.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Consultar_Empresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewEmpresa);
            Name = "Consultar_Empresa";
            Text = "Consultar_Empresa";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpresa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEmpresa;
    }
}