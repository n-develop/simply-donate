using Microsoft.EntityFrameworkCore;
using SimplyDonate.DataAccess.Database.Entities;

namespace SimplyDonate.DataAccess.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        
        public DbSet<DonationEntity> Donations { get; set; }
        public DbSet<DonationCategoryEntity> DonationCategories { get; set; }
        public DbSet<NonProfitEntity> NonProfits { get; set; }
        public DbSet<UserEntity> Users { get; set; }

    }
}