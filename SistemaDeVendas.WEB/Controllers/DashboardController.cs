﻿using Microsoft.AspNetCore.Mvc;

namespace SistemaDeVendas.WEB.Controllers
{
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
