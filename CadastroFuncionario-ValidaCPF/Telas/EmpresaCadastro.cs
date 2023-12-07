using CadastroFuncionario_ValidaCPF.programas;
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
    public partial class EmpresaCadastro : Form
    {
        public EmpresaCadastro()
        {
            InitializeComponent();
        }
        void Inserir(Empresa empresa)
        {
            try
            {
                Conexao conexao = new Conexao();
                var comando = conexao.Comando("INSERT INTO Empresa  VALUES (@id, @cnpj, @razao_social, @nome_fantasia, @situacao_cadastral, @data_inicio, @capita_social, @telefone, @natureza_juridica, @nome_proprietario, @cpf_proprietario, @rua, @numero, @bairro, @cidade, @estado, @regime_tributario, @tipo, @porte_empresa)");

                comando.Parameters.AddWithValue("@id", null);
                comando.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                comando.Parameters.AddWithValue("@razao_social", empresa.Razao_social);
                comando.Parameters.AddWithValue("@nome_fantasia", empresa.Nome_fantasia);
                comando.Parameters.AddWithValue("@situacao_cadastral", empresa.Situacao_cadastral);
                comando.Parameters.AddWithValue("@regime_tributario", empresa.Regime_tributario);
                comando.Parameters.AddWithValue("@data_inicio", empresa.Data_inicio);
                comando.Parameters.AddWithValue("@telefone", empresa.Telefone);
                comando.Parameters.AddWithValue("@capita_social", empresa.Capital_social);
                comando.Parameters.AddWithValue("@rua", empresa.Rua);
                comando.Parameters.AddWithValue("@bairro", empresa.Bairro);
                comando.Parameters.AddWithValue("@numero", empresa.Numero);
                comando.Parameters.AddWithValue("@estado", empresa.Estado);
                comando.Parameters.AddWithValue("@cidade", empresa.Cidade);
                comando.Parameters.AddWithValue("@tipo", empresa.Tipo);
                comando.Parameters.AddWithValue("@porte_empresa", empresa.Porte_empresa);
                comando.Parameters.AddWithValue("@natureza_juridica", empresa.Natureza_juridica);
                comando.Parameters.AddWithValue("@nome_proprietario", empresa.Nome_proprietario);
                comando.Parameters.AddWithValue("@cpf_proprietario", empresa.Cpf_proprietario);


                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Empresa cadastrada com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validarcpf.Validacpf(textCPFProp.Text) == false)
            {
                MessageBox.Show("CPF invalido!");
            }
            else
            {
                string cnpj = texCnpj.Text;
                string razao = texRazaoS.Text;
                string nomeF = texNomeFan.Text;
                string situacaoCadas = texSituacaoCadr.Text;
                DateTime data = Convert.ToDateTime(texDataInc.Text);
                double capitalSocial = Convert.ToDouble(texCapitaSoc.Text);
                string telefone = texTelefone.Text;
                string natureza = texNatureza.Text;
                string nomeProp = texNomeProp.Text;
                string cpfProp = textCPFProp.Text;
                string rua = texRuaa.Text;
                int numeroo = Convert.ToInt32(texNumeroo.Text);
                string bairroo = texBairroo.Text;
                string cidadee = texCidadee.Text;
                string estadoo = texEstadoo.Text;
                string regime_tributario = groupBox3.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                string tipo = groupBox2.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                string porte_empresa = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

                Empresa empresa = new Empresa(cnpj, razao, nomeF, situacaoCadas, data, capitalSocial, telefone, natureza, nomeProp, cpfProp, rua, numeroo, bairroo, cidadee, estadoo, regime_tributario, tipo, porte_empresa);
                Inserir(empresa);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consultar_Empresa consultar_Empresa = new Consultar_Empresa();
            this.Visible = false;
            consultar_Empresa.Visible = true;
        }
    }
}
