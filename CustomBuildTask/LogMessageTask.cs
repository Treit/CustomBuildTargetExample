namespace Test
{
    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    public class LogMessageTask : Task
    {
        [Required]
        public string Message { get; set; }

        public override bool Execute()
        {
            MessageHelper.LogMessage(Message, Log);
            return true;
        }
    }
}
