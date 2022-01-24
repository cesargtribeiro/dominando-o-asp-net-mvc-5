using System.Collections.Generic;
using CesarRibeiro.Business.Core.Models;
using CesarRibeiro.Business.Models.Produtos;

namespace CesarRibeiro.Business.Models.Fornecedores
{
    public class Endereco : Entity
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Fornecedor Fornecedor { get; set; }

        /* EF Relations */
        public ICollection<Produto> Produtos { get; set; }

    }
}
