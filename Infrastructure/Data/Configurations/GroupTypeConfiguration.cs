using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class GroupTypeConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            //builder.HasMany(x => x.Students)
            //    .WithMany(x => x.Groups)
            //    .UsingEntity<GroupStudent>();

            //builder.HasOne<Teacher>()
            //    .WithMany()
            //    .HasForeignKey(t => t.TeacherId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.HasOne<School>()
            //    .WithMany()
            //    .HasForeignKey(x => x.SchoolId)
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
