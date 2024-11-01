﻿namespace Core.Models.Exam
{
    using System.ComponentModel.DataAnnotations;

    using Core.Models.Resource;

    using static Infrastructure.Data.ErrorMessages;
    using static Infrastructure.Constants.DataConstants;

    public class CreateExamServiceModel
    {
        /// <summary>
        /// Exam unique identifier
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Exam name
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(ExamTitleMaxLength,
            MinimumLength = ExamTitleMinLength, 
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Име")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Exam description
        /// </summary>
        [MaxLength(ExamDescriptionMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        [Display(Name = "Описание")]
        public string? Description { get; set; }

        /// <summary>
        /// Unique identifier of the exam creator
        /// </summary>
        public string CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// List of all exam resources belongs to creator.
        /// </summary>
        [Display(Name = "Изпитни ресурси")]
        public IEnumerable<ResourceServiceModel> CreatorAllExamResources { get; set; } =
            new List<ResourceServiceModel>();

        /// <summary>
        /// List of all resources currently added to exam
        /// </summary>
        [Display(Name = "Ресурси")]
        public IEnumerable<ResourceServiceModel> AddedResources { get; set; } =
            new List<ResourceServiceModel>();

        /// <summary>
        /// Keeps selected resources for exam created by the teacher/creator.
        /// </summary>
        [Display(Name = "Ресурси")]
        public IEnumerable<string> SelectedResources { get; set; } = new List<string>();
    }
}
