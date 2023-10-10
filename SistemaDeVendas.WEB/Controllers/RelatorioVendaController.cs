using Microsoft.AspNetCore.Mvc;

namespace SistemaDeVendas.WEB.Controllers
{
	public class RelatorioVendaController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
