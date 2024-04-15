using Core.Models.Common;
using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;

namespace Core.Models.Teacher
{
    public class AllTeachersInSchoolQueryModel
    {
        public int TeachersPerPage { get; set; } = DefaultTeachersPerPage;

        [Display(Name = "Състояние")]
        public UserStatus Status { get; init; }

        [Display(Name = "Търсене по име")]
        public string SearchTerm { get; init; } = null!;

        public int CurrentPage { get; set; } = 1;

        public int SelectedPage { get; set; } = 1;

        public int TotalTeachersCount { get; set; }

        public IEnumerable<TeacherTableRowServiceModel> Teachers { get; set; } = new List<TeacherTableRowServiceModel>();
    }
}
