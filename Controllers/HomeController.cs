﻿using CallCenterProgram.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CallCenterProgram.Controllers
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

        public IActionResult Student()
        {
            return View();
        }

        public IActionResult Technician()
        {
            return View();
        }
    }
}