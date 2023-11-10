using CadastroFuncionario_ValidaCPF.programas;

namespace CadastroFuncionario_ValidaCPF
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            texEmail.Text = "";
            texNome.Text = "";
            textCPF.Text = "";
            textRG.Text = "";
            textDataNac.Text = "";
            textTelefone.Text = "";
            textEstadCivil.Text = "";
            textFuncao.Text = "";
            textSalario.Text = "";
            textRuaAv.Text = "";
            textNcasa.Text = "";
            textBairro.Text = "";
            textCodigoCep.Text = "";
            textEstado.Text = "";
            textCiti.Text = "";
            textComplemento.Text = "";
            MessageBox.Show("Senha Incorreta!");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            {
                bool resul = Validarcpf.Validacpf(textCPF.Text);


                MessageBox.Show("Funcionario Cadastrado com sucesso!");

            }
        }
    }
}