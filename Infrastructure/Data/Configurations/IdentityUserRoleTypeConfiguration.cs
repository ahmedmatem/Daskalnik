using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Infrastructure.Data.Configurations.SeedConfiguration;

namespace Infrastructure.Data.Configurations
{
    public class IdentityUserRoleTypeConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        private ICollection<IdentityUserRole<string>> usersInRoles
            = new List<IdentityUserRole<string>>();

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(usersInRoles);
        }

        private void SeedUserInRole()
        {
            usersInRoles.Clear();
            // Apply Admin in role Admin
            usersInRoles.Add(new IdentityUserRole<string>()
            {
                UserId = Admin.Id,
                RoleId = RoleIds["Admin"]
            });

            // Apply teachers in role Teachers
            int teachersCount = 5;
            for (var i = 1; i <= teachersCount; i++)
            {
                usersInRoles.Add(new IdentityUserRole<string>()
                {
                    UserId = Users[i].Id,
                    RoleId = RoleIds["Teacher"]
                });
            }
        }
    }
}
