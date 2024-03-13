using Infrastructure.Data.EntityConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new TopicResourceTypeConfiguration())
                .ApplyConfiguration(new GroupTopicTypeConfiguration())
                .ApplyConfiguration(new GroupStudentTypeConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
