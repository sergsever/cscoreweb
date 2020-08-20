using cscoreweb.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cscoreweb.Views.Home
{
	public class IndexModel : PageModel 
	{
		public IndexModel()
		{
			Name = "Index";
			articles = new List<Article>();
		}
		public string Name { get; set; }
		public List<Article> articles { get; set; }

	}
}
