using Microsoft.AspNetCore.Mvc;

namespace TrainingWeb.Controllers
{
	public class LearnController : Controller
	{
		public IActionResult Index() => View();           
		public IActionResult Slide1_EBYSNedir() => View();
		public IActionResult Slide2_SistemeGiris() => View();
		public IActionResult Slide3_BirimEvrak() => View();
		public IActionResult Slide4_RotaIslemleri() => View();
		public IActionResult Slide5_KayıtIslemleri() => View();
		public IActionResult Slide6_IslemYaptıklarım() => View();
		public IActionResult Slide7_PostaIslemleri() => View();
		public IActionResult Slide8_IslemYapacaklarım() => View();
		public IActionResult Slide9_EvrakArama () => View();
		public IActionResult Slide10_DağıtımHavale() => View();
	}
}
