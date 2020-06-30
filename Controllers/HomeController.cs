using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetVet.Models;

namespace PetVet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult Agendamento()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agendamento(Agendar animais)
        {
            ListaAgendamentos.Adicionar(animais);
            return View("Listagem", ListaAgendamentos.Listar());
        }

        public IActionResult Listagem()
        {
            List<Agendar> animaisAgendados = ListaAgendamentos.Listar();
            return View(animaisAgendados);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
