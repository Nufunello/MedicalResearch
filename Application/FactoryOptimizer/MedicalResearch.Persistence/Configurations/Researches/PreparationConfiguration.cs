using MedicalResearch.Domain.Researches;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalResearch.Persistence.Configurations.Researches
{
    public class PreparationConfiguration : IEntityTypeConfiguration<Preparation>
    {
        public void Configure(EntityTypeBuilder<Preparation> builder)
        {
            builder.ToTable("Preparation");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Description).IsRequired();

            builder.HasMany<Research>()
                .WithOne(r => r.Preparation)
                .HasForeignKey(r => r.PreparationID)
                .IsRequired();
        }
    }
}
