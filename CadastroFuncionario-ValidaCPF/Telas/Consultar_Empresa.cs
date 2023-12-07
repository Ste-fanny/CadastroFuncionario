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

namespace CadastroFuncionario_ValidaCPF.Telas
{
    public partial class Consultar_Empresa : Form
    {
        List<Empresa> empresas = new List<Empresa>();
        public Consultar_Empresa()
        {
            InitializeComponent();
            Consultar();
        }
        void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM Empresa");
                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    var empresa = new Empresa();
                    empresa.Id = leitor.GetInt32("id_emp");
                    empresa.Cnpj = DAOHelper.GetString(leitor, "cnpj_emp");
                    empresa.Razao_social = DAOHelper.GetString(leitor, "razao_social_emp");
                    empresa.Nome_fantasia = DAOHelper.GetString(leitor, "nome_fantasia_emp");
                    empresa.Situacao_cadastral = DAOHelper.GetString(leitor, "situacao_cadastral_emp");
                    empresa.Regime_tributario = DAOHelper.GetString(leitor, "regime_tributario_emp");
                    empresa.Data_inicio = DAOHelper.GetDateTime(leitor, "data_inicio_emp");
                    empresa.Telefone = DAOHelper.GetString(leitor, "telefone_emp");
                    empresa.Capital_social = DAOHelper.GetDouble(leitor, "capital_social_emp");
                    empresa.Rua = DAOHelper.GetString(leitor, "rua_emp");
                    empresa.Bairro = DAOHelper.GetString(leitor, "bairro_emp");
                    empresa.Numero = leitor.GetInt32("numero_emp");
                    empresa.Estado = DAOHelper.GetString(leitor, "estado_emp");
                    empresa.Cidade = DAOHelper.GetString(leitor, "cidade_emp");
                    empresa.Tipo = DAOHelper.GetString(leitor, "tipo_emp");
                    empresa.Porte_empresa = DAOHelper.GetString(leitor, "porte_empresa_emp");
                    empresa.Natureza_juridica = DAOHelper.GetString(leitor, "natureza_juridica_emp");
                    empresa.Nome_proprietario = DAOHelper.GetString(leitor, "nome_prop_emp");
                    empresa.Cpf_proprietario = DAOHelper.GetString(leitor, "cpf_prop_emp");


                    empresas.Add(empresa);
                }
                dataGridViewEmpresa.DataSource = empresas;
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
