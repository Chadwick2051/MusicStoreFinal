using Microsoft.AspNetCore.Mvc;

namespace SongStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
