using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Infrastructure.Data.Configurations.SeedConfiguration;

namespace Infrastructure.Data.Configurations
{
    public class IdentityUserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        private PasswordHasher<IdentityUser> passwordHasher =
            new PasswordHasher<IdentityUser>();

        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            SeedUsers();
            builder.HasData(Users);
        }

        private void SeedUsers()
        {
            Users.Clear();
            Users.Add(Admin);
            Users.Add(CreateUser("turhan@gmail.com", "turhanPass"));
            Users.Add(CreateUser("venci@gmail.com", "venciPass"));
            Users.Add(CreateUser("ahmed@gmail.com", "ahmedPass"));
            Users.Add(CreateUser("martin@gmail.com", "martinPass"));
            Users.Add(CreateUser("desi@gmail.com", "desiPass"));
        }

        private IdentityUser CreateUser(string email, string password)
        {
            var user = new IdentityUser()
            {
                Email = email,
                NormalizedEmail = email.ToUpper(),
            };
            user.PasswordHash =
                passwordHasher.HashPassword(user, password);

            return user;
        }
    }
}
