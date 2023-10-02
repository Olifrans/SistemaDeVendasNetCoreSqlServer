using Microsoft.AspNetCore.Mvc;

namespace SistemaDeVendas.WEB.Controllers
{
	public class NegocioController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
