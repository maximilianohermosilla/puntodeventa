using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PuntoDeVenta.AccessData;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.AccessData.Repository;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Profiles;
using PuntoDeVenta.Application.Services;
using PuntoDeVenta.Helpers;
using PuntoDeVenta.UserControls;
using PuntoDeVenta.UserControls.ProductosControls;

namespace PuntoDeVenta
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  new Bitmap(Properties.Resources.check, 24, 24);
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

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(serviceProvider.GetRequiredService<Login>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Configura el DbContext
            services.AddDbContext<PuntoDeVentaDbContext>(options =>
            {
                options.UseSqlite("Data Source=puntoDeVenta.db");
            });
            
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Agrega las interfaces y servicios necesarios
            services.AddScoped<PuntoDeVentaDbContext>();

            services.AddTransient<IProductoRepository, ProductoRepository>();
            services.AddTransient<ICategoriaProductoRepository, CategoriaProductoRepository>();

            services.AddTransient<IProductoService, ProductoService>();
            services.AddTransient<ICategoriaProductoService, CategoriaProductoService>();

            // Registra el formulario principal
            services.AddTransient<Login>();
            services.AddTransient<Main>();
            services.AddTransient<ProductosControl>();
            services.AddTransient<CategoriaProductoControl>();

        }
    }
}