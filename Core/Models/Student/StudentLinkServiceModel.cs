namespace Core.Models.Student
{
    using System.ComponentModel.DataAnnotations;

    public class StudentLinkServiceModel
    {
        public string Id { get; set; } = string.Empty;

        [Display(Name = "Име")]
        public string FullName { get; set; } = string.Empty;
    }
}
