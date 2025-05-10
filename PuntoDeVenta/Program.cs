using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PuntoDeVenta.AccessData;
using PuntoDeVenta.AccessData.Interfaces;
using PuntoDeVenta.AccessData.Repository;
using PuntoDeVenta.Application.Interfaces;
using PuntoDeVenta.Application.Profiles;
using PuntoDeVenta.Application.Services;
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

            services.AddTransient<ICategoriaProductoRepository, CategoriaProductoRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IEstadoRepository, EstadoRepository>();
            services.AddTransient<IFormaPagoRepository, FormaPagoRepository>();
            services.AddTransient<IMovimientoRepository, MovimientoRepository>();
            services.AddTransient<IParametroRepository, ParametroRepository>();
            services.AddTransient<IPerfilRepository, PerfilRepository>();
            services.AddTransient<IPermisoRepository, PermisoRepository>();
            services.AddTransient<IPermisoPerfilRepository, PermisoPerfilRepository>();
            services.AddTransient<IPermisoUsuarioRepository, PermisoUsuarioRepository>();
            services.AddTransient<IProductoRepository, ProductoRepository>();
            services.AddTransient<IPromocionRepository, PromocionRepository>();
            services.AddTransient<IPromocionCategoriaRepository, PromocionCategoriaRepository>();
            services.AddTransient<IPromocionProductoRepository, PromocionProductoRepository>();
            services.AddTransient<ITicketRepository, TicketRepository>();
            services.AddTransient<ITicketDetalleRepository, TicketDetalleRepository>();
            services.AddTransient<ITicketEstadoRepository, TicketEstadoRepository>();
            services.AddTransient<ITipoMovimientoRepository, TipoMovimientoRepository>();
            services.AddTransient<ITipoPermisoRepository, TipoPermisoRepository>();
            services.AddTransient<ITurnoRepository, TurnoRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IUnidadRepository, UnidadRepository>();

            services.AddTransient<ICategoriaProductoService, CategoriaProductoService>();
            services.AddTransient<IClienteService,ClienteService>();
            services.AddTransient<IEstadoService, EstadoService>();
            services.AddTransient<IFormaPagoService, FormaPagoService>();
            services.AddTransient<IMovimientoService, MovimientoService>();
            services.AddTransient<IParametroService, ParametroService>();
            services.AddTransient<IPerfilService, PerfilService>();
            services.AddTransient<IPermisoService, PermisoService>();
            services.AddTransient<IPermisoPerfilService, PermisoPerfilService>();
            services.AddTransient<IPermisoUsuarioService, PermisoUsuarioService>();
            services.AddTransient<IProductoService, ProductoService>();
            services.AddTransient<IPromocionService, PromocionService>();
            services.AddTransient<IPromocionCategoriaService, PromocionCategoriaService>();
            services.AddTransient<IPromocionProductoService, PromocionProductoService>();
            services.AddTransient<ITicketService, TicketService>();
            services.AddTransient<ITicketDetalleService, TicketDetalleService>();
            services.AddTransient<ITicketEstadoService, TicketEstadoService>();
            services.AddTransient<ITipoMovimientoService, TipoMovimientoService>();
            services.AddTransient<ITipoPermisoService, TipoPermisoService>();
            services.AddTransient<ITurnoService, TurnoService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IUnidadService, UnidadService>();

            // Registra el formulario principal
            services.AddTransient<Login>();
            services.AddTransient<Main>();
            services.AddTransient<ProductosControl>();
            services.AddTransient<CategoriaProductoControl>();

        }
    }
}