using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Types
{
    public enum ResourceType
    {
        [Display(Description = "Тема")]
        Topic = 0,
        [Display(Description = "Изпитен материал")]
        Exam
    }
}
