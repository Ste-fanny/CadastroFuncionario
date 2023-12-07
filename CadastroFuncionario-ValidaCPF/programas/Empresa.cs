using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario_ValidaCPF.programas
{
    internal class Empresa
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string Razao_social { get; set;}
        public string Nome_fantasia { get; set; }
        public string Situacao_cadastral { get; set; }
        public DateTime? Data_inicio { get; set; }
        public double Capital_social { get; set; }
        public string Telefone { get; set; }
        public string Natureza_juridica { get; set; }
        public string Nome_proprietario { get; set; }
        public string Cpf_proprietario { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }  
        public string Bairro { get; set; }  
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Regime_tributario { get; set; }
        public string Tipo { get; set; }
        public string Porte_empresa { get; set; }

        public Empresa() { }
        public Empresa(string cnpj, string razao_social, string nome_fantasia, string situacao_cadastral, DateTime? data_inicio, double capital_social, string telefone, string natureza_juridica, string nome_proprietario, string cpf_proprietario, string rua, int numero, string bairro, string cidade, string estado, string regime_tributario, string tipo, string porte_empresa)
        {
            Cnpj = cnpj;
            Razao_social = razao_social;
            Nome_fantasia = nome_fantasia;
            Situacao_cadastral = situacao_cadastral;
            Data_inicio = data_inicio;
            Capital_social = capital_social;
            Telefone = telefone;
            Natureza_juridica = natureza_juridica;
            Nome_proprietario = nome_proprietario;
            Cpf_proprietario = cpf_proprietario;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Regime_tributario = regime_tributario;
            Tipo = tipo;
            Porte_empresa = porte_empresa;
        }
    }
}
