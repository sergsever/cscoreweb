using cscoreweb.Data;
using cscoreweb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cscoreweb.Models
{
	public class ArticlesModel
	{
		private IDAO<Article> dao;
		public ArticlesModel()
		{
			dao = new ArticleDAO(new ArticleContext());
		}

		public IEnumerable<Article> Articles()
		{
			List<Article> res = dao.GetAll().ToList();
			return res;
		}
	}
}
