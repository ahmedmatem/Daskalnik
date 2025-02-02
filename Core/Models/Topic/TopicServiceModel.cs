namespace Core.Models.Topic
{
    using System.ComponentModel.DataAnnotations;

    using static Infrastructure.Constants.DataConstants;
    using static Infrastructure.Data.ErrorMessages;

    using Core.Models.Resource;

    public class TopicServiceModel
    {
        /// <summary>
        /// Topic unique identifier.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Topic name.
        /// </summary>
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(
            TopicNameMaxLength, 
            MinimumLength = TopicNameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        [Display(Name = "Име")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Topic description.
        /// </summary>
        [MaxLength(TopicDescriptionMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        [Display(Name = "Описание")]
        public string? Description { get; set; }

        /// <summary>
        /// Topic contents items separated each in a new line.
        /// </summary>
        [Display(Name = "Съдържание")]
        public string Contents { get; set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the creator of the group and topics in the group.
        /// </summary>
        public string CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// Collection of resources for the topic in the group.
        /// </summary>
        //public IEnumerable<ResourceServiceModel> Resources { get; set; }
        //    = new HashSet<ResourceServiceModel>();
        public IEnumerable<TopicResourceServiceModel> Resources { get; set; }
            = new HashSet<TopicResourceServiceModel>();
    }
}
