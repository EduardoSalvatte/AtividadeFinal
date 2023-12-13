using Microsoft.AspNetCore.Mvc;

namespace Somativa.Controllers
{
    public class CatalogoMasc : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
