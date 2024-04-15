namespace Infrastructure.Constants
{
    public static class DataConstants
    {
        public const int DefaultTeachersPerPage = 2;

        public const int UserFullNameMinLength = 5;
        public const int UserFullNameMaxLength = 50;

        public const int StudentFullNameMinLength = 5;
        public const int StudentFullNameMaxLength = 50;

        public const int TeacherFullNameMinLength = 5;
        public const int TeacherFullNameMaxLength = 50;

        public const int SchoolNameMinLength = 10;
        public const int SchoolNameMaxLength = 150;
        public const int SchoolTypeMinLength = 2;
        public const int SchoolTypeMaxLength = 7;
        public const int SchoolCityMinLength = 3;
        public const int SchoolCityMaxLength = 13;

        public const int GroupNameMinLength = 2;
        public const int GroupNameMaxLength = 100;
        public const int GroupShortNameMinLength = 2;
        public const int GroupShortNameMaxLength = 7;
        public const int GroupDescriptionMaxLength = 200;

        public const int TopicNameMinLength = 2;
        public const int TopicNameMaxLength = 100;
        public const int TopicDescriptionMaxLength = 200;

        public const int ResourceTextToDisplayMinLength = 3;
        public const int ResourceTextToDisplayMaxLength = 50;

        public const long PostedFileMaxSizeInBytes = 50 * 1024; // 50KB

        public static Dictionary<string, string> ResourceIconRef = new Dictionary<string, string>()
        {
            { "default", "<i class=\"fa-regular fa-file\"></i>"},
            { "excel", "<i class=\"fa-regular fa-file-excel\"></i>"},
            { "word", "<i class=\"fa-regular fa-file-word\"></i>"},
            { "pdf", "<i class=\"fa-regular fa-file-pdf\"></i>"},
            { "video", "<i class=\"fa-regular fa-file-video\"></i>"},
            { "image", "<i class=\"fa-regular fa-file-image\"></i>"},
            { "powerpoint", "<i class=\"fa-regular fa-file-powerpoint\"></i>"},
            { "audio", "<i class=\"fa-regular fa-file-audio\"></i>"},
            { "code", "<i class=\"fa-regular fa-file-code\"></i>"},
            { "youtube", "<i class=\"fa-brands fa-youtube\"></i>"},
        };
    }
}
