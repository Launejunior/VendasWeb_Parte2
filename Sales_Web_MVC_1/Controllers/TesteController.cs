using Microsoft.AspNetCore.Mvc;

namespace Sales_Web_MVC_1.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Saudacao"] = "Bem Vindo a Página TESTE";
            ViewData["Email"] = "email@xpo.com";
            return View();
        }
    }
}
