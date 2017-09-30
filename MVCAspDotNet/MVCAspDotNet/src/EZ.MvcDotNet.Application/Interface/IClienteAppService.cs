using System;
using System.Collections.Generic;
using EZ.MvcDotNet.Application.ViewModels;

namespace EZ.MvcDotNet.Application.Interface
{
    public interface IClienteAppService : IDisposable
    {
        ClienteViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel);

        ClienteViewModel ObterPorId(Guid id);

        IEnumerable<ClienteViewModel> ObterTodos();

        void Atualizar(ClienteViewModel clienteViewModel);

        void Remover(Guid id);

        ClienteViewModel ObterPorCPF(string cpf);

        ClienteViewModel ObterPorEmail(string email);
    }
}