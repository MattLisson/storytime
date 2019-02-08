using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Storytime2.App.Services;
using System.Net.Http;
using Blazor.Extensions.Storage;

namespace Storytime2.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddStorage();
            services.AddScoped<HttpClient>();
            // Example of a data service
            services.AddSingleton<WeatherForecastService>();
            services.AddScoped<TodoistService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
