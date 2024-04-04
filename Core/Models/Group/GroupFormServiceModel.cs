using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;
using static Infrastructure.Data.ErrorMessages;

namespace Core.Models.Group
{
    public class GroupFormServiceModel
    {
        /// <summary>
        /// Unique group identifier.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Name of the group.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            GroupNameMaxLength, 
            MinimumLength = GroupNameMinLength, 
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Име")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Short name of the group.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            GroupShortNameMaxLength,
            MinimumLength = GroupShortNameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Кратко име")]
        public string ShortName { get; set; } = string.Empty;

        /// <summary>
        /// Group short description.
        /// </summary>
        [MaxLength(GroupDescriptionMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        [Display(Name = "Кратко описание")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Path reference to group icon.
        /// </summary>
        [Display(Name = "Картинка")]
        public string IconUrl { get; set; } = string.Empty;

        public string SchoolId { get; set; } = string.Empty;

        public string TeacherId { get; set; } = string.Empty;
    }
}
