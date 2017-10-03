using System;
using System.Linq;
using EZ.MvcDotNet.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EZ.MvcDotNet.Domain.Tests.Entities
{
    [TestClass]
    public class ClienteTests
    {
        public Cliente Cliente { get; set; }

        [TestMethod]
        public void ClienteConsistente_Valid_True()
        {
            Cliente = new Cliente
            {
                CPF = "46265453351",
                DataNascimento = new DateTime(1992, 04, 30),
                Email = "teste@test.com"
            };

            Assert.IsTrue(Cliente.IsValid());
        }

        [TestMethod]
        public void ClienteConsistente_Valid_False()
        {
            Cliente = new Cliente
            {
                CPF = "46265453352",
                DataNascimento = new DateTime(2005, 04, 30),
                Email = "teste2test.com"
            };

            Assert.IsFalse(Cliente.IsValid());
            Assert.IsTrue(Cliente.ValidationResult.Erros.Any(e => e.Message == "Cliente informou um CPF inválido."));
            Assert.IsTrue(Cliente.ValidationResult.Erros.Any(e => e.Message == "Cliente informou um Email inválido."));
            Assert.IsTrue(Cliente.ValidationResult.Erros.Any(e => e.Message == "Cliente não tem maioridade para cadastro."));
        }
    }
}