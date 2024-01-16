using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class AdminPageController : Controller
    {
        public IActionResult LoginAndSignUp()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
