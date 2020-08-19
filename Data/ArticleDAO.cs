using cscoreweb.Data.Entities;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cscoreweb.Data
{
	public class ArticleDAO : IDAO<Article>
	{
		private ArticleContext dbcontext { get; set; }
		public ArticleDAO(ArticleContext context)
		{
			dbcontext = context;
		}

		public void Add(Article article)
		{
			dbcontext.Add(article);
			dbcontext.SaveChanges();
		}

		public IEnumerable<Article> GetAll()
		{
			List<Article> res = dbcontext.articles.Where(a => a.Id != 0).ToList();
			return res;
		}
	}
}
