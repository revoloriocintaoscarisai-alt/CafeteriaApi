using Microsoft.EntityFrameworkCore;
using CafeteriaApi.Models;

namespace CafeteriaApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}