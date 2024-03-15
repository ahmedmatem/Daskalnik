using Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Data.Configurations
{
    public static class SeedConfiguration
    {
        public static IdentityUser Admin = CreateAdmin();

        public static IDictionary<string, string> RoleIds =
            new Dictionary<string, string>()
            {
                { "Admin", Guid.NewGuid().ToString() },
                { "SchoolAdmin", Guid.NewGuid().ToString() },
                { "Teacher", Guid.NewGuid().ToString() }
            };

        public static ICollection<IdentityRole> Roles
            = new HashSet<IdentityRole>();

        public static ICollection<IdentityUser> Users
            = new HashSet<IdentityUser>();

        private static IdentityUser CreateAdmin()
        {
            PasswordHasher<IdentityUser> passwordHasher =
                new PasswordHasher<IdentityUser>();

            var admin = new IdentityUser()
            {
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM"
            };
            admin.PasswordHash = passwordHasher.HashPassword(admin, "adminPass");
            // TODO: Add role Admin to admin

            return admin;
        }
    }
}
