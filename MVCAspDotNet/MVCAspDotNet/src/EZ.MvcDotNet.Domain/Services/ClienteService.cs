using System;
using System.Collections.Generic;
using EZ.MvcDotNet.Domain.Entities;
using EZ.MvcDotNet.Domain.Interfaces.Repository;
using EZ.MvcDotNet.Domain.Interfaces.Services;

namespace EZ.MvcDotNet.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public void Adicionar(Cliente cliente)
        {
            _clienteRepository.Adicionar(cliente);
        }

        public Cliente ObterPorId(Guid id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Atualizar(Cliente cliente)
        {
            _clienteRepository.Atualizar(cliente);
        }

        public void Remover(Guid id)
        {
            _clienteRepository.Remover(id);
        }

        public Cliente ObterPorCPF(string cpf)
        {
            return _clienteRepository.ObterPorCPF(cpf);
        }

        public Cliente ObterPorEmail(string email)
        {
            return _clienteRepository.ObterPorEmail(email);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}