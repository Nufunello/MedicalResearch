using MedicalResearch.Domain.Additional;
using MedicalResearch.Domain.DepartmentResearches;
using MedicalResearch.Domain.Departments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalResearch.Persistence.Configurations.Departments
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");
            builder.HasKey(d => d.ID);
            builder.Property(d => d.CityID).IsRequired();
            builder.Property(d => d.Street).HasMaxLength(255).IsRequired();
            builder.Property(d => d.Building).HasMaxLength(50).IsRequired();
            builder.Property(d => d.PhoneNumber).HasMaxLength(13).IsRequired();

            builder.HasOne<City>()
                .WithMany()
                .HasForeignKey(d => d.CityID)
                .IsRequired();
            builder.HasMany<WorkSchedule>()
                .WithOne(w => w.Department)
                .HasForeignKey(w => w.DepartmentID)
                .IsRequired();
            builder.HasMany<DepartmentResearch>()
                .WithOne(dr => dr.Department)
                .HasForeignKey(dr => dr.DepartmentID)
                .IsRequired();
        }
    }
}
