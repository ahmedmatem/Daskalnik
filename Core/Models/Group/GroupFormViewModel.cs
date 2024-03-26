﻿using Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;
using static Infrastructure.Data.ErrorMessages;

namespace Core.Models.Group
{
    public class GroupFormViewModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            GroupNameMaxLength, 
            MinimumLength = GroupNameMinLength, 
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Име")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            GroupShortNameMaxLength,
            MinimumLength = GroupShortNameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Кратко име")]
        public string ShortName { get; set; } = string.Empty;

        [MaxLength(GroupDescriptionMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        [Display(Name = "Кратко описание")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Картинка")]
        public string IconUrl { get; set; } = string.Empty;
    }
}
