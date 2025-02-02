namespace Core.Models.Exam
{
    using System.ComponentModel.DataAnnotations;

    using Infrastructure.Data.Types;
    using static Infrastructure.Constants.DataConstants;
    using static Infrastructure.Data.ErrorMessages;

    public class ExamServiceModel
    {
        /// <summary>
        /// Exam unique identifier.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Exam title.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            ExamTitleMaxLength,
            MinimumLength = ExamTitleMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Име")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Exam description.
        /// </summary>
        [MaxLength(ExamDescriptionMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        [Display(Name = "Описание")]
        public string? Description { get; set; }

        /// <summary>
        /// Unique identifier of the creator of the exam.
        /// </summary>
        public string CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// The scheduled date and time when the exam is to be taken.
        /// </summary>
        [Display(Name = "Начало")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The time duration of the exam, measured in minutes.
        /// </summary>
        [Display(Name = "Времетраене")]
        public int Duration { get; set; }

        /// <summary>
        /// The total number of marks the exam is worth (e.g., 100 points).
        /// </summary>
        [Display(Name = "Общо точки")]
        public int TotalMarks { get; set; }

        /// <summary>
        /// The minimum marks required to pass the exam (e.g., 40 points out of 100).
        /// </summary>
        [Display(Name = "")]
        public int PassMarks { get; set; }

        /// <summary>
        /// The current state of the exam (e.g., Scheduled, Ongoing, Completed, Graded).
        /// </summary>
        [Display(Name = "Състояние")]
        public int Status { get; set; } = (int)ExamStatus.Unscheduled;

        /// <summary>
        /// Any special instructions or rules for taking the exam (e.g., No calculators allowed).
        /// </summary>
        [Display(Name = "Инструкция")]
        public string Instruction { get; set; } = string.Empty;

        public List<ExamResourceServiceModel> Resources { get; set; } = new List<ExamResourceServiceModel>();
    }
}
