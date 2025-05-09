using Microsoft.AspNetCore.Mvc;

namespace EBYS.Controllers
{
	public class QuizController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
