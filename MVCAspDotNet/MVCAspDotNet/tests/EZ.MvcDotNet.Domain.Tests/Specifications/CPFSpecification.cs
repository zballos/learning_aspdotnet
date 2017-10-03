using EZ.MvcDotNet.Domain.Entities;
using EZ.MvcDotNet.Domain.Specification.Clientes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EZ.MvcDotNet.Domain.Tests.Specifications
{
    [TestClass]
    public class CPFSpecification
    {
        public Cliente Cliente { get; set; }

        [TestMethod]
        public void CPF_Valido_True()
        {
            Cliente = new Cliente
            {
                CPF = "46265453351"
            };

            var cpf = new ClienteDevePossuirCpfValidoSpecification();
            Assert.IsTrue(cpf.IsSatisfiedBy(Cliente));
        }

        [TestMethod]
        public void CPF_Valido_False()
        {
            Cliente = new Cliente
            {
                CPF = "46265453352"
            };

            var cpf = new ClienteDevePossuirCpfValidoSpecification();
            Assert.IsFalse(cpf.IsSatisfiedBy(Cliente));
        }
    }
}