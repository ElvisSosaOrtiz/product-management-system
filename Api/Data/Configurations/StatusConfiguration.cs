namespace Api.Data.Configurations
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class StatusConfiguration : IEntityTypeConfiguration<StatusEntity>
    {
        public void Configure(EntityTypeBuilder<StatusEntity> builder)
        {
            builder.HasData(
                new StatusEntity { Id = 1, Name = "Active" },
                new StatusEntity { Id = 2, Name = "Inactive" });
        }
    }
}
