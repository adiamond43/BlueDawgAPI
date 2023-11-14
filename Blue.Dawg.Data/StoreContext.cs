using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;
using Blue.Dawg.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Blue.Dawg.Data 
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
            { }

            public DbSet<Item> Items { get; set; }
    }
}