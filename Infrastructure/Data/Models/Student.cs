﻿namespace Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using Infrastructure.Data.Abstracts;
    using static Infrastructure.Constants.DataConstants;

    public class Student : PersonModel
    {
        [Required]
        [MaxLength(StudentFullNameMaxLength)]
        [Comment("Student full name.")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [Comment("Unique identifier of school the student attends.")]
        public string SchoolId { get; set; } = string.Empty;

        public School School { get; set; } = null!;

        public List<Group> Groups { get; set; } = new List<Group>();

        public List<Exam> Exams { get; set; } = new List<Exam>();
    }
}
