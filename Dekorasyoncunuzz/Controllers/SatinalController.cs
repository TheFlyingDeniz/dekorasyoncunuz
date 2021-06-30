using Microsoft.AspNetCore.Mvc;
using System;

namespace Dekorasyoncunuz.Controllers
{
    public class SatinalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
