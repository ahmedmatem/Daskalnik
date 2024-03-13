using Infrastructure.Data.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Infrastructure.Data.DataConstants;

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
        [Comment("Group creater identifier.")]
        public string TeacherId { get; set; } = string.Empty;

        public Teacher Teacher { get; set; } = null!;

        public List<Student> Students { get; set; } = new List<Student>();

        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
}
