﻿namespace MagicMirror.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            RegisterServices(services);
            RegisterAutoMapper();

            ServiceProvider provider = services.BuildServiceProvider();
            provider.GetService<MagicMirrorApp>().RunAsync().GetAwaiter().GetResult();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            // Add Services using Dependency Injection
            services.AddTransient<ITrafficService, TrafficService>();
            services.AddTransient<ITrafficRepo, TrafficRepo>();

            services.AddTransient<IWeatherService, WeatherService>();
            services.AddTransient<IWeatherRepo, WeatherRepo>();

            // Register App
            services.AddTransient<MagicMirrorApp>();

            // Register AutoMapper
            services.AddAutoMapper();
        }

        private static void RegisterAutoMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<AutoMapperBusinessProfile>();
                cfg.AddProfile<AutoMapperPresentationProfile>();
            });
        }
    }
}