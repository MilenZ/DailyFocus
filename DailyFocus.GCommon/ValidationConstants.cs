namespace DailyFocus.GCommon;

public static class ValidationConstants
{
    public static class TaskComment
    {
        public const int MaxCommentLength = 500;
    }

    public static class TaskItem
    {
        public const int MaxTitleLength = 100;
        public const int MaxDescriptionLength = 500;
        public const string DateAssignmentFormat = "dd-MM-yyyy"; // ISO format for DateOnly
        public const string CreatedOnFormat = "dd-MM-yyyy HH:mm:ss"; // ISO format for DateTime
    }

    public static class Category
    {
        public const int MaxNameLength = 50;
        public const int MaxDescriptionLength = 500;
        public const int MaxColorLength = 7; // Hex color code length
    }

    public static class SupportMessage
    {
        public const int MaxMessageLength = 1000;
        public const int MaxSubjectLength = 100;
        public const int MaxEmailLength = 255;
        public const string CreatedOnFormat = "dd-MM-yyyy HH:mm:ss";
    }

    public static class UserStatistics
    {
        public const string LastActiveDateFormat = "dd-MM-yyyy HH:mm:ss";
    }

    public static class TaskItemTag
    {
        public const string CreatedOnFormat = "dd-MM-yyyy HH:mm:ss";
    }

    public static class SessionPreset
    {
        public const int MaxNameLength = 100;
    }

    public static class Tag
    {
        public const int MaxNameLength = 100;
    }
}
