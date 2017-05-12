using ML.ProtectOS.Domain.Entities;
using ML.ProtectOS.Domain.Interfaces.Repositories;
using ML.ProtectOS.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ML.ProtectOS.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
