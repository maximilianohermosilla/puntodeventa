using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Domain.Entities;
using System.Reflection;
using System.Reflection.PortableExecutable;

namespace PuntoDeVenta.AccessData
{
    public class PuntoDeVentaDbContext: DbContext
    {
        static string database = "puntoDeVenta.db";

        public DbSet<CategoriaProducto> CategoriaProducto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<FormaPago> FormaPago { get; set; }
        public DbSet<Movimiento> Movimiento { get; set; }
        public DbSet<Parametro> Parametro { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<PermisoPerfil> PermisoPerfil { get; set; }
        public DbSet<PermisoUsuario> PermisoUsuario { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Promocion> Promocion { get; set; }
        public DbSet<PromocionCategoria> PromocionCategoria { get; set; }
        public DbSet<PromocionProducto> PromocionProducto { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<TicketDetalle> TicketDetalle { get; set; }
        public DbSet<TicketEstado> TicketEstado { get; set; }
        public DbSet<TipoMovimiento> TipoMovimiento { get; set; }
        public DbSet<TipoPermiso> TipoPermiso { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Unidad> Unidad { get; set; }

        public PuntoDeVentaDbContext() : base()
        {

        }

        public PuntoDeVentaDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "Filename=" + database,
                sqliteOptionsAction: op =>
                {
                    op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                });

                base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaProducto>(entity =>
            {
                entity.Property(e => e.Descripcion).HasMaxLength(100).IsRequired();
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.Property(e => e.Descripcion).HasMaxLength(50).IsRequired();
            });

            modelBuilder.Entity<TicketEstado>(entity =>
            {
                entity.HasOne(d => d.Estado).WithMany(p => p.TicketEstados).HasForeignKey(d => d.IdEstado).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(d => d.Ticket).WithMany(p => p.TicketEstados).HasForeignKey(d => d.IdTicket).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.Property(e => e.PrecioTotal).HasColumnType("numeric(25,2)");
                entity.HasOne(d => d.Estado).WithMany(p => p.Tickets).HasForeignKey(d => d.IdEstado).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(d => d.FormaPago).WithMany(p => p.Tickets).HasForeignKey(d => d.IdFormaPago).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(d => d.Turno).WithMany(p => p.Tickets).HasForeignKey(d => d.IdTurno).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<TicketDetalle>(entity =>
            {
                entity.HasOne(d => d.Producto).WithMany(p => p.TicketDetalles).HasForeignKey(d => d.IdProducto).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(d => d.Ticket).WithMany(p => p.TicketDetalles).HasForeignKey(d => d.IdTicket).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.Property(e => e.Descripcion).HasMaxLength(100).IsRequired();
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(e => e.PrecioCosto).HasColumnType("numeric(25,2)");
                entity.Property(e => e.PrecioVenta).HasColumnType("numeric(25,2)");
                entity.Property(e => e.PrecioPorMayor).HasColumnType("numeric(25,2)");
                entity.HasIndex(e => e.Codigo).IsUnique();
                entity.HasOne(d => d.CategoriaProducto).WithMany(p => p.Productos).HasForeignKey(d => d.IdCategoriaProducto).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(d => d.Unidad).WithMany(p => p.Productos).HasForeignKey(d => d.IdUnidad).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Promocion>(entity =>
            {
                entity.Property(e => e.Descripcion).HasMaxLength(100);
            });

            modelBuilder.Entity<PromocionCategoria>(entity =>
            {
                entity.Property(e => e.Descripcion).HasMaxLength(100);
                entity.HasOne(d => d.CategoriaProducto).WithMany(p => p.PromocionCategorias).HasForeignKey(d => d.IdCategoriaProducto).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(d => d.Promocion).WithMany(p => p.PromocionCategorias).HasForeignKey(d => d.IdPromocion).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<PromocionProducto>(entity =>
            {
                entity.Property(e => e.Descripcion).HasMaxLength(100);
                entity.HasOne(d => d.Producto).WithMany(p => p.PromocionProductos).HasForeignKey(d => d.IdProducto).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(d => d.Promocion).WithMany(p => p.PromocionProductos).HasForeignKey(d => d.IdPromocion).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.User).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Email).HasMaxLength(200).IsRequired();
                entity.Property(e => e.Password).IsRequired();
                entity.Property(e => e.Imagen).HasMaxLength(5000);
                entity.HasOne(d => d.Perfil).WithMany(p => p.Usuarios).HasForeignKey(d => d.IdPerfil).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<PermisoPerfil>(entity =>
            {
                entity.HasOne(d => d.Permiso).WithMany(p => p.PermisoPerfils).HasForeignKey(d => d.IdPermiso).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(d => d.Perfil).WithMany(p => p.PermisoPerfils).HasForeignKey(d => d.IdPerfil).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<PermisoUsuario>(entity =>
            {
                entity.HasOne(d => d.Permiso).WithMany(p => p.PermisoUsuarios).HasForeignKey(d => d.IdPermiso).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(d => d.Usuario).WithMany(p => p.PermisoUsuarios).HasForeignKey(d => d.IdUsuario).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Turno>(entity =>
            {
                entity.HasOne(d => d.Usuario).WithMany(p => p.Turnos).HasForeignKey(d => d.IdUsuario).OnDelete(DeleteBehavior.NoAction);
            });


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estado>().HasData(
                new Estado { Id = 1, Descripcion = "Iniciado" },
                new Estado { Id = 2, Descripcion = "Finalizado" },
                new Estado { Id = 3, Descripcion = "Cancelado" }
            );

            modelBuilder.Entity<Unidad>().HasData(
                new Unidad { Id = 1, Nombre = "U", Descripcion = "Unidad", Habilitado = true },
                new Unidad { Id = 2, Nombre = "Kg", Descripcion = "Kilogramos", Habilitado = false },
                new Unidad { Id = 3, Nombre = "G", Descripcion = "Gramos", Habilitado = false },
                new Unidad { Id = 4, Nombre = "L", Descripcion = "Litros", Habilitado = false },
                new Unidad { Id = 5, Nombre = "M", Descripcion = "Metros", Habilitado = false },
                new Unidad { Id = 6, Nombre = "Hs", Descripcion = "Horas", Habilitado = false },
                new Unidad { Id = 7, Nombre = "-", Descripcion = "No Aplica", Habilitado = false }
            );

            modelBuilder.Entity<FormaPago>().HasData(
                new FormaPago { Id = 1, Descripcion = "Efectivo", Codigo = "cash", Habilitado = true },
                new FormaPago { Id = 2, Descripcion = "Tarjeta de Crédito", Codigo = "credit", Habilitado = true },
                new FormaPago { Id = 3, Descripcion = "Tarjeta de Débito", Codigo = "debit", Habilitado = true },
                new FormaPago { Id = 4, Descripcion = "Transferencia", Codigo = "transfer", Habilitado = true },
                new FormaPago { Id = 5, Descripcion = "MercadoPago", Codigo = "mercadopago", Habilitado = true }
            );

            modelBuilder.Entity<TipoMovimiento>().HasData(
                new TipoMovimiento { Id = 1, Descripcion = "Entrada" },
                new TipoMovimiento { Id = 2, Descripcion = "Salida" },
                new TipoMovimiento { Id = 3, Descripcion = "Ajuste" },
                new TipoMovimiento { Id = 4, Descripcion = "Devolución" }
            );
        }
    }
}
