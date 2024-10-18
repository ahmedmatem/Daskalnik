using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Infrastructure.Data.Configurations.SeedConfiguration;

namespace Infrastructure.Data.Configurations
{
    public class SchoolTypeConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            //builder.HasData(Schools);

            builder.HasMany<Teacher>()
                .WithOne()
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
