using Daskalnik.Infrastructure.Data.Configurations;
using Daskalnik.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Daskalnik.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new SchoolEntityTypeConfiguration());
            builder.ApplyConfiguration(new GroupEntityTypeConfiguration());
            //builder.ApplyConfiguration(new ApplicationUserEntityTypeConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Group> Groups { get; set; } = null!;

        public DbSet<ApplicationUser> Schools { get; set; } = null!;

        public DbSet<Topic> Topics { get; set; } = null!;

        public DbSet<TopicResource> TopicResources { get; set; } = null!;

        public override Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
