﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Aplicação de Aprendizado do Curso de C# com .Net Core";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Nome"] = "Narcelio Monte";
            ViewData["Email"] = "narceliomonte@hotmail.com";

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
    }
}
