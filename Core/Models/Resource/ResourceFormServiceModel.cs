namespace Core.Models.Resource
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    using static Infrastructure.Data.ErrorMessages;

    public class ResourceFormServiceModel : ResourceServiceModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "Ресурсен файл")]
        public IFormFile? ResourceFile { get; set; }
    }
}
