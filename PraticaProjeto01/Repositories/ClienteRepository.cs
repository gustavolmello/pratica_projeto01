using PraticaProjeto01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//define a localização da classe
namespace PraticaProjeto01.Repositories
{
    //declaração da classe
    public class ClienteRepository
    {
        //metodo para gravação de dados em arquivos
        public void ExportarDados(Cliente cliente)
        {
            //abrindo um arquivo em modo de escrita
            var streamWriter = new StreamWriter("c:\\temp\\praticaclientes.txt", true);

            //escrevendo os dados do cliente no arquivo
            streamWriter.WriteLine("Ïd Cliente..:" + cliente.IdCliente);
            streamWriter.WriteLine("Nome........:" + cliente.Nome);
            streamWriter.WriteLine("Email.......:" + cliente.Email);
            streamWriter.WriteLine("CPF.........:" + cliente.Cpf);
            streamWriter.WriteLine("Data Nasc...:" + cliente.DataNascimento);
            streamWriter.WriteLine("Id Endereço.:" + cliente.Endereco.IdEndereco);
            streamWriter.WriteLine("Logradouro..:" + cliente.Endereco.Logradouro);
            streamWriter.WriteLine("Número......:" + cliente.Endereco.Numero);
            streamWriter.WriteLine("Bairro......:" + cliente.Endereco.Bairro);
            streamWriter.WriteLine("Cidade......:" + cliente.Endereco.Cidade);
            streamWriter.WriteLine("Estado......:" + cliente.Endereco.Estado);
            streamWriter.WriteLine("CEP.........:" + cliente.Endereco.Cep);
            streamWriter.WriteLine("\n");

            //fechar o arquivo
            streamWriter.Close();
        }
    }
}
