using Infrastructure.Data.EntityConfigurations;
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
                .ApplyConfiguration(new TopicResourceTypeConfiguration())
                .ApplyConfiguration(new GroupStudentTypeConfiguration());

            base.OnModelCreating(builder);
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
