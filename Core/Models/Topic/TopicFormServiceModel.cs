using System.ComponentModel.DataAnnotations;
using static Infrastructure.Data.ErrorMessages;
using static Infrastructure.Constants.DataConstants;
using Core.Models.Resource;

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

        public string CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// List of all resources for the topic creator.
        /// </summary>
        public IEnumerable<ResourceServiceModel> Resources { get; set; } = 
            new List<ResourceServiceModel>();

        /// <summary>
        /// Keeps selected resources for topic create by a teacher.
        /// </summary>
        public IEnumerable<string> SelectedResources { get; set; } = new List<string>();
    }
}
