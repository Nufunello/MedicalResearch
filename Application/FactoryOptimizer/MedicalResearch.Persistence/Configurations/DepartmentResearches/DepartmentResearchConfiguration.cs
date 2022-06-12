using MedicalResearch.Domain.DepartmentResearches;
using MedicalResearch.Domain.Departments;
using MedicalResearch.Domain.Researches;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalResearch.Persistence.Configurations.DepartmentResearches
{
    public class DepartmentResearchConfiguration : IEntityTypeConfiguration<DepartmentResearch>
    {
        public void Configure(EntityTypeBuilder<DepartmentResearch> builder)
        {
            builder.ToTable("DepartmentResearch");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Cabinet).IsRequired();
            builder.Property(x => x.DepartmentID).IsRequired();
            builder.Property(x => x.ResearchID).IsRequired();

            builder.HasOne(x => x.Department)
                .WithMany(d => d.DepartmentResearches)
                .HasForeignKey(x => x.DepartmentID)
                .IsRequired();
            builder.HasOne(x => x.Research)
                .WithMany(r => r.DepartmentResearches)
                .HasForeignKey(x => x.ResearchID)
                .IsRequired();
           
        }
    }
}
