using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;
using static Infrastructure.Data.ErrorMessages;

namespace Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// User full name.
        /// </summary>
        [MaxLength(UserFullNameMaxLength,ErrorMessage = MaxLengthErrorMessage)]
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Unique identifier of school the user wants to participate in.
        /// </summary>
        public string SchoolId { get; set; } = string.Empty ;
    }
}
