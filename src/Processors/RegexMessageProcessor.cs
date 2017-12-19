using System.Text.RegularExpressions;

namespace TestBot.Processors
{
    public abstract class RegexMessageProcessor : MessageProcessor
    {
        protected abstract string RegexPattern { get; }
        protected RegexMessageProcessor(IMessageProcessor successor) : base(successor)
        {
        }

        protected override bool IsCurrentTopic(string message)
        {
            if (Regex.Match(message, RegexPattern, RegexOptions.IgnoreCase).Success)
                return true;
            return false;
        }
    }
}