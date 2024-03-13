﻿using Infrastructure.Data.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Infrastructure.Data.DataConstants;

namespace Infrastructure.Data.Models
{
    public class School : DataModel
    {
        [Required]
        [MaxLength(SchoolNameMaxLength)]
        [Comment("School name.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(SchoolTypeMaxLength)]
        [Comment("School type identifier - например: ОУ, ППМГ, ГПЕЧЕ.")]
        public string Type { get; set; } = String.Empty;

        [Required]
        [MaxLength(SchoolCityMaxLength)]
        [Comment("The name of the city the school belongs to.")]
        public string City { get; set; } = string.Empty;
    }
}