using MedicalResearch.Domain.Additional;
using MedicalResearch.Domain.DepartmentResearches;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalResearch.Persistence.Configurations.DepartmentResearches
{
    public class DepartmentResearchWorkScheduleConfiguration : IEntityTypeConfiguration<DepartmentResearchWorkSchedule>
    {
        public void Configure(EntityTypeBuilder<DepartmentResearchWorkSchedule> builder)
        {
            builder.ToTable("DepartmentResearchWorkSchedule");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.DayOfWeekID).IsRequired();
            builder.Property(x => x.DepartmentResearchID).IsRequired();
            builder.Property(x => x.StartTime).IsRequired();
            builder.Property(x => x.EndTime).IsRequired();

            builder.HasOne(w => w.DayOfWeek)
                .WithMany()
                .HasForeignKey(w => w.DayOfWeekID)
                .IsRequired();

            builder.HasOne(w => w.DepartmentResearch)
                .WithMany(d => d.DepartmentResearchWorkSchedules)
                .HasForeignKey(w => w.DepartmentResearchID)
                .IsRequired();
        }
    }
}
