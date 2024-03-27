namespace Infrastructure.Constants
{
    public static class DataConstants
    {
        public const int StudentFullNameMinLength = 5;
        public const int StudentFullNameMaxLength = 50;

        public const int TeacherFullNameMinLength = 5;
        public const int TeacherFullNameMaxLength = 50;

        public const int SchoolNameMinLength = 10;
        public const int SchoolNameMaxLength = 100;
        public const int SchoolTypeMinLength = 2;
        public const int SchoolTypeMaxLength = 7;
        public const int SchoolCityMinLength = 3;
        public const int SchoolCityMaxLength = 13;

        public const int GroupNameMinLength = 2;
        public const int GroupNameMaxLength = 50;
        public const int GroupShortNameMinLength = 2;
        public const int GroupShortNameMaxLength = 7;
        public const int GroupDescriptionMaxLength = 150;

        public const int TopicNameMinLength = 2;
        public const int TopicNameMaxLength = 40;
        public const int TopicDescriptionMaxLength = 150;

        public const int ResourceTextToDisplayMinLength = 3;
        public const int ResourceTextToDisplayMaxLength = 30;

        public const long PostedFileMaxSizeInBytes = 50 * 1024; // 50KB
    }
}
