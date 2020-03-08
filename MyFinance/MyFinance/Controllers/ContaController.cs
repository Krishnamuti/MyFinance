using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class ContaController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;

        public ContaController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            ContaModel contaModel = new ContaModel(HttpContextAccessor);
            ViewBag.ListarConta = contaModel.ListarConta();
            return View();
        }
        [HttpGet]
        public IActionResult CriarConta()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CriarConta(ContaModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.Insert();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult ExcluirConta(int id)
        {
            ContaModel contaModel = new ContaModel(HttpContextAccessor);
            contaModel.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}