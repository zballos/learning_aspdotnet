using DomainValidation.Interfaces.Specification;
using EZ.MvcDotNet.Domain.Entities;
using EZ.MvcDotNet.Domain.Validation.Documentos;

namespace EZ.MvcDotNet.Domain.Specification.Clientes
{
    public class ClienteDevePossuirCpfValidoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return CPFValidation.Validar(cliente.CPF);
        }
    }
}