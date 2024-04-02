using Core.Models.Resource;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.Topic
{
    public class TopicDetailsServiceModel
    {
        /// <summary>
        /// Topic main details.
        /// </summary>
        public TopicFormServiceModel TopicDetails { get; set; } = null!;

        /// <summary>
        /// Topic resource files ditails.
        /// </summary>
        [Display(Name = "Ресурси")]
        public IEnumerable<ResourceServiceModel> Resources { get; set; }
            = new HashSet<ResourceServiceModel>();
    }
}
