namespace Infrastructure.Data.Configurations
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Infrastructure.Data.Models;

    public class TopicResourceTypeConfiguration : IEntityTypeConfiguration<TopicResource>
    {
        public void Configure(EntityTypeBuilder<TopicResource> builder)
        {
            builder.HasKey(x => new { x.TopicId, x.ResourceId });
        }
    }
}
