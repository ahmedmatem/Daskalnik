namespace Core.Models.Resource
{
    using Infrastructure.Data.Types;
    using System.ComponentModel.DataAnnotations;

    using static Infrastructure.Constants.DataConstants;
    using static Infrastructure.Data.ErrorMessages;
    public class ResourceServiceModel
    {
        /// <summary>
        /// Resource unique identifier
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// URL link to resource
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "Връзка към ресурс")]
        public string Link { get; set; } = string.Empty;

        /// <summary>
        /// User friendly link text to display.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            ResourceTextToDisplayMaxLength,
            MinimumLength = ResourceTextToDisplayMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Описателно име на линка към ресурса")]
        public string TextToDisplay { get; set; } = string.Empty;

        /// <summary>
        /// URL reference to resource icon.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "Иконка")]
        public string IconRef { get; set; } = string.Empty;

        /// <summary>
        /// Creator of the resource
        /// </summary>
        public string CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// Resource type for - (e.g. Exam, Topic ...)
        /// </summary>
        [Display(Name = "Тип")]
        [Required(ErrorMessage = RequiredErrorMessage)]
        public int ResourceType { get; set; } = 0;
    }
}
