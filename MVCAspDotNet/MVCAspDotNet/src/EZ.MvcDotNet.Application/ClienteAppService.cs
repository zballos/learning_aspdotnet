using System;
using System.Collections.Generic;
using EZ.MvcDotNet.Application.Interface;
using EZ.MvcDotNet.Domain.Entities;
using EZ.MvcDotNet.Infra.Data.Repository;

namespace EZ.MvcDotNet.Application
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly ClienteRepository clienteRepository = new ClienteRepository();

        public void Adicionar(Cliente cliente)
        {
            clienteRepository.Adicionar(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            clienteRepository.Atualizar(cliente);
        }

        public Cliente ObterPorCPF(string cpf)
        {
            return clienteRepository.ObterPorCPF(cpf);
        }

        public Cliente ObterPorEmail(string email)
        {
            return clienteRepository.ObterPorEmail(email);
        }

        public Cliente ObterPorId(Guid id)
        {
            return clienteRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return clienteRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            clienteRepository.Remover(id);
        }

        public void Dispose()
        {
            clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}