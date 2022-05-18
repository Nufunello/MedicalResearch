using MedicalResearch.Domain.Additional;
using MedicalResearch.Domain.Departments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalResearch.Persistence.Configurations.Additional
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Name).HasMaxLength(50);

            builder.HasOne<Region>()
                .WithMany()
                .HasForeignKey(c => c.RegionID)
                .IsRequired();

            builder.HasMany<Department>()
                .WithOne(d => d.City)
                .HasForeignKey(d => d.CityID)
                .IsRequired();
        }
    }
}
