using MedicalResearch.Persistence.Configurations.Additional;
using MedicalResearch.Persistence.Configurations.DepartmentResearches;
using MedicalResearch.Persistence.Configurations.Departments;
using MedicalResearch.Persistence.Configurations.Researches;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace MedicalResearch.Persistence.DatabaseContext
{
    public class PepDbContext : DbContext
    {
        private readonly DatabaseOptions _options;

        public PepDbContext(IOptions<DatabaseOptions> options)
        {
            _options = options?.Value ?? throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrWhiteSpace(_options.SqlConnectionString))
            {
                throw new ArgumentException("Connection string is null or empty");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_options.SqlConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DayOfWeekConfiguration());
            modelBuilder.ApplyConfiguration(new RegionConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new WorkScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new GroupResearchConfiguration());
            modelBuilder.ApplyConfiguration(new ResearchConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentResearchConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentResearchWorkScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
