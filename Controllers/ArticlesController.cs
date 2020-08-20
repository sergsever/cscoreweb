using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cscoreweb.Data;
using cscoreweb.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace cscoreweb.Controllers
{
	[Route("[controller]/[action]")]
		public class ArticlesController : Controller
	{
		private IDAO<Article> dao { get; set; }
		public ArticlesController()
		{
			dao = new ArticleDAO(new ArticleContext());
		}

		[Route("/Articles/Add")]
		[HttpPost]
		public async Task<IActionResult> AddArticle(string title, string content)
		{
			try
			{
				Article article = new Article() { Title = title, Content = content, Created = DateTime.Now };
				dao.Add(article);
			}
			catch(Exception e)
			{
				throw e;
			}
			return Ok("Succesfull");
		}
	
	}
}
