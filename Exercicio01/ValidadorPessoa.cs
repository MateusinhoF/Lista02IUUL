using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class ValidadorPessoa
    {
        public ValidadorPessoa() { }

        public void validaNome(string nome) 
        {
            if (nome.Length < 5 && !new Regex(@"[a-zA-Z]").IsMatch(nome))
            {
                throw new NomeInvalidoException("Nome invalido, digite corretamente e com 5 caracteres no minimo");
            }
        }

        public void validaCpf(string cpf)
        {
            if (cpf.Length != 11 && !new Regex(@"[0-9]").IsMatch(cpf))
            {
                throw new CpfInvalidoException("CPF invalido, digite o CPF corretamente");
            }
            else
            {
                int multiplosCPF = 0;
                int multiplicador = 10;
                for(int i = 0; i < 9; i++) {
                    multiplosCPF += int.Parse(cpf.Substring(i,1)) * multiplicador;
                    multiplicador--;
                }

                int resto = multiplosCPF % 11;
                string j = cpf.Substring(9, 1);
                if (resto < 2) {
                    if (j != "0")
                    {
                        throw new CpfInvalidoException("CPF invalido, digite um valor valido");
                    }
                }else if (resto > 1 && resto < 11) {
                    if (j != (11 - resto).ToString())
                    {
                        throw new CpfInvalidoException("CPF invalido, digite um valor valido");
                    }
                }

                multiplosCPF = 0;
                multiplicador = 11;
                for (int i = 0; i < 10; i++)
                {
                    multiplosCPF += int.Parse(cpf.Substring(i, 1)) * multiplicador;
                    multiplicador--;
                }
                resto = multiplosCPF % 11;
                string k = cpf.Substring(10, 1);
                if (resto < 2)
                {
                    if (k != "0")
                    {
                        throw new CpfInvalidoException("CPF invalido, digite um valor valido");
                    }
                }
                else if (resto > 1 && resto < 11)
                {
                    if (k != (11 - resto).ToString())
                    {
                        throw new CpfInvalidoException("CPF invalido, digite um valor valido");
                    }
                }

            }

            bool igual = true;
            for (int i = 0; i < cpf.Length; i++)
            {
                if (cpf.Substring(0,1) != cpf.Substring(i, 1)){
                    igual = false;
                }
            }
            if (igual)
            {
                throw new CpfInvalidoException("CPf invalido, um CPF não repete os mesmo numeros o tempo todo");
            }
            
        }

        public void validaDataNascimento(string dataNascimento)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR", false);
            if (dataNascimento.Length == 10)
            {
                DateTime dataNascimentoDateTime = DateTime.Parse(dataNascimento);

                if (dataNascimentoDateTime.AddYears(18) > DateTime.Now)
                {
                    throw new DataNascimentoInvalidaException("Data de Nascimento invalida, precisa ter no minimo 18 anos");
                }
            }
            else
            {
                throw new DataNascimentoInvalidaException("Data de Nascimento invalida, digite a data corretamente " + dataNascimento.Length);
            }
        }

        public void validaRendaMensal(string rendaMensal)
        {
            if (rendaMensal.Split(',')[1].Length != 2 && !new Regex(@"\,[0-9]").IsMatch(rendaMensal))
            {
                throw new RendaMensalInvalidaException("Renda mensal invalida, digite sua renda corretamente");
            }
        }

        public void validaEstadoCivil(string estadoCivil)
        {
            string valido = "cCsSvVdD";
            if (estadoCivil.Length != 1 && !valido.Contains(estadoCivil))
            {
                throw new EstadoCivilInvalidoException("Estado civil invalido, digite corretamente seu estado civil");
            }
        }

        public void validaDependentes(string dependentes)
        {
            if (!new Regex(@"[0-9]").IsMatch(dependentes) && (int.Parse(dependentes) < 0 || int.Parse(dependentes) > 10))
            {
                throw new DependentesInvalidoException("Dependentes invalido, digite corretamente a quantidade de dependentes. Valido de 0 a 10");
            }
        }

    }
}
