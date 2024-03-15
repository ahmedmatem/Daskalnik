using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class SchoolTypeConfiguration : IEntityTypeConfiguration<School>
    {
        private readonly IEnumerable<School> schools = new List<School>()
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


        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.HasData(schools);
        }
    }
}
