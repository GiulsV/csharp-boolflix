using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class EpisodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
