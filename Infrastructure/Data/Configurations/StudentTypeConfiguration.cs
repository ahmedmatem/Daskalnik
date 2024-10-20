namespace Infrastructure.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Infrastructure.Data.Models;
    using static Infrastructure.Data.Configurations.SeedConfiguration;

    public class StudentTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        private ICollection<Student> students = new HashSet<Student>();

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            SeedStudents();
            builder.HasData(students);

            builder.HasMany(x => x.Groups)
                .WithMany(x => x.Students)
                .UsingEntity<GroupStudent>();
        }

        private void SeedStudents()
        {
            for (var i = StudentStartIndex; i < Users.Count; i++)
            {
                students.Add(CreateStudent(Users[i].Email));
            }
        }

        private Student CreateStudent(string email)
        {
            Student student = new Student();
            var user = Users.First(u => u.Email == email);
            if (user != null)
            {
                int schoolIndex = new Random().Next(Schools.Count());
                student = new Student()
                {
                    Id = user.Id,
                    FullName = user.FullName,
                    SchoolId = Schools[schoolIndex].Id
                };
            }
            return student;
        }
    }
}
