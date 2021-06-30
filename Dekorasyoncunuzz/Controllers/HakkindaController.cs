using Microsoft.AspNetCore.Mvc;

namespace Dekorasyoncunuz.Controllers
{
    public class HakkindaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
