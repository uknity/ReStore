
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext //derived from Microsoft.EntityFrameworkCore
    {
        public StoreContext(DbContextOptions options) : base(options) //base class is DbContext - we're going to pass it options when using it
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
    }
}