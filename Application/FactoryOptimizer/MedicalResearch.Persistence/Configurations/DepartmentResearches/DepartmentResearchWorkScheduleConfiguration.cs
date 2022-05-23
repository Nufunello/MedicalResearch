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

            builder.HasOne<DayOfWeek>(w => w.DayOfWeek)
                .WithMany()
                .HasForeignKey(w => w.DayOfWeekID)
                .IsRequired();

            builder.HasOne<DepartmentResearch>(w => w.DepartmentResearch)
                .WithMany()
                .HasForeignKey(w => w.DepartmentResearchID)
                .IsRequired();
        }
    }
}
