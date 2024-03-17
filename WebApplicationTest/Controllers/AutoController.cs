using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTest.Controllers
{
    public class AutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Kia()
        {
            return View();
        }
        public IActionResult Hyundai()
        {
            return View();
        }
    }
}
