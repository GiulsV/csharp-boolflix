using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class FeaturesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
