using MedicalResearch.Domain.Additional;
using MedicalResearch.Domain.Departments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalResearch.Persistence.Configurations.Departments
{
    public class WorkScheduleConfiguration : IEntityTypeConfiguration<WorkSchedule>
    {
        public void Configure(EntityTypeBuilder<WorkSchedule> builder)
        {
            builder.ToTable("WorkSchedule");
            builder.HasKey(w => w.ID);
            builder.Property(w => w.DayOfWeekID).IsRequired();
            builder.Property(w => w.DepartmentID).IsRequired();
            builder.Property(w => w.StartTime).IsRequired();
            builder.Property(w => w.EndTime).IsRequired();

            builder.HasOne(w => w.Department)
                .WithMany(w => w.WorkSchedules)
                .HasForeignKey(w => w.DepartmentID)
                .IsRequired();
            builder.HasOne(w => w.DayOfWeek)
                .WithMany()
                .HasForeignKey(w => w.DayOfWeekID)
                .IsRequired();
        }
    }
}
