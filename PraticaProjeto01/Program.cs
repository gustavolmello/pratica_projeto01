using PraticaProjeto01.Entities;
using PraticaProjeto01.Repositories;
using System;

namespace PraticaProjeto01
{
    class Program
    {
        //Método para execução do projeto
        static void Main(string[] args)
        {
            //instanciando a classe Cliente
            var cliente = new Cliente();

            //instanciando a classe Endereço dentro de cliente
            cliente.Endereco = new Endereco();

            //gerando o id do cliente
            cliente.IdCliente = Guid.NewGuid();

            //gerando o id do endereço
            cliente.Endereco.IdEndereco = Guid.NewGuid();

            Console.Write("Informe o nome do cliente......: ");
            cliente.Nome = Console.ReadLine(); //set

            Console.Write("Informe o e-mail do cliente....: ");
            cliente.Email = Console.ReadLine(); //set

            Console.Write("Informe o CPF do cliente.......: ");
            cliente.Cpf = Console.ReadLine(); //set

            Console.Write("Informe a data de nascimento...: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine()); //set

            Console.Write("Informe o logradouro...........: ");
            cliente.Endereco.Logradouro = Console.ReadLine(); //set

            Console.Write("Informe o número...............: ");
            cliente.Endereco.Numero = Console.ReadLine(); //set

            Console.Write("Informe o bairro...............: ");
            cliente.Endereco.Bairro = Console.ReadLine(); //set

            Console.Write("Informe a cidade...............: ");
            cliente.Endereco.Cidade = Console.ReadLine(); //set

            Console.Write("Informe o estado...............: ");
            cliente.Endereco.Estado = Console.ReadLine(); //set

            Console.Write("Informe o CEP..................: ");
            cliente.Endereco.Cep = Console.ReadLine(); //set


            //imprimindo
            //cw + 2X[tab]
            Console.WriteLine("\n DADOS DO CLIENTE:\n");

            Console.WriteLine("Id do cliente......:" + cliente.IdCliente);
            Console.WriteLine("Nome do cliente....:" + cliente.Nome);
            Console.WriteLine("Email do cliente...:" + cliente.Email);
            Console.WriteLine("CPF do cliente.....:" + cliente.Cpf);
            Console.WriteLine("Data de nascimento.:" + cliente.DataNascimento);

            Console.WriteLine("\n ENDEREÇO DO CLIENTE:\n");

            Console.WriteLine("Id do endereço.....:" + cliente.Endereco.IdEndereco);
            Console.WriteLine("Logradouro.........:" + cliente.Endereco.Logradouro);
            Console.WriteLine("Número.............:" + cliente.Endereco.Numero);
            Console.WriteLine("Bairro.............:" + cliente.Endereco.Bairro);
            Console.WriteLine("Cidade.............:" + cliente.Endereco.Cidade);
            Console.WriteLine("Estado.............:" + cliente.Endereco.Estado);
            Console.WriteLine("CEP................:" + cliente.Endereco.Cep);

            try
            {
               // objeto
               var clienteRepository = new ClienteRepository();

                //executando o método para gravar o arquivo
                clienteRepository.ExportarDados(cliente);

                Console.WriteLine("\nArquivo TXT gravado com sucesso!");
            }
            catch(Exception e)
            {
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }

            //pausar o prompt do DOS
            Console.ReadKey();
        }
    }
}
