using cscoreweb.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cscoreweb.Data
{
	public class ArticleContext : DbContext
	{
		public ArticleContext() : base(getoptions()) { }
		public DbSet<Article> articles { get; set; }

		public static DbContextOptions<ArticleContext> getoptions()
		{
			IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
			string connection = config.GetConnectionString("mssql"); 
			return new DbContextOptionsBuilder<ArticleContext>().UseSqlServer(connection).Options;
		}
	}
}
