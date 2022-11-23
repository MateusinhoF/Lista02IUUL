using System.Globalization;
using System.Text.RegularExpressions;

namespace Exercicio01
{
    public class Cadastro
    {

        public static void Main(String[] args)
        {
            string nome = null;
            string cpf = null;
            string dataNascimento = null;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR", false);
            string rendaMensal = null;
            string estadoCivil = null;
            string dependentes = null;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu cpf sem pontuações");
            cpf = Console.ReadLine();

            Console.WriteLine("Digite sua data de nascimento no formato DD/MM/AAAA");
            dataNascimento = Console.ReadLine();

            Console.WriteLine("Digite sua renda mensal separando com , o valor dos centavos exemplo 1850,50");
            rendaMensal = Console.ReadLine();

            Console.WriteLine("Digite seu estado civil sendo C casado(a) S solteiro(a) V viuvo(a) D divorciado(a)");
            estadoCivil = Console.ReadLine();

            Console.WriteLine("Digite o numero de dependentes");
            dependentes = Console.ReadLine();

            try
            {
                ValidadorPessoa validaPessoa = new ValidadorPessoa();
                validaPessoa.validaNome(nome);
                validaPessoa.validaCpf(cpf);
                validaPessoa.validaDataNascimento(dataNascimento);
                validaPessoa.validaRendaMensal(rendaMensal);
                validaPessoa.validaEstadoCivil(estadoCivil);
                validaPessoa.validaDependentes(dependentes);

            }
            catch (NomeInvalidoException e) 
            { 
                Console.WriteLine(e);
                Console.WriteLine("Digite o seu nome novamente");
                nome = Console.ReadLine();
            }
            catch (CpfInvalidoException e) 
            { 
                Console.WriteLine(e);
                Console.WriteLine("Digite o seu CPF novamente");
                cpf = Console.ReadLine();
            }
            catch (DataNascimentoInvalidaException e) 
            { 
                Console.WriteLine(e);
                Console.WriteLine("Digite o sua Data de Nascimento novamente");
                dataNascimento = Console.ReadLine();
            }
            catch (RendaMensalInvalidaException e) 
            { 
                Console.WriteLine(e);
                Console.WriteLine("Digite o sua Renda Mensal novamente");
                rendaMensal = Console.ReadLine();
            }
            catch (EstadoCivilInvalidoException e) 
            { 
                Console.WriteLine(e);
                Console.WriteLine("Digite o seu Estado Civil novamente");
                estadoCivil = Console.ReadLine();
            }
            catch (DependentesInvalidoException e) 
            { 
                Console.WriteLine(e);
                Console.WriteLine("Digite a quantidade de dependentes novamente");
                dependentes = Console.ReadLine();
            }
            finally
            {
                Pessoa pessoa = new Pessoa(nome, long.Parse(cpf), DateTime.Parse(dataNascimento), float.Parse(rendaMensal), char.Parse(estadoCivil), int.Parse(dependentes));
                pessoa.imprimirPessoa();
            }

        }
    }
}