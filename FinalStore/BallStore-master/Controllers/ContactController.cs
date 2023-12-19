using Microsoft.AspNetCore.Mvc;

namespace SongStore.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
