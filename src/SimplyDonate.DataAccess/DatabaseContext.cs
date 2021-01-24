using Microsoft.EntityFrameworkCore;

namespace SimplyDonate.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        
        public DbSet<Donation> Donations { get; set; }
        public DbSet<DonationCategory> DonationCategories { get; set; }
        public DbSet<NonProfit> NonProfits { get; set; }
        public DbSet<User> Users { get; set; }

    }
}