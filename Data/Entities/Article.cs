using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cscoreweb.Data.Entities
{
	public class Article
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime Created { get; set; }
	}
}
