using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.EntityConfigurations
{
    public class GroupStudentTypeConfiguration : IEntityTypeConfiguration<GroupStudent>
    {
        public void Configure(EntityTypeBuilder<GroupStudent> builder)
        {
            builder.HasKey(x => new { x.GroupId, x.StudentId });
        }
    }
}
