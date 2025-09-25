using Microsoft.AspNetCore.Mvc;
using Sales_Web_MVC_1.Models;
using System.Collections.Generic;

namespace Sales_Web_MVC_1.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Eletrônico" });
            list.Add(new Departamento { Id = 2, Nome = "Perfumaria" });

            return View(list);
        }
    }
}

