using System.Linq;
using EZ.MvcDotNet.Domain.Entities;
using EZ.MvcDotNet.Domain.Interfaces.Repository;
using EZ.MvcDotNet.Domain.Validation.Clientes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace EZ.MvcDotNet.Domain.Tests.Validations
{
    [TestClass]
    public class ClienteAptoParaCadastroTests
    {
        public Cliente Cliente { get; set; }

        [TestMethod]
        public void ClienteApto_Validation_True()
        {
            Cliente = new Cliente()
            {
                CPF = "46265453351",
                Email = "teste@teste.com"
            };

            Cliente.Enderecos.Add(new Endereco());

            var stubRepo = MockRepository.GenerateStub<IClienteRepository>();
            stubRepo.Stub(s => s.ObterPorCPF(Cliente.CPF)).Return(null);
            stubRepo.Stub(s => s.ObterPorEmail(Cliente.Email)).Return(null);

            var cliValidation = new ClienteAptoParaInclusaoValidation(stubRepo);
            Assert.IsTrue(cliValidation.Validate(Cliente).IsValid);
        }

        [TestMethod]
        public void ClienteApto_Validation_False()
        {
            Cliente = new Cliente()
            {
                CPF = "46265453351",
                Email = "teste@teste.com"
            };

            var clienteResult = Cliente;

            var stubRepo = MockRepository.GenerateStub<IClienteRepository>();
            stubRepo.Stub(s => s.ObterPorCPF(Cliente.CPF)).Return(clienteResult);
            stubRepo.Stub(s => s.ObterPorEmail(Cliente.Email)).Return(clienteResult);

            var cliValidation = new ClienteAptoParaInclusaoValidation(stubRepo);
            var result = cliValidation.Validate(Cliente);

            Assert.IsFalse(result.IsValid);
            Assert.IsTrue(result.Erros.Any(e => e.Message == "CPF já cadastrado! Esqueceu sua senha?"));
            Assert.IsTrue(result.Erros.Any(e => e.Message == "Email já cadastrado! Esqueceu sua senha?"));

        }
    }
}