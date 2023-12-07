using CadastroFuncionario_ValidaCPF.programas;
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
    public partial class ConsultarFuncionario : Form
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        public ConsultarFuncionario()
        {
            InitializeComponent();
            Consultar();
        }

        void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM funcionario");
                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    var funcionario = new Funcionario();
                    funcionario.Id = leitor.GetInt32("id_fun");
                    funcionario.Nome = DAOHelper.GetString(leitor, "nome_fun");
                    funcionario.Data_nas = DAOHelper.GetDateTime(leitor, "data_nas_fun");
                    funcionario.Cpf = DAOHelper.GetString(leitor, "cpf_fun");
                    funcionario.Rg = DAOHelper.GetString(leitor, "rg_fun");
                    funcionario.Telefone = DAOHelper.GetString(leitor, "telefone_fun");
                    funcionario.Email = DAOHelper.GetString(leitor, "email_fun");
                    funcionario.Rua = DAOHelper.GetString(leitor, "rua_fun");
                    funcionario.Bairro = DAOHelper.GetString(leitor, "bairro_fun");
                    funcionario.Numero = leitor.GetInt32("numero_fun");
                    funcionario.Estado_civil = DAOHelper.GetString(leitor, "estado_civil_fun");
                    funcionario.Funcao = DAOHelper.GetString(leitor, "funcao_fun");
                    funcionario.Salario = DAOHelper.GetDouble(leitor, "salario_fun");
                    funcionario.Estado = DAOHelper.GetString(leitor, "estado_fun");
                    funcionario.Cidade = DAOHelper.GetString(leitor, "cidade_fun");
                    funcionario.Complemento = DAOHelper.GetString(leitor, "complemento_fun");

                    funcionarios.Add(funcionario);
                }
                dataGridViewFuncionario.DataSource = funcionarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
