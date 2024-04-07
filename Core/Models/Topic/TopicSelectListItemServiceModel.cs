namespace Core.Models.Topic
{
    /// <summary>
    /// Contains key-value pair of the Topic model.
    /// </summary>
    public class TopicSelectListItemServiceModel
    {
        /// <summary>
        /// Topic key - unique identifier.
        /// </summary>
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// Topic value - text to display (usualy name of the Topic).
        /// </summary>
        public string Value { get; set; } = string.Empty;
    }
}
