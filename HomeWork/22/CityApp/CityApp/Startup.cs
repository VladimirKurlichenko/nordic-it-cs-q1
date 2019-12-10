using CityApp.Servies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace CityApp
{
	// Класс определяет конфигурацию приложения
	public class Startup
	{
		// Конфигурация сервисов приложения
		// Под сервисом может пониматься любой класс
		// Так как приложение разрабатывается с использванием фреймворка (контроллеры, например, за нас создавал фреймворк, мы этим нигде не писали new CityController())
		// То сам фреймворк управляет временем жизни всех классов. И чтобы корректно сконструировать объект любого, фреймворку необходимо знать о его зависимостях
		// Все эти зависимости конфигурируются в этом методе
		// Сам MVC, в свою очередь, состоит из множества сервисов, которые встраиваются в приложение путем вызова метода расширения AddMvc()
		public void ConfigureServices(IServiceCollection services)
		{
            services
                .AddMvc(
                option =>
                {
                    option.RespectBrowserAcceptHeader = true;
                }
                )
                .AddXmlSerializerFormatters();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info { Title = "Cities", Version = "2.0" });
            }
            );

            services.AddSingleton<CityStorage>();

        }

		// Конфигурация пайплайна обработки запроса
		public void Configure(
			IApplicationBuilder builder,
			IHostingEnvironment environment)
		{
			if (environment.EnvironmentName == "local")
			{
				builder.UseDeveloperExceptionPage();
			}

            builder.UseSwagger();
            builder.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cities API V1");
            });

            builder.UseMvc(ConfigureRoutes);
		}

		// Конфигурация http маршрутов поддерживаемых приложением
		private static void ConfigureRoutes(IRouteBuilder builder)
		{
			builder.MapRoute(
				name: "Default",
				template: "{controller}/{action}",
				defaults: new { Controller = "City", Action = "List" }
			);
		}
	}
}
