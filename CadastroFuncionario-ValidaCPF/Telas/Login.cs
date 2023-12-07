using CadastroFuncionario_ValidaCPF.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario_ValidaCPF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();

            this.Visible = false;
            this.Visible = true;
            cadastro.Show();

            //Oculta o Formulario

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpresaCadastro empresa = new EmpresaCadastro();
            this.Visible = false;
            empresa.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consultar_Empresa empresa = new Consultar_Empresa();
            this.Visible = false;
            empresa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarFuncionario  consultarFuncionario = new ConsultarFuncionario();
            this.Visible = false;
            consultarFuncionario.Show();
            this.Hide();
        }
    }
}
