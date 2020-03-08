using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class TransacaoController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;

        public TransacaoController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            TransacaoModel transacaoModel = new TransacaoModel(HttpContextAccessor);
            ViewBag.ListaTransacao = transacaoModel.ListaTransacao();
            return View();
        }

        [HttpGet]
        public IActionResult Registrar(int? id)
        {
            if (id != null)
            {
                TransacaoModel transacaoModel = new TransacaoModel(HttpContextAccessor);
                ViewBag.Registro = transacaoModel.CarregarRegistro((int)id);
            }
            ViewBag.ListaContas = new ContaModel(HttpContextAccessor).ListarConta();
            ViewBag.PlanoContas = new PlanoContaModel(HttpContextAccessor).ListaPlanoConta();
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(TransacaoModel formulario)
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
        public IActionResult ExcluirTransacao(int id)
        {
            TransacaoModel transacaoModel = new TransacaoModel(HttpContextAccessor);
            ViewBag.Registro = transacaoModel.CarregarRegistro((int)id);
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            TransacaoModel transacaoModel = new TransacaoModel(HttpContextAccessor);
            transacaoModel.Excluir(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [HttpPost]
        public IActionResult Extrato(TransacaoModel formulario)
        {
            formulario.HttpContextAccessor = HttpContextAccessor;
            ViewBag.ListaTransacao = formulario.ListaTransacao();
            ViewBag.ListaContas = new ContaModel(HttpContextAccessor).ListarConta();
            return View();
        }

        public IActionResult Dashboard()
        {
            
            List<Dashboard> lista = new Dashboard(HttpContextAccessor).RetornarDadosGraficosPie();
            string valores = "";
            string labels = "";
            string cores = "";

            for (int i = 0; i < lista.Count; i++)
            {
                valores += lista[i].Total.ToString() + (i < lista.Count ? "," : "");
                labels += "'" + lista[i].PlanoConta.ToString() + "'" + (i < lista.Count ? "," : "");
                cores += "'" + String.Format("#{0:X6}", new Random().Next(0x1000000)) + "'" + (i < lista.Count ? "," : "");
            }

            ViewBag.Cores = cores;//"'#6A5ACD','#2F4F4F','#00FA9A','#BA55D3','#FF4500'";
            ViewBag.Labels = labels;
            ViewBag.Valores = valores;

            return View();

        }

    }
}