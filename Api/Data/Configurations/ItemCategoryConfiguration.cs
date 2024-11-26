namespace Api.Data.Configurations
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ItemCategoryConfiguration : IEntityTypeConfiguration<ItemCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<ItemCategoryEntity> builder)
        {
            builder.HasData(
                new ItemCategoryEntity { Id = 1, Name = 'B' },
                new ItemCategoryEntity { Id = 2, Name = 'H' },
                new ItemCategoryEntity { Id = 3, Name = 'M' });
        }
    }
}
