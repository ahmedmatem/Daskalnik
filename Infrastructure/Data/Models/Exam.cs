namespace Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    using Infrastructure.Data.Abstracts;
    using Infrastructure.Data.Types;
    using static Infrastructure.Constants.DataConstants;

    public class Exam : DataModel
    {
        [Required]
        [MaxLength(ExamTitleMaxLength)]
        [Comment("Exam title")]
        public string Title { get; set; } = string.Empty;

        [Comment("A brief description of the exam’s content, scope, or purpose.")]
        public string Description { get; set; } = string.Empty ;

        [Required]
        [Comment("Unique identifier of the creator of the exam.")]
        public string CreatorId { get; set; } = string.Empty;

        [Comment("The scheduled date and time when the exam is to be taken.")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Comment("The time duration of the exam, measured in minutes.")]
        public int Duration { get; set; }

        [Comment("The total number of marks the exam is worth (e.g., 100 points).")]
        public int TotalMarks { get; set; }

        [Comment("The minimum marks required to pass the exam (e.g., 40 points out of 100).\r\n")]
        public int PassMarks { get; set; }

        [Comment("The current state of the exam (e.g., Scheduled, Ongoing, Completed, Graded).")]
        public int Status { get; set; } = (int)ExamStatus.Unscheduled;

        [Comment("Any special instructions or rules for taking the exam (e.g., No calculators allowed).")]
        public string Instruction { get; set; } = string.Empty;

        // Navigation properties

        public List<Group> Groups { get; set; } = new List<Group>();

        public List<Student> AssignedStudents { get; set; } = new List<Student>();

        public List<ExamResource> Resources { get; set; } = new List<ExamResource>();
    }
}
