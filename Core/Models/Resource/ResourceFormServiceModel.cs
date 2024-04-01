using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;
using static Infrastructure.Data.ErrorMessages;

namespace Core.Models.Resource
{
    public class ResourceFormServiceModel : ResourceServiceModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "Ресурсен файл")]
        public IFormFile? ResourceFile { get; set; }
    }
}
