using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class GroupTopicTypeConfiguration : IEntityTypeConfiguration<GroupTopic>
    {
        public void Configure(EntityTypeBuilder<GroupTopic> builder)
        {
            builder.HasKey(x => new { x.GroupId, x.TopicId });
        }
    }
}
