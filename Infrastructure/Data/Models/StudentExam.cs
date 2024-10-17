namespace Infrastructure.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentExam
    {
        [Required]
        public string StudentId { get; set; } = null!;

        [Required]
        public string ExamId { get; set; } = null!;

        public Student Student { get; set; } = null!;

        public Exam Exam { get; set; } = null!;
    }
}
