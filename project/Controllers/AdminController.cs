using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
    public class AdminController : Controller
    {
        AdminManager adminManager = new AdminManager();
        public IActionResult Index()
        {
            var values = adminManager.GetAllAdmins();
            return View(values);
        }
    }
}
