﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solder.Net.Models;

namespace Solder.Net.Controllers
{
    public class HomeController : Controller
    {
        private Database _database { get; set; }
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, Database database)
        {
            _logger = logger;
            _database = database;
        }

        public IActionResult Index()
        {
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
