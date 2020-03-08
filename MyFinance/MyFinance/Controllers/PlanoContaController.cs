using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class PlanoContaController : Controller
    {
        Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor;

        public PlanoContaController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            PlanoContaModel planoContasModel = new PlanoContaModel(HttpContextAccessor);
            ViewBag.ListaPlanoConta = planoContasModel.ListaPlanoConta();
            return View();
        }

        [HttpGet]
        public IActionResult CriarPlanoConta(int? id)
        {
            if(id != null)
            {
                PlanoContaModel planoContasModel = new PlanoContaModel(HttpContextAccessor);
                ViewBag.Registro = planoContasModel.CarregarRegistro((int)id);
            }
            return View();
        }
        [HttpPost]
        public IActionResult CriarPlanoConta(PlanoContaModel formulario)
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
        public IActionResult ExcluirPlanoConta(int id)
        {
            PlanoContaModel planoContasModel = new PlanoContaModel(HttpContextAccessor);
            planoContasModel.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}