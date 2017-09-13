using System.Linq;
using EZ.MvcDotNet.Domain.Entities;
using EZ.MvcDotNet.Domain.Interfaces.Repository;

namespace EZ.MvcDotNet.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public Cliente ObterPorCPF(string cpf)
        {
            return Buscar(c => c.CPF == cpf).FirstOrDefault();
        }

        public Cliente ObterPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }
    }
}