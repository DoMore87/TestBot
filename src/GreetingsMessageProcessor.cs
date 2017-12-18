using System.Text.RegularExpressions;
namespace TestBot
{
    public class GreetingsMessageProcessor : MessageProcessor
    {
        protected override string[] Responses => new[] { "Ciao!",
            "Bella! ;)",
            "Dimmi tutto",
            "Ehilà!",
            "Cosa c'è stavolta???Scherzo, dimmi pure!",
            "Eccomi, a tua disposizione!" };

        public GreetingsMessageProcessor(IMessageProcessor successor) : base(successor)
        { }        

        protected override bool IsCurrentTopic(string message)
        {
            var regex = "^(Ciao|Buonasera|Buongiorno|Bella|Ehil|Salve|Buond) +bot";
            if (Regex.Match(message, regex, RegexOptions.IgnoreCase).Success)
                return true;
            return false;
        }
    }
}