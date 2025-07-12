using Microsoft.EntityFrameworkCore;
using KioscoAPI.Models;

namespace KioscoAPI.Data
{
    public class KioscoDbContext : DbContext
    {
        public KioscoDbContext(DbContextOptions<KioscoDbContext> options)
            : base(options) { }

        public DbSet<Proveedore> Proveedores { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<CajaMovimiento> CajaMovimientos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<PagoFiado> PagosFiados { get; set; }
        public DbSet<MovimientoStock> MovimientoStock { get; set; }
        public DbSet<PrecioProducto> PrecioProducto { get; set; }
        public DbSet<Permiso> Permisos { get; set; }

        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             base.OnModelCreating(modelBuilder);

             // ▓▓▓ Permisos: clave compuesta
             modelBuilder.Entity<Permiso>(entity =>
             {
                 entity.ToTable("Permisos");
                 entity.HasKey(p => new { p.id_usuario, p.acceso });
                 entity.Property(p => p.acceso).HasMaxLength(100);

                 entity.HasOne(p => p.Usuario)
                       .WithMany(u => u.Permisos)
                       .HasForeignKey(p => p.id_usuario)
                       .OnDelete(DeleteBehavior.Cascade);
             });

             // ▓▓▓ Venta
             modelBuilder.Entity<Venta>(entity =>
             {
                 entity.ToTable("Ventas");
                 entity.HasKey(v => v.id);

                 entity.HasOne(v => v.Cliente)
                       .WithMany()
                       .HasForeignKey(v => v.id_cliente)
                       .OnDelete(DeleteBehavior.Restrict);

                 entity.HasOne(v => v.Vendedor)
                       .WithMany(u => u.VentasRealizadas)
                       .HasForeignKey(v => v.id_vendedor)
                       .OnDelete(DeleteBehavior.Restrict);
             });

             // ▓▓▓ DetalleVenta
             modelBuilder.Entity<DetalleVenta>(entity =>
             {
                 entity.ToTable("DetalleVentas");
                 entity.HasKey(d => d.id);

                 entity.HasOne(d => d.Venta)
                       .WithMany()
                       .HasForeignKey(d => d.id_venta);

                 entity.HasOne(d => d.Producto)
                       .WithMany()
                       .HasForeignKey(d => d.id_producto);
             });

             // ▓▓▓ Producto
             modelBuilder.Entity<Producto>(entity =>
             {
                 entity.ToTable("Productos");
                 entity.HasKey(p => p.id);

                 entity.HasOne(p => p.Categoria)
                       .WithMany()
                       .HasForeignKey(p => p.id_categoria);

                 entity.HasOne(p => p.Proveedor)
                       .WithMany()
                       .HasForeignKey(p => p.id_proveedor);
             });

             // ▓▓▓ Cliente
             modelBuilder.Entity<Cliente>(entity =>
             {
                 entity.ToTable("Clientes");
                 entity.HasKey(c => c.id);
             });

             // ▓▓▓ Usuario
             modelBuilder.Entity<Usuario>(entity =>
             {
                 entity.ToTable("Usuarios");
                 entity.HasKey(u => u.id);
             });

             // ▓▓▓ Categorias
             modelBuilder.Entity<Categoria>(entity =>
             {
                 entity.ToTable("Categorias");
                 entity.HasKey(c => c.id);
             });

             // ▓▓▓ Proveedor
             modelBuilder.Entity<Proveedor>(entity =>
             {
                 entity.ToTable("Proveedores");
                 entity.HasKey(p => p.id);
             });

             // ▓▓▓ MovimientoStock
             modelBuilder.Entity<MovimientoStock>(entity =>
             {
                 entity.ToTable("MovimientoStock");
                 entity.HasKey(m => m.id);

                 entity.HasOne(m => m.Producto)
                       .WithMany()
                       .HasForeignKey(m => m.id_producto);

                 entity.HasOne(m => m.Usuario)
                       .WithMany()
                       .HasForeignKey(m => m.id_usuario);
             });

             // ▓▓▓ PrecioProducto
             modelBuilder.Entity<PrecioProducto>(entity =>
             {
                 entity.ToTable("PrecioProducto");
                 entity.HasKey(p => p.id);

                 entity.HasOne(p => p.Producto)
                       .WithMany()
                       .HasForeignKey(p => p.id_producto);
             });

             // ▓▓▓ CajaMovimiento
             modelBuilder.Entity<CajaMovimiento>(entity =>
             {
                 entity.ToTable("CajaMovimientos");
                 entity.HasKey(c => c.id);

                 entity.HasOne(c => c.Usuario)
                       .WithMany()
                       .HasForeignKey(c => c.id_usuario);
             });

             // ▓▓▓ PagoFiado
             modelBuilder.Entity<PagoFiado>(entity =>
             {
                 entity.ToTable("PagosFiados");
                 entity.HasKey(p => p.id);

                 entity.HasOne(p => p.Cliente)
                       .WithMany()
                       .HasForeignKey(p => p.id_cliente);

                 entity.HasOne(p => p.Venta)
                       .WithMany()
                       .HasForeignKey(p => p.id_venta);
             });

         }
        */
     }
        
    }
