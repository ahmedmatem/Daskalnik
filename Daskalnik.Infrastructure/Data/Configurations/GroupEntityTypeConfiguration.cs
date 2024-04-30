using Daskalnik.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Daskalnik.Infrastructure.Data.Configurations
{
    public class GroupEntityTypeConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder
                .HasMany(g => g.Members)
                .WithMany(m => m.Groups)
                .UsingEntity<GroupsAndMembers>(
                    j => j.HasOne(g => g.Member)
                        .WithMany()
                        .HasForeignKey(g => g.MemberId),
                    j => j.HasOne(m => m.Group)
                        .WithMany()
                        .HasForeignKey(m => m.GroupId));

            builder
                .HasMany(g => g.Topics)
                .WithMany(t => t.Groups)
                .UsingEntity<GroupsAndTopics>(
                    j => j.HasOne(g => g.Topic)
                        .WithMany()
                        .HasForeignKey(g => g.TopicId),
                    j => j.HasOne(t => t.Group)
                        .WithMany()
                        .HasForeignKey(t => t.GroupId));

            builder
                .HasOne(g => g.Teacher)
                .WithMany()
                .HasForeignKey(g => g.TeacherId);
        }
    }
}
