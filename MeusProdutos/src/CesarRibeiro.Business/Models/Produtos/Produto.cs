using System;
using CesarRibeiro.Business.Core.Models;
using CesarRibeiro.Business.Models.Fornecedores;

namespace CesarRibeiro.Business.Models.Produtos
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public Guid FornecedorId { get; set; }
        /* EF Relations */
        public Fornecedor Fornecedor { get; set; }
    }
}
