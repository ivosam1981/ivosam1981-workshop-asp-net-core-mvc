﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SallesWebMvc.Models;
using SallesWebMvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Controllers
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

        public IActionResult Privacy()
        {

            return View();
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Projeto desenvolvido em .NET CORE MVC durante o workshop \"Desenvolvimento de sistema com .DONET C#\"";
            ViewData["Desenvolvedor"] = "Desenvolvido por Ivo Sam";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
