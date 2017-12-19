using System.Text.RegularExpressions;

namespace TestBot.Processors
{
    public class GreetingsMessageProcessor : RegexMessageProcessor
    {
        protected override string[] Responses => new[] { "Ciao!",
            "Bella! ;)",
            "Dimmi tutto",
            "Ehilà!",
            "Cosa c'è stavolta???Scherzo, dimmi pure!",
            "Eccomi, a tua disposizione!" };

        protected override string RegexPattern => "^(Ciao|Buonasera|Buongiorno|Bella|Ehilà|Salve|Buondì) +bot";

        public GreetingsMessageProcessor(IMessageProcessor successor) : base(successor)
        { } 
    }
}