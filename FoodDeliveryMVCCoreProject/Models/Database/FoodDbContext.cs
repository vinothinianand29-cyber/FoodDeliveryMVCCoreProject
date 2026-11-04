using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryMVCCoreProject.Models.Database
{
    public class FoodDbContext : DbContext
    {
        public FoodDbContext(DbContextOptions<FoodDbContext> options) : base(options) { }

        public DbSet<FoodDetails> FoodData { get; set; }
    }
}
