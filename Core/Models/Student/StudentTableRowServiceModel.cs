namespace Core.Models.Student
{
    public class StudentTableRowServiceModel
    {
        /// <summary>
        /// School unique identifier.
        /// </summary>
        public string SchoolId { get; set; } = string.Empty;

        /// <summary>
        /// Student unique identifier.
        /// </summary>
        public string StudentId { get; set; } = string.Empty;

        /// <summary>
        /// The name of the student.
        /// </summary>
        public string FullName { get; set; } = string.Empty;
    }
}
