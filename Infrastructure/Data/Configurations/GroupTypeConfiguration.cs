using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class GroupTypeConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasMany(x => x.Students)
                .WithMany(x => x.Groups)
                .UsingEntity<GroupStudent>();

            builder.HasOne(x => x.Teacher)
                .WithMany(t => t.Groups)
                .HasForeignKey(t => t.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
