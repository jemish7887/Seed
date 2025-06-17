using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
