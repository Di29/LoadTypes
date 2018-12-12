using System;
using System.Data.Entity;
using System.Linq;

namespace LoadTypesLesson
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("name=ShopContext")
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }
}