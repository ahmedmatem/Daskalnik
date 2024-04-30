using Daskalnik.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Daskalnik.Infrastructure.Data.Configurations
{
    public class SchoolEntityTypeConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder
                .HasMany(s => s.Members)
                .WithOne()
                .HasForeignKey(s => s.SchoolId)
                .IsRequired();
        }
    }
}
