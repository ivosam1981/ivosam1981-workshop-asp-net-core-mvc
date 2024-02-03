using Microsoft.AspNetCore.Mvc;
using SallesWebMvc.Models;
using System.Collections.Generic;

namespace SallesWebMvc.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {

            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, Name = "Eletronics" });
            list.Add(new Departament { Id = 2, Name = "Fashion" });


            return View(list);
        }
    }
}
