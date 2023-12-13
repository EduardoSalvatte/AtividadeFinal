using Microsoft.AspNetCore.Mvc;

namespace Somativa.Controllers
{
    public class CatalogoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
