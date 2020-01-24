using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace CityApp
{
	public class Program
	{
		private static void Main(string[] args)
		{
            var logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                BuildWebHostBuilder(args)
                    .Build()
                    .Run();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Stopped program because of exception");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }

			Console.ReadKey();
		}

		private static IWebHostBuilder BuildWebHostBuilder(string[] args)
		{
			return WebHost
				.CreateDefaultBuilder()
                .ConfigureLogging(builder => builder.ClearProviders())
				.UseStartup<Startup>()
                .UseNLog();
		}
	}
}
