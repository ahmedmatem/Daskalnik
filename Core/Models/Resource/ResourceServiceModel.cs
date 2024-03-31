using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;
using static Infrastructure.Data.ErrorMessages;

namespace Core.Models.Resource
{
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
        public string Link { get; set; } = string.Empty;

        /// <summary>
        /// User friendly link text to display.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            ResourceTextToDisplayMaxLength,
            MinimumLength = ResourceTextToDisplayMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public string TextToDisplay { get; set; } = string.Empty;

        /// <summary>
        /// URL reference to resource icon.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        public string IconRef { get; set; } = string.Empty;
    }
}
