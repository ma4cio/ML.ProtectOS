using ML.ProtectOS.Domain.Entities;
using System.Collections.Generic;

namespace ML.ProtectOS.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
