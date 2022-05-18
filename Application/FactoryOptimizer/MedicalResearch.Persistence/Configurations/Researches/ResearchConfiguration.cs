using MedicalResearch.Domain.Researches;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalResearch.Persistence.Configurations.Researches
{
    public class ResearchConfiguration : IEntityTypeConfiguration<Research>
    {
        public void Configure(EntityTypeBuilder<Research> builder)
        {
            builder.ToTable("Research");
            builder.HasKey(r => r.ID);
            builder.Property(r => r.Name).IsRequired().HasMaxLength(50);
            builder.Property(r => r.Description).HasMaxLength(50);
            builder.Property(r => r.DeadlineInDays).IsRequired();
            builder.Property(r => r.Cost).IsRequired();
            builder.Property(r => r.GroupResearchID).IsRequired();
            builder.Property(r => r.PreparationID).IsRequired();

            builder.HasOne(r => r.Preparation)
                .WithMany(p => p.Researches)
                .HasForeignKey(r => r.PreparationID)
                .IsRequired();
            
            builder.HasOne(r => r.GroupResearch)
                .WithMany(p => p.Researches)
                .HasForeignKey(r => r.GroupResearchID)
                .IsRequired();
        }
    }
}
