using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTest.Controllers
{
    public class RateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
