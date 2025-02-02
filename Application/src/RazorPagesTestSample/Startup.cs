using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RazorPagesTestSample.Data;

namespace RazorPagesTestSample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("InMemoryDb"));

            services.AddRazorPages();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            // Write a loop from 0 to 10 and print out the numeric value of the iterator for each loop iteration
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(i);
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            // Write a loop from 0 to 10 and print out the numeric value of the iterator for each loop iteration
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
