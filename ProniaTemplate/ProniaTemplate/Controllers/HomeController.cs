using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ProniaTemplate.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
