using Infrastructure.Data.Configurations;
using Infrastructure.Data.Models;
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
                .ApplyConfiguration(new IdentityRoleTypeConfiguration())
                .ApplyConfiguration(new IdentityUserConfiguration())
                .ApplyConfiguration(new IdentityUserRoleTypeConfiguration())
                .ApplyConfiguration(new SchoolTypeConfiguration())
                .ApplyConfiguration(new TopicResourceTypeConfiguration())
                .ApplyConfiguration(new GroupStudentTypeConfiguration());

            base.OnModelCreating(builder);
        }

        public override Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Group> Groups { get; set; } = null!;

        public DbSet<GroupStudent> GroupsAndStudents { get; set; } = null!;

        public DbSet<Resource> Resources { get; set; } = null!;

        public DbSet<School> Schools { get; set; } = null!;

        public DbSet<Student> Students { get; set; } = null!;

        public DbSet<Teacher> Teachers { get; set; } = null!;

        public DbSet<Topic> Topics { get; set; } = null!;

        public DbSet<TopicResource> TopicsAndResources { get; set; } = null!;
    }
}
