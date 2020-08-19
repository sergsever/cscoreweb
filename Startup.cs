using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace cscoreweb
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddControllersWithViews();
			services.AddRazorPages();
//			services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}
			app.UseStaticFiles();

			app.UseRouting();
	/*		
						app.UseEndpoints(endpoints =>
						{
							endpoints.MapRazorPages();
							endpoints.MapControllers();
						}
						);
			
*/
			//			app.UseAuthorization();
			/*
						app.UseMvc(routes =>
						{
							routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
							routes.MapRoute(name: "articles", template: "{controller=articles}/{action}/{id?}");
							}
						);   
			*/
//			app.UseDefaultFiles();
//			app.UseStaticFiles();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();

				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
				endpoints.MapControllerRoute(
	name: "articles",
	pattern: "{controller=Articles}/{action=Add}/{id?}");

				endpoints.MapRazorPages();
				
				
				
			});

		}
	}
}
