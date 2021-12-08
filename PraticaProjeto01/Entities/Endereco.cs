using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaProjeto01.Entities
{
    public class Endereco
    {
        //prop + 2x[tab]
        public Guid IdEndereco { get; set; }
        public string  Logradouro { get; set; }
        public string  Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
