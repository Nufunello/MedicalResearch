using MedicalResearch.Domain.Additional;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalResearch.Persistence.Configurations.Additional
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.ToTable("Region");
            builder.HasKey(r => r.ID);
            builder.Property(r => r.Name).HasMaxLength(50);

            builder.HasMany<City>()
                .WithOne(c => c.Region)
                .HasForeignKey(c => c.RegionID)
                .IsRequired();
        }
    }
}
