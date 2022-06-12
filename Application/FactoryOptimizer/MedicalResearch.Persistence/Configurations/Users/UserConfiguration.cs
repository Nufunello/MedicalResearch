using MedicalResearch.Domain.Researches;
using MedicalResearch.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalResearch.Persistence.Configurations.Researches
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Email).HasMaxLength(100).IsRequired();
            builder.Property(r => r.Password).HasMaxLength(255).IsRequired();
            builder.Property(r => r.CanChange).IsRequired();
        }
    }
}
