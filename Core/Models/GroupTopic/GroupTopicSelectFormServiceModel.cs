﻿namespace Core.Models.GroupTopic
{
    using System.ComponentModel.DataAnnotations;

    using Core.Models.Common;

    public class GroupTopicSelectFormServiceModel
    {
        /// <summary>
        /// Unique group identifier.
        /// </summary>
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// The name of the group.
        /// </summary>
        [Display(Name = "Име")]
        public string GroupName { get; set; } = string.Empty;

        /// <summary>
        /// Contains all topics belonging to a teacher could be added to its group.
        /// It does not contain already added topics in the group.
        /// </summary>
        public IList<CheckBoxModel> TopicsListToAdd { get; set; } 
            = new List<CheckBoxModel>();
    }
}
