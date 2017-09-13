using EZ.MvcDotNet.Domain.Entities;

namespace EZ.MvcDotNet.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorCPF(string cpf);

        Cliente ObterPorEmail(string email);
    }
}