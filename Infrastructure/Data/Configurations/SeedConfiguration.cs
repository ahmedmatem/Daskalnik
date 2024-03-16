using Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Data.Configurations
{
    public static class SeedConfiguration
    {
        public static int TeachersCount = 5;
        public static int StudentStartIndex = 6;

        public static IdentityUser Admin = CreateAdmin();

        public static readonly IList<School> Schools = new List<School>()
        {
            new School()
            {
                Name = "Акад. Никола Обрешков",
                Type = "ППМГ",
                City = "Разград",
                CreatedOn = DateTime.Now,
                IsDeleted = false,
            },
            new School()
            {
                Name = "Никола Йонков Вапцаров",
                Type = "ОУ",
                City = "Разград",
                CreatedOn = DateTime.Now,
                IsDeleted = true,
            },
            new School()
            {
                Name = "Екзарх Йосиф",
                Type = "ГПИЧЕ",
                City = "Разград",
                CreatedOn = DateTime.Now,
                IsDeleted = true,
            },
            new School()
            {
                Name = "Васил Левски",
                Type = "ОУ",
                City = "Разград",
                CreatedOn = DateTime.Now,
                IsDeleted = false,
            }
        };

        public static IDictionary<string, string> RoleIds =
            new Dictionary<string, string>()
            {
                { "Admin", Guid.NewGuid().ToString() },
                { "SchoolAdmin", Guid.NewGuid().ToString() },
                { "Teacher", Guid.NewGuid().ToString() }
            };

        public static ICollection<IdentityRole> Roles
            = new HashSet<IdentityRole>();

        public static IList<IdentityUser> Users
            = new List<IdentityUser>();

        private static IdentityUser CreateAdmin()
        {
            PasswordHasher<IdentityUser> passwordHasher =
                new PasswordHasher<IdentityUser>();

            var admin = new IdentityUser()
            {
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM"
            };
            admin.PasswordHash = passwordHasher.HashPassword(admin, "adminPass");
            // TODO: Add role Admin to admin

            return admin;
        }
    }
}
