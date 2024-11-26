namespace Api.Data
{
    using Api.Data.Configurations;
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<UserEntity> Users { get; set; } = null!;
        public DbSet<ItemEntity> Items { get; set; } = null!;
        public DbSet<CustomerEntity> Customers { get; set; } = null!;
        public DbSet<CustomerItemEntity> CustomerItems { get; set; } = null!;
        public DbSet<ItemCategoryEntity> ItemCategories { get; set; } = null!;
        public DbSet<StatusEntity> Status { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
        }
    }
}
