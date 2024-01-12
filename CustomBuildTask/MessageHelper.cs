namespace Test
{
    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    internal static class MessageHelper
    {
        public static void LogMessage(string message, TaskLoggingHelper logger)
        {
            logger.LogMessage(MessageImportance.Normal, $"Message '{message}' received from custom build task 😎");
        }
    }
}
