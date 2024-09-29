namespace Infrastructure.Data.Configurations
{
    using Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ExamRecourceTypeConfiguration : IEntityTypeConfiguration<ExamResource>
    {
        public void Configure(EntityTypeBuilder<ExamResource> builder)
        {
            builder.HasKey(x => new { x.ExamId, x.ResourceId});
        }
    }
}
