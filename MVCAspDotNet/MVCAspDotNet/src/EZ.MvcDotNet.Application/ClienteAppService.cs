using System;
using System.Collections.Generic;
using AutoMapper;
using EZ.MvcDotNet.Application.Interface;
using EZ.MvcDotNet.Application.ViewModels;
using EZ.MvcDotNet.Domain.Entities;
using EZ.MvcDotNet.Domain.Interfaces.Services;

namespace EZ.MvcDotNet.Application
{
    public class ClienteAppService : AppService, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public void Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<ClienteEnderecoViewModel, Cliente>(clienteEnderecoViewModel);
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEnderecoViewModel);

            cliente.Enderecos.Add(endereco);

            BeginTransaction();

            _clienteService.Adicionar(cliente);

            // Toma decisão do commit
            Commit();
        }

        public void Atualizar(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);

            _clienteService.Atualizar(cliente);
        }

        public ClienteViewModel ObterPorCPF(string cpf)
        {
            return Mapper.Map < Cliente, ClienteViewModel > (_clienteService.ObterPorCPF(cpf));
        }

        public ClienteViewModel ObterPorEmail(string email)
        {
            return Mapper.Map < Cliente, ClienteViewModel > (_clienteService.ObterPorEmail(email));
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.ObterPorId(id));
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return Mapper.Map < IEnumerable<Cliente>, IEnumerable<ClienteViewModel> > (_clienteService.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _clienteService.Remover(id);
        }

        public void Dispose()
        {
            _clienteService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}