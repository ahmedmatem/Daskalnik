namespace Core.Models.Group
{
    public class GroupTableRowServiceModel
    {
        /// <summary>
        /// School unique identifier.
        /// </summary>
        public string SchoolId { get; set; } = string.Empty;

        /// <summary>
        /// Group unique identifier.
        /// </summary>
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// Reference to group icon location.
        /// </summary>
        public string IconUrl { get; set; } = string.Empty;

        /// <summary>
        /// Group short name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Group short name.
        /// </summary>
        public string ShortName { get; set; } = string.Empty;

        /// <summary>
        /// The name of the group owner.
        /// </summary>
        public string GroupOwnerName { get; set; } = string.Empty;

        public bool IsDeleted { get; set; }
    }
}
