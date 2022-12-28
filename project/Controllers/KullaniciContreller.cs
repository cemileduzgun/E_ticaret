using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
    public class KullaniciContreller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
