using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;
using Microsoft.AspNetCore.Http;

namespace MyFinance.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login(int? id)
        {
            if(id != null)
            {
                if(id == 0)
                {
                    //HttpContext.Session.SetString("NomeUsuarioLogado", String.Empty);
                    //HttpContext.Session.SetString("IdUsuarioLogado", String.Empty);
                    HttpContext.Session.Clear();
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult ValidarLogin(UsuarioModel usuario)
        {
            bool login = usuario.ValidarLogin();
            if (login)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.Nome);
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.Id.ToString());
                return RedirectToAction("Menu", "Home");
            }
            else
            {
                TempData["msg"] = "Dados inválidos";
                return RedirectToAction("Login");
            }
                
        }

        [HttpPost]        
        public IActionResult Registrar(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.RegistrarUsuario();
                return RedirectToAction("Sucesso");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        public IActionResult Sucesso()
        {
            return View();
        }

    }
}