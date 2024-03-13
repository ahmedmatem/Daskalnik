using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.EntityConfigurations
{
    public class TopicResourceTypeConfiguration : IEntityTypeConfiguration<TopicResource>
    {
        public void Configure(EntityTypeBuilder<TopicResource> builder)
        {
            builder.HasKey(x => new { x.TopicId, x.ResourceId });
        }
    }
}
