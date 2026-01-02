using Microsoft.AspNetCore.Mvc;

namespace MVC_UI_Templates.Controllers // Make sure this namespace matches your project name
{
    public class Vegetable4Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}