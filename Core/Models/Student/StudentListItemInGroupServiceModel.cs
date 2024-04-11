namespace Core.Models.Student
{
    public class StudentListItemInGroupServiceModel
    {
        /// <summary>
        /// Unique student identifier.
        /// </summary>
        public string StudentId { get; set; } = string.Empty;

        /// <summary>
        /// Full name of the student.
        /// </summary>
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// The school which the student belongs to.
        /// </summary>
        public Infrastructure.Data.Models.School School { get; set; } = null!;
    }
}
