using DomainValidation.Interfaces.Specification;
using EZ.MvcDotNet.Domain.Entities;
using EZ.MvcDotNet.Domain.Interfaces.Repository;

namespace EZ.MvcDotNet.Domain.Specification.Clientes
{
    public class ClienteDevePossuirCpfUnicoSpecification : ISpecification<Cliente>
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteDevePossuirCpfUnicoSpecification(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public bool IsSatisfiedBy(Cliente cliente)
        {
            return _clienteRepository.ObterPorCPF(cliente.CPF) == null;
        }
    }
}