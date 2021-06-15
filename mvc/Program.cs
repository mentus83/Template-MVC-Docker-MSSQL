using System.IO;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using mvc.Data.Models;

namespace mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            
            RunSeeding(host);
            
            host.Run();
        }
        private static void RunSeeding(IHost host)
        {
            var scopeFactory = host.Services.GetService<IServiceScopeFactory>();
            try
            {
                using (var scope = scopeFactory.CreateScope())
                {
                    var seeder = scope.ServiceProvider.GetService<MyObjectSeeder>();
                    seeder.Seed();
                }    
            }
            catch {}
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(AddConfiguration)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        private static void AddConfiguration(HostBuilderContext ctx, IConfigurationBuilder builder)
        {
            //builder.Sources.Clear;
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();
        }
    }
}