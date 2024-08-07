using Microsoft.AspNetCore.Mvc;

namespace JP_MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
