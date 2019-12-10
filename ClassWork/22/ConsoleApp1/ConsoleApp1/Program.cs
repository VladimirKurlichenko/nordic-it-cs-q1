using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace ConsoleApp10
{
    class Program
    {
        private static void Main(string[] args)
        {
            BuilderWebHostBuilder(args)
                .Build()
                .Run();
            Console.ReadKey();
        }

        private static IWebHostBuilder BuilderWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder()
                .UseStartup<Startup>();
        }

        public class Startup
        {
            public void Configure(
                IApplicationBuilder builder,
                IHostingEnvironment environment)
            {
                if (environment.EnvironmentName == "local")
                {
                    builder.UseDeveloperExceptionPage();
                }

                builder.UseMvc();
            }
        }
    }
}