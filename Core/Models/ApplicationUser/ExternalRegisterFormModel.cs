﻿using Core.Models.School;
using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;
using static Infrastructure.Data.ErrorMessages;

namespace Core.Models.ApplicationUser
{
    public class ExternalRegisterFormModel
    {
        /// <summary>
        /// Use this property to pass created Application User identifier.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [EmailAddress]
        [Display(Name = "Имейл")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// The full name of the user.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            UserFullNameMaxLength,
            MinimumLength = UserFullNameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Име, презиме и фамилия")]
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// The name of the school the user wants to register in.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "Училище")]
        public string SchoolId { get; set; } = string.Empty;

        /// <summary>
        /// Contains list of all schools.
        /// </summary>
        public IEnumerable<SchoolViewModel> Schools { get; set; } = new List<SchoolViewModel>();

        /// <summary>
        /// The role which the user wants to participate on.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = " Роля")]
        public string Role { get; set; } = string.Empty;
    }
}
