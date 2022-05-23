using MedicalResearch.Domain.Researches;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalResearch.Persistence.Configurations.Researches
{
    public class GroupResearchConfiguration : IEntityTypeConfiguration<GroupResearch>
    {
        public void Configure(EntityTypeBuilder<GroupResearch> builder)
        {
            builder.ToTable("GroupResearch");
            builder.HasKey(r => r.ID);
            builder.Property(r => r.Name).HasMaxLength(50);

            builder.HasMany<Research>()
                .WithOne(r => r.GroupResearch)
                .HasForeignKey(r => r.GroupResearchID)
                .IsRequired();
        }
    }
}
