using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula1AspNetMVC.Context;
using Aula1AspNetMVC.Models;

namespace Aula1AspNetMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Aula1Context().Cliente.SingleOrDefault(c => c.Id == 1);

            ViewBag.Cliente = cliente; // versão nova
            //ViewData["Cliente"] = cliente; // versão antiga, pouco usada

            return View(cliente);
        }

        public ActionResult Lista()
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente(){Nome = "João", SobreNome = "Da Silva", DataCadastro = DateTime.Now, Id = 1},
                new Cliente(){Nome = "Marcos", SobreNome = "de Souza", DataCadastro = DateTime.Now, Id = 2},
            };

            return View(listaClientes);
        }

        public ActionResult Pesquisa(int? id, string nome)
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente(){Nome = "João", SobreNome = "Da Silva", DataCadastro = DateTime.Now, Id = 1},
                new Cliente(){Nome = "Marcos", SobreNome = "de Souza", DataCadastro = DateTime.Now, Id = 2},
                new Cliente(){Nome = "Fulano", SobreNome = "Beltrano", DataCadastro = DateTime.Now, Id = 3},
                new Cliente(){Nome = "Jones", SobreNome = "Brito", DataCadastro = DateTime.Now, Id = 4},
                new Cliente(){Nome = "Fera", SobreNome = "Aluno", DataCadastro = DateTime.Now, Id = 5},
            };

            var cliente = listaClientes.Where(c => c.Nome == nome).ToList();

            if (!cliente.Any())
            {
                TempData["erro"] = "Nenhum cliente encontrado!";
                return RedirectToAction("ErroPesquisa");
            }

            return View("Lista", cliente);
        }

        public ActionResult ErroPesquisa()
        {
            return View("Error");
        }
    }
}