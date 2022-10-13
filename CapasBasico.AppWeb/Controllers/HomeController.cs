using CapasBasico.AppWeb.Models;
using CapasBasico.LogicaNegocio.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CapasBasico.AppWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonalLogica _personalLogica;

        public HomeController(ILogger<HomeController> logger, IPersonalLogica personalLogica)
        {
            _logger = logger;
            _personalLogica = personalLogica;
        }

        public IActionResult Index()
        {
            var lista = _personalLogica.GetAllPersonal();
            return View(lista);
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
    }
}