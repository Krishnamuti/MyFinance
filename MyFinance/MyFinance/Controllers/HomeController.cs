using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string idUsuario = HttpContext.Session.GetString("IdUsuarioLogado");
            if (!String.IsNullOrEmpty(idUsuario))
                return RedirectToAction("Menu", "Home");
            else
                return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Ajuda()
        {
            return View();
        }

    }
}
