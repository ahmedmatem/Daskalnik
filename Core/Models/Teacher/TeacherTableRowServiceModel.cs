namespace Core.Models.Teacher
{
    public class TeacherTableRowServiceModel
    {
        /// <summary>
        /// School unique identifier.
        /// </summary>
        public string SchoolId { get; set; } = string.Empty;

        /// <summary>
        /// Teacher unique identifier.
        /// </summary>
        public string TeacherId { get; set; } = string.Empty;

        /// <summary>
        /// The name of the teacher.
        /// </summary>
        public string FullName { get; set; } = string.Empty;

        public bool IsDeleted { get; set; }

        public bool IsActivated { get; set; }
    }
}
