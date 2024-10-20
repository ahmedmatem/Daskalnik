namespace Infrastructure.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Infrastructure.Data.Models;

    public class ExamRecourceTypeConfiguration : IEntityTypeConfiguration<ExamResource>
    {
        public void Configure(EntityTypeBuilder<ExamResource> builder)
        {
            builder.HasKey(x => new { x.ExamId, x.ResourceId});
        }
    }
}
