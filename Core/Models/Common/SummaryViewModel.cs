namespace Core.Models.Common
{
    public class SummaryViewModel
    {
        public string Title { get; set; } = string.Empty;

        public string ImageSrc { get; set; } = string.Empty;

        public string Controller { get; set; } = string.Empty;

        public string Action { get; set; } = string.Empty;

        public string Area { get; set; } = string.Empty;

        public int Value { get; set; }
    }
}
