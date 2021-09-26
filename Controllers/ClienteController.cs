using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testeTempus.Models;

namespace testeTempus.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ClienteModel cliente)
        {

            if (ModelState.IsValid)
            {
                cliente.Gravar();
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}