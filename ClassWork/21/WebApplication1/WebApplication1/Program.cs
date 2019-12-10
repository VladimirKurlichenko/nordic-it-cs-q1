using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;


namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup2>();
                });
    }

    public class Startup2
    {
        public void Configure(IApplicationBuilder builder, IHostingEnvironment environment)
        {


            builder.Use(PostWorldRequest);
            builder.Use(GetHelloRequest);
            builder.Run(GetAllRequest);
        }
        private static Task PostWorldRequest(HttpContext context, Func<Task> next)
        {
            if(context.Request.Method.ToUpper() == "POST" &&
               context.Request.Path.StartsWithSegments("/world"))
            {
                context.Response.StatusCode = 200;
                return context.Response.WriteAsync(" Post Hello world!");
            }

            return next();

        }
        private static Task GetHelloRequest(HttpContext context, Func<Task> next)
        {
            if (context.Request.Method.ToUpper() == "GET" &&
                context.Request.Path.StartsWithSegments("/hello"))
            {
                context.Response.StatusCode = 200;
                return context.Response.WriteAsync(" Get Hello world!");
            }

            return next();
        }
        private static Task GetAllRequest(HttpContext context)
        {
            throw new Exception("Some text");
            context.Response.StatusCode = 200;
            return context.Response.WriteAsync(" Get all");
        }
    }
}
