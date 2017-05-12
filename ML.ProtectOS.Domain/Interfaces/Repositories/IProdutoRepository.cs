using ML.ProtectOS.Domain.Entities;
using System.Collections.Generic;

namespace ML.ProtectOS.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
