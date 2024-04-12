using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;
using static Infrastructure.Data.ErrorMessages;

namespace Core.Models.School
{
    public class SchoolViewModel
    {
        /// <summary>
        /// School unique identifier.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// School name.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            SchoolNameMaxLength,
            MinimumLength = SchoolNameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Име", Prompt = "")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// School type.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
             SchoolTypeMaxLength,
             MinimumLength = SchoolTypeMinLength,
             ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Тип", Prompt = "")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// The name of the city the school belongs to.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            SchoolCityMaxLength,
            MinimumLength = SchoolCityMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Населено място", Prompt = "")]
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Teacher that is school administrator.
        /// </summary>
        [Display(Name = "Администратор на училище")]
        public Infrastructure.Data.Models.Teacher? SchoolAdmin { get; set; }
    }
}
