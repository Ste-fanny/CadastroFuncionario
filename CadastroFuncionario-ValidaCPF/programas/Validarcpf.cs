using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario_ValidaCPF.programas
{
    internal class Validarcpf
    {
        public static bool Validacpf(string cpf)
        {

            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }

            int mult1 = Convert.ToInt32(cpf[0].ToString()) * 10;
            int mult2 = Convert.ToInt32(cpf[1].ToString()) * 9;
            int mult3 = Convert.ToInt32(cpf[2].ToString()) * 8;
            int mult4 = Convert.ToInt32(cpf[3].ToString()) * 7;
            int mult5 = Convert.ToInt32(cpf[4].ToString()) * 6;
            int mult6 = Convert.ToInt32(cpf[5].ToString()) * 5;
            int mult7 = Convert.ToInt32(cpf[6].ToString()) * 4;
            int mult8 = Convert.ToInt32(cpf[7].ToString()) * 3;
            int mult9 = Convert.ToInt32(cpf[8].ToString()) * 2;

            int soma = mult1 + mult2 + mult3 + mult4 + mult5 + mult6 + mult7 + mult8 + mult9;

            int resto = soma % 11;

            if (resto < 2)
            {
                if (Convert.ToInt32(cpf[9].ToString()) != 0)
                {
                    return false;
                }
            }
            else if (resto >= 2)
            {
                if (Convert.ToInt32(cpf[9].ToString()) != 11 - resto)
                {
                    return false;
                }
            }

            int ana0 = Convert.ToInt32(cpf[0].ToString()) * 11;
            int ana1 = Convert.ToInt32(cpf[1].ToString()) * 10;
            int ana2 = Convert.ToInt32(cpf[2].ToString()) * 9;
            int ana3 = Convert.ToInt32(cpf[3].ToString()) * 8;
            int ana4 = Convert.ToInt32(cpf[4].ToString()) * 7;
            int ana5 = Convert.ToInt32(cpf[5].ToString()) * 6;
            int ana6 = Convert.ToInt32(cpf[6].ToString()) * 5;
            int ana7 = Convert.ToInt32(cpf[7].ToString()) * 4;
            int ana8 = Convert.ToInt32(cpf[8].ToString()) * 3;
            int ana9 = Convert.ToInt32(cpf[9].ToString()) * 2;

            int soma1 = ana0 + ana1 + ana2 + ana3 + ana4 + ana5 + ana6 + ana7 + ana8 + ana9;

            int resto1 = soma1 % 11;

            if (resto1 < 2)
            {
                if (Convert.ToInt32(cpf[10].ToString()) != 0)
                {
                    return false;
                }
            }
            else if (resto1 >= 2)
            {
                if (Convert.ToInt32(cpf[10].ToString()) != 11 - resto)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
