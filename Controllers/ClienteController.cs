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

        public IActionResult Listar()
        {

            ViewBag.ListaClientes = new ClienteModel().ListarTodosClientes();

            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            if (id!= null)
            {
                //Carregar o registro do cliente em uma ViewBag
                ViewBag.Cliente = new ClienteModel().RetornarCliente(id);
            }  

            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ClienteModel cliente)
        {

            if (ModelState.IsValid)
            {
                cliente.Gravar();
                return RedirectToAction("Listar", "Cliente");
            }

            return View();
        }
        public IActionResult Excluir(int id)
        {
            ViewData["IdExcluir"] = id;


            return View();
        }

        public IActionResult ExcluirCliente(int id)
        {
            new ClienteModel().Excluir(id);
            return View();
        }

        public IActionResult Filtrar (string filtro){

            ViewBag.ListaClientesFiltro = new ClienteModel().Filtrar(filtro);
            return View();
        }

        
    }
}