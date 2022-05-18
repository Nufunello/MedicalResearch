using MedicalResearch.Domain.Additional;
using MedicalResearch.Domain.DepartmentResearches;
using MedicalResearch.Domain.Departments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalResearch.Persistence.Configurations.Additional
{
    public class DayOfWeekConfiguration : IEntityTypeConfiguration<DayOfWeek>
    {
        public void Configure(EntityTypeBuilder<DayOfWeek> builder)
        {
            builder.ToTable("DayOfWeek");
            builder.HasKey(d => d.ID);
            builder.Property(d => d.Name).IsRequired().HasMaxLength(50);

            builder.HasMany<WorkSchedule>()
                .WithOne(w => w.DayOfWeek)
                .HasForeignKey(w => w.DayOfWeekID)
                .IsRequired();
            builder.HasMany<DepartmentResearchWorkSchedule>()
                .WithOne(w => w.DayOfWeek)
                .HasForeignKey(w => w.DayOfWeekID)
                .IsRequired();
        }
    }
}
