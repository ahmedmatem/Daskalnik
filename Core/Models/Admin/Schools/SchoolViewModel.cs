using Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;
using static Infrastructure.Data.ErrorMessages;

namespace Core.Models.Admin.Schools
{
    public class SchoolViewModel
    {
        public string Id { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            SchoolNameMaxLength,
            MinimumLength = SchoolNameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Име", Prompt = "")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
             SchoolTypeMaxLength,
             MinimumLength = SchoolTypeMinLength,
             ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Тип", Prompt = "")]
        public string Type { get; set; } = String.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            SchoolCityMaxLength,
            MinimumLength = SchoolCityMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Населено място", Prompt = "")]
        public string City { get; set; } = string.Empty;

        [Display(Name = "Администратор на училище")]
        public Teacher? SchoolAdmin { get; set; }
    }
}
