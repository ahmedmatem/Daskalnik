using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Infrastructure.Data.Configurations.SeedConfiguration;

namespace Infrastructure.Data.Configurations
{
    public class TeacherTypeConfiguration : IEntityTypeConfiguration<Teacher>
    {
        private ICollection<Teacher> teachers = new HashSet<Teacher>();

        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            SeedTeachers();
            builder.HasData(teachers);
        }

        private void SeedTeachers()
        {
            for (var i = 1; i <= TeachersCount; i++)
            {
                teachers.Add(CreateTeacher(Users[i].Email));
            }
        }

        private Teacher CreateTeacher(string email)
        {
            Teacher teacher = new Teacher();
            var user = Users.First(u => u.Email == email);
            if (user != null)
            {
                int schoolIndex = new Random().Next(Schools.Count());
                teacher = new Teacher()
                {
                    Id = user.Id,
                    FullName = string.Join(" ", email.Split('@')),
                    SchoolId = Schools[schoolIndex].Id
                };
            }
            return teacher;
        }
    }
}
