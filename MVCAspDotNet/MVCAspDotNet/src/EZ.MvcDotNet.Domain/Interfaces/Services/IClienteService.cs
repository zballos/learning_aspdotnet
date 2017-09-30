using System;
using System.Collections.Generic;
using EZ.MvcDotNet.Domain.Entities;

namespace EZ.MvcDotNet.Domain.Interfaces.Services
{
    public interface IClienteService : IDisposable
    {
        Cliente Adicionar(Cliente cliente);

        Cliente ObterPorId(Guid id);

        IEnumerable<Cliente> ObterTodos();

        void Atualizar(Cliente cliente);

        void Remover(Guid id);

        Cliente ObterPorCPF(string cpf);

        Cliente ObterPorEmail(string email);
    }
}