using System;
using System.Collections.Generic;
using EZ.MvcDotNet.Application.ViewModels;
using EZ.MvcDotNet.Domain.Entities;

namespace EZ.MvcDotNet.Application.Interface
{
    public interface IClienteAppService : IDisposable
    {
        void Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel);

        ClienteViewModel ObterPorId(Guid id);

        IEnumerable<ClienteViewModel> ObterTodos();

        void Atualizar(ClienteViewModel clienteViewModel);

        void Remover(Guid id);

        ClienteViewModel ObterPorCPF(string cpf);

        ClienteViewModel ObterPorEmail(string email);
    }
}