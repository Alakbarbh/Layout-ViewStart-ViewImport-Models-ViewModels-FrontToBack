using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index(int id)
        {
            ViewBag.id = id; 
            return View();
        }
    }
}
