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

        void Inserir(Funcionario funcionario)
        {
            try
            {
                Conexao conexao = new Conexao();
                var comando = conexao.Comando("INSERT INTO Funcionario VALUES (@id,@nome, @data_nas, @cpf, @rg, @telefone, @email, @rua, @bairro, @numero, @estado_civil, @funcao, @salario, @estado, @cidade, @complemento)");

                comando.Parameters.AddWithValue("@id", null);
                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@data_nas", funcionario.Data_nas);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@rg", funcionario.Rg);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@email", funcionario.Email);
                comando.Parameters.AddWithValue("@rua", funcionario.Rua);
                comando.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                comando.Parameters.AddWithValue("@numero", funcionario.Numero);
                comando.Parameters.AddWithValue("@estado_civil", funcionario.Estado_civil);
                comando.Parameters.AddWithValue("@funcao", funcionario.Funcao);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);
                comando.Parameters.AddWithValue("@estado", funcionario.Estado);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                comando.Parameters.AddWithValue("@complemento", funcionario.Complemento);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Funcionario cadastrado com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimparCampos()
        {
            texEmail.Text = "";
            texNome.Text = "";
            textCPF.Text = "";
            textRG.Text = "";
            textTelefone.Text = "";
            textEstadCivil.Text = "";
            textFuncao.Text = "";
            textSalario.Text = "";
            textRuaAv.Text = "";
            textNcasa.Text = "";
            textBairro.Text = "";
            textEstado.Text = "";
            textCiti.Text = "";
            textComplemento.Text = "";
            MessageBox.Show("Senha Incorreta!");
        }
/*
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            {
                
               
                
            }
        }
*/
        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string nome = texNome.Text;
            string email = texEmail.Text;
            DateTime dataNasc = Convert.ToDateTime(dateTimePicker1.Text);
            string cpf = textCPF.Text;
            string rg = textRG.Text;
            string telefone = textTelefone.Text;
            string estadoCiv = textEstadCivil.Text;
            string funcao = textFuncao.Text;
            double salario = Convert.ToDouble(textSalario.Text);
            string rua = textRuaAv.Text;
            string bairro = textBairro.Text;
            int numero = Convert.ToInt32(textNcasa.Text);
            string estado = textEstado.Text;
            string cidade = textCiti.Text;
            string complemento = textComplemento.Text;

            Funcionario fun = new Funcionario(nome, dataNasc, cpf, rg, telefone, email, rua, bairro, numero, estadoCiv, funcao, salario, estado, cidade, complemento);


            if (Validarcpf.Validacpf(textCPF.Text) == false)
            {
                MessageBox.Show("CPF invalido!");
            }
            else
            {
                Inserir(fun);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarFuncionario cf = new ConsultarFuncionario();
            this.Visible = false;
            cf.Visible = true;
        }
    }
}