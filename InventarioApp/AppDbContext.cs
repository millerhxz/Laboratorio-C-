using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("InventarioTemporal");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Categoria>().HasData(
            new Categoria { Id = 1, Nombre = "Electrónica" },
            new Categoria { Id = 2, Nombre = "Hogar" },
            new Categoria { Id = 3, Nombre = "Alimentos" }
        );

        modelBuilder.Entity<Producto>().HasData(
            new Producto { Id = 1, Nombre = "Laptop HP", Precio = 850.00m, CategoriaId = 1 },
            new Producto { Id = 2, Nombre = "Mouse Inalámbrico", Precio = 25.50m, CategoriaId = 1 },
            new Producto { Id = 3, Nombre = "Licuadora", Precio = 45.00m, CategoriaId = 2 },
            new Producto { Id = 4, Nombre = "Juego de Sartenes", Precio = 60.00m, CategoriaId = 2 },
            new Producto { Id = 5, Nombre = "Manzanas (1kg)", Precio = 3.50m, CategoriaId = 3 },
            new Producto { Id = 6, Nombre = "Cereal", Precio = 4.20m, CategoriaId = 3 }
        );
    }
}