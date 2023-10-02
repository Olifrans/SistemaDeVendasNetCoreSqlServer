using Microsoft.AspNetCore.Mvc;

namespace SistemaDeVendas.WEB.Controllers
{
	public class VendaController : Controller
	{
        public IActionResult NovaVenda()
        {
            return View();
        }


        public IActionResult HistoricoDeVenda()
        {
            return View();
        }

    }
}
