using System;
using DomainValidation.Interfaces.Specification;
using EZ.MvcDotNet.Domain.Entities;

namespace EZ.MvcDotNet.Domain.Specification.Clientes
{
    public class ClienteDeveSerMaiorDeIdadeSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            // superficial
            return DateTime.Now.Year - cliente.DataNascimento.Year >= 18;
        }
    }
}