using Microsoft.AspNetCore.Mvc;

namespace ContaLuz.Controllers
{
	public class SignalRController : Controller
	{
		// GET
		public IActionResult Index()
		{
			return View();
		}
	}
}