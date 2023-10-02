using Microsoft.AspNetCore.Mvc;

namespace SistemaDeVendas.WEB.Controllers
{
	public class UsuarioController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
