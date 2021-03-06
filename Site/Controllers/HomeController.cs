﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Site.Models;

namespace Site.Controllers
{
	public class HomeController : Controller
	{
		#region Methods

		public IActionResult About()
		{
			this.ViewData["Message"] = "Your application description page.";

			return this.View();
		}

		public IActionResult Contact()
		{
			this.ViewData["Message"] = "Your contact page.";

			return this.View();
		}

		public IActionResult Error()
		{
			return this.View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier});
		}

		public IActionResult Index()
		{
			return this.View();
		}

		#endregion
	}
}