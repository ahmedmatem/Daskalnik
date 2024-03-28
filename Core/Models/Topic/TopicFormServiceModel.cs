using System.ComponentModel.DataAnnotations;
using static Infrastructure.Data.ErrorMessages;
using static Infrastructure.Constants.DataConstants;
using Infrastructure.Data.Models;
using Microsoft.AspNetCore.Http;

namespace Core.Models.Topic
{
    public class TopicFormServiceModel
    {
        /// <summary>
        /// Topic unique identifier
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Topic name
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            TopicNameMaxLength,
            MinimumLength = TopicNameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Име")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(TopicDescriptionMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        [Display(Name = "Описание")]
        public string? Description { get; set; }

        /// <summary>
        /// Topic contents items separated each in a new line.
        /// </summary>
        [Display(Name = "Съдържание")]
        public string Contents { get; set; } = string.Empty;

        public string CreaterId { get; set; } = string.Empty;
    }
}
