namespace Daskalnik.Infrastructure.Data.Models
{
    public class GroupsAndMembers
    {
        public string GroupId { get; set; } = string.Empty;

        public string MemberId { get; set; } = string.Empty;

        public Group Group { get; set; } = null!;

        public ApplicationUser Member { get; set; } = null!;
    }
}
