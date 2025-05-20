using Microsoft.AspNetCore.Mvc;
namespace EBYS.Controllers
{
	public class SimulasyonController : Controller
	{
		public IActionResult Index()
		{
			return View(); 
		}
		public IActionResult GelenEvrak()
		{
			return View(); 
		}
		public IActionResult GidenEvrakParaf()
		{
			return View();
		}
		public IActionResult OnayOluştur()
		{
			return View(); 
		}
		public IActionResult TebligatOluştur()
		{
			return View();
		}
		public IActionResult OlağanüstüEvrak()
		{
			return View();
		}
		public IActionResult RotaOluşturma()
		{
			return View();
		}
	}
}