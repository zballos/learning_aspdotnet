using System;
using System.Collections.Generic;
using EZ.MvcDotNet.Domain.Entities;

namespace EZ.MvcDotNet.Application.Interface
{
    public interface IClienteAppService : IDisposable
    {
        void Adicionar(Cliente obj);

        Cliente ObterPorId(Guid id);

        IEnumerable<Cliente> ObterTodos();

        void Atualizar(Cliente obj);

        void Remover(Guid id);

        Cliente ObterPorCPF(string cpf);

        Cliente ObterPorEmail(string email);
    }
}