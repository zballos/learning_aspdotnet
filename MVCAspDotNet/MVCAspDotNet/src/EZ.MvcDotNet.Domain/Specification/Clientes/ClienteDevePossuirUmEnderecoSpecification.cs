using System.Linq;
using DomainValidation.Interfaces.Specification;
using EZ.MvcDotNet.Domain.Entities;

namespace EZ.MvcDotNet.Domain.Specification.Clientes
{
    public class ClienteDevePossuirUmEnderecoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return cliente.Enderecos != null && cliente.Enderecos.Any();
        }
    }
}