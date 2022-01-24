using System;
using System.Threading.Tasks;
using CesarRibeiro.Business.Core.Data;

namespace CesarRibeiro.Business.Models.Fornecedores
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);

    }
}
