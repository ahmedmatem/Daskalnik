using Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Infrastructure.Data.Configurations.SeedConfiguration;

namespace Infrastructure.Data.Configurations
{
    public class IdentityUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        private PasswordHasher<ApplicationUser> passwordHasher =
            new PasswordHasher<ApplicationUser>();

        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            SeedUsers();
            builder.HasData(Users);
        }

        private void SeedUsers()
        {
            Users.Clear();
            Users.Add(Admin); // index 0

            // Reset TeachersCount and StudentStartIndex fields
            // in SeedConfiguration if TeachersCount changed.

            // The following users are teachers
            Users.Add(CreateUser("turhan@gmail.com", "turhanPass"));
            Users.Add(CreateUser("venci@gmail.com", "venciPass"));
            Users.Add(CreateUser("ahmed@gmail.com", "ahmedPass"));
            Users.Add(CreateUser("martin@gmail.com", "martinPass"));
            Users.Add(CreateUser("desi@gmail.com", "desiPass"));

            // The following users are students
            Users.Add(CreateUser("baran@gmail.com", "turhanPass")); // StudentStartIndex
            Users.Add(CreateUser("viktoriya@gmail.com", "venciPass"));
            Users.Add(CreateUser("daniel@gmail.com", "ahmedPass"));
            Users.Add(CreateUser("dimana@gmail.com", "martinPass"));
            Users.Add(CreateUser("dimitar@gmail.com", "desiPass"));
            Users.Add(CreateUser("emre@gmail.com", "turhanPass"));
            Users.Add(CreateUser("ivayla@gmail.com", "venciPass"));
            Users.Add(CreateUser("ivan@gmail.com", "ahmedPass"));
            Users.Add(CreateUser("ivan_ivanov@gmail.com", "martinPass"));
            Users.Add(CreateUser("dimitar_barlev@gmail.com", "desiPass"));
        }

        private ApplicationUser CreateUser(string email, string password)
        {
            var user = new ApplicationUser()
            {
                Email = email,
                NormalizedEmail = email.ToUpper(),
                UserName = email,
                NormalizedUserName = email.ToUpper(),
                FullName = email.Split('@')[0] + " Пълно Име"
            };
            user.PasswordHash =
                passwordHasher.HashPassword(user, password);

            return user;
        }
    }
}
