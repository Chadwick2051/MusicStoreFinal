using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MusicStore.Models;
using MusicStore.Models.DataAccess.Configuration;

namespace SongStore.Models.DataAccess
{
    public class SongContext : IdentityDbContext<User>
    {
        public SongContext(DbContextOptions<SongContext> options) :
            base(options)
        { }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new SongConfig());
        }
    }
}
