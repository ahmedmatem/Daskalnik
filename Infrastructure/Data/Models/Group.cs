using Infrastructure.Data.Abstracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Infrastructure.Constants.DataConstants;

namespace Infrastructure.Data.Models
{
    public class Group : DataModel
    {
        [Required]
        [MaxLength(GroupNameMaxLength)]
        [Comment("Group name.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(GroupShortNameMaxLength)]
        [Comment("Group short name.")]
        public string ShortName { get; set; } = string.Empty;

        [MaxLength(GroupDescriptionMaxLength)]
        [Comment("Group description.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Group icon url.")]
        public string IconUrl { get; set; } = string.Empty;

        [Required]
        [Comment("School identifier in which the group belongs to. ")]
        public string SchoolId { get; set; } = string.Empty;

        [Required]
        [Comment("Group creater identifier.")]
        public string TeacherId { get; set; } = string.Empty;

        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; } = null!;

        [ForeignKey("SchoolId")]
        public School School { get; set; } = null!;

        public List<IdentityUser> Students { get; set; } = new List<IdentityUser>();

        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
}
