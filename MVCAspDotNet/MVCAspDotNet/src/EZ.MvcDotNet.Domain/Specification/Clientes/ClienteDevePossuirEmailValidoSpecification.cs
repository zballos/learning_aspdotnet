using DomainValidation.Interfaces.Specification;
using EZ.MvcDotNet.Domain.Entities;
using EZ.MvcDotNet.Domain.Validation.Email;

namespace EZ.MvcDotNet.Domain.Specification.Clientes
{
    public class ClienteDevePossuirEmailValidoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return EmailValidation.Validate(cliente.Email);
        }
    }
}