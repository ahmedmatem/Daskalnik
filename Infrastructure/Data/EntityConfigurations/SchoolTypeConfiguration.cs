using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.EntityConfigurations
{
    public class SchoolTypeConfiguration : IEntityTypeConfiguration<School>
    {
        private readonly IEnumerable<School> schools = new List<School>()
        {
            new School()
            {
                Name = "Акад. Никола Обрешков",
                Type = "ППМГ",
                City = "Разград"
            }
        };


        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.HasData(schools);
        }
    }
}
