using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EZ.MvcDotNet.UI.MVC.Controllers
{
    [RoutePrefix("ADM/Gestao/Clientes")]
    [Route("{action=Index}")]
    public class TesteController : Controller
    {
        // GET: Teste
        [Route("Lista")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("Cliente/{idcliente:int}/Editar/{idcategoria:int}/Categoria")]
        public ActionResult Editar(int idcliente, int idcategoria)
        {
            return View("Index");
        }
    }
}