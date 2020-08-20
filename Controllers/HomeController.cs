using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cscoreweb.Models;
using cscoreweb.Data.Entities;
using cscoreweb.Views.Home;

namespace cscoreweb.Controllers
{

//	[Route("[controller]/[action]")]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		static List<Article> articles = new List<Article>();
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;

		}
//		[Route("/Home/Index")]
//		[HttpGet]
		public IActionResult Index()
		{
			ArticlesModel model = new ArticlesModel();
			List<Article> list = model.Articles().ToList();
			IndexModel indexModel = new IndexModel();
/*
			foreach (Article article in list)
			{
				indexModel.articles.Add(article);
			}
*/
			return View("Index", list);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
