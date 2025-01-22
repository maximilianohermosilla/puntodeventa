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
        public DbSet<EstadoPedido> EstadoPedido { get; set; }
        public DbSet<FormaPago> FormaPago { get; set; }
        public DbSet<Movimiento> Movimiento { get; set; }
        public DbSet<Parametro> Parametro { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalle { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Promocion> Promocion { get; set; }
        public DbSet<PromocionCategoria> PromocionCategoria { get; set; }
        public DbSet<PromocionProducto> PromocionProducto { get; set; }
        public DbSet<TipoMovimiento> TipoMovimiento { get; set; }
        public DbSet<TipoPermiso> TipoPermiso { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

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

            modelBuilder.Entity<EstadoPedido>(entity =>
            {
                entity.HasOne(d => d.Estado).WithMany(p => p.EstadoPedidos).HasForeignKey(d => d.IdEstado).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(d => d.Pedido).WithMany(p => p.EstadoPedidos).HasForeignKey(d => d.IdPedido).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.Property(e => e.PrecioTotal).HasColumnType("numeric(25,2)");
                entity.HasOne(d => d.Estado).WithMany(p => p.Pedidos).HasForeignKey(d => d.IdEstado).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(d => d.FormaPago).WithMany(p => p.Pedidos).HasForeignKey(d => d.IdFormaPago).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(d => d.Usuario).WithMany(p => p.Pedidos).HasForeignKey(d => d.IdUsuario).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<PedidoDetalle>(entity =>
            {
                entity.HasOne(d => d.Producto).WithMany(p => p.PedidoDetalles).HasForeignKey(d => d.IdProducto).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(d => d.Pedido).WithMany(p => p.PedidoDetalles).HasForeignKey(d => d.IdPedido).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.Property(e => e.Descripcion).HasMaxLength(100).IsRequired();
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(e => e.PrecioCosto).HasColumnType("numeric(25,2)");
                entity.Property(e => e.PrecioVenta).HasColumnType("numeric(25,2)");
                entity.HasOne(d => d.CategoriaProducto).WithMany(p => p.Productos).HasForeignKey(d => d.IdCategoriaProducto).OnDelete(DeleteBehavior.NoAction);
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

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FormaPago>().HasData(
                new FormaPago { Id = 1, Descripcion = "Efectivo", Codigo = "cash", Habilitado = true },
                new FormaPago { Id = 2, Descripcion = "Tarjeta de Crédito", Codigo = "credit", Habilitado = true },
                new FormaPago { Id = 3, Descripcion = "Tarjeta de Débito", Codigo = "debit", Habilitado = true },
                new FormaPago { Id = 4, Descripcion = "MercadoPago", Codigo = "mercadopago", Habilitado = true },
                new FormaPago { Id = 5, Descripcion = "Transferencia", Codigo = "transfer", Habilitado = true }
            );
        }
    }
}
