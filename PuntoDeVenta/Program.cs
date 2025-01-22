using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PuntoDeVenta.AccessData;

namespace PuntoDeVenta
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<PuntoDeVentaDbContext>();
                dbContext.Database.EnsureCreated();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<Login>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Configura el DbContext
            services.AddDbContext<PuntoDeVentaDbContext>(options =>
            {
                options.UseSqlite("Data Source=puntoDeVenta.db");
            });

            // Agrega las interfaces y servicios necesarios
            services.AddScoped<PuntoDeVentaDbContext>();

            // Registra el formulario principal
            services.AddTransient<Login>();
        }
    }
}