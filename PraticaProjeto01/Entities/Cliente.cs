using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaProjeto01.Entities
{
    public class Cliente
    {
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string  Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        // criando uma associação (relacionamento TER 1)
        public Endereco Endereco { get; set; }
    }
}
