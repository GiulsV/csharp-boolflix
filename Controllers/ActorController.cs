using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class ActorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
