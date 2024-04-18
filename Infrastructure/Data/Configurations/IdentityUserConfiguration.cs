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
            Users.Add(CreateUser("turhan@gmail.com", "turhanPass", "Турхан Мюмюн Сюлейман"));
            Users.Add(CreateUser("venci@gmail.com", "venciPass", "Венцислав Кочанов"));
            Users.Add(CreateUser("ahmed@gmail.com", "ahmedPass", "Ахмед Матем Ахмед"));
            Users.Add(CreateUser("martin@gmail.com", "martinPass", "Мартин Катев"));
            Users.Add(CreateUser("desi@gmail.com", "desiPass", "Десислава Петкова"));

            // The following users are students
            Users.Add(CreateUser("baran@gmail.com", "baranPass", "Баран Ахмедов")); // StudentStartIndex
            Users.Add(CreateUser("viktoriya@gmail.com", "viktoriyaPass", "Виктория Петрова"));
            Users.Add(CreateUser("daniel@gmail.com", "danielPass", "Даниел Петорв"));
            Users.Add(CreateUser("dimana@gmail.com", "dimanaPass", "Димана Иванова Колева"));
            Users.Add(CreateUser("dimitar@gmail.com", "dimitarPass", "Димитар Димитров"));
            Users.Add(CreateUser("emre@gmail.com", "emrePass", "Емре Алиев"));
            Users.Add(CreateUser("ivayla@gmail.com", "ivaylaPass", "Ивайла Иванова"));
            Users.Add(CreateUser("ivan@gmail.com", "ivanPass", "Иван Манолов Кишанов"));
            Users.Add(CreateUser("ivan_ivanov@gmail.com", "ivan_ivanovPass", "Иван Петров Иванов"));
            Users.Add(CreateUser("dimitar_barlev@gmail.com", "dimitar_barlevPass", "Димитър Димов Барлев"));
        }

        private ApplicationUser CreateUser(string email, string password, string fullName)
        {
            var user = new ApplicationUser()
            {
                Email = email,
                NormalizedEmail = email.ToUpper(),
                UserName = email,
                NormalizedUserName = email.ToUpper(),
                FullName = fullName
            };
            user.PasswordHash =
                passwordHasher.HashPassword(user, password);

            return user;
        }
    }
}
