using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
	public class MainPageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
