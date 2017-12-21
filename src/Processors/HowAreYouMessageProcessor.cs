namespace TestBot.Processors
{
    public class HowAreYouMessageProcessor : RegexMessageProcessor
    {
        protected override string RegexPattern => @"^Come +(va|butta|stai)\??";

        protected override string[] Responses => new[] { "Alla grande!",
        "Non c'è male, grazie",
        "Sono un bot semplice, mi basta poco per essere felice",
        "Bene, bene",
        "Non potrbbe andare meglio!",
        "Come al solito, senza infamia e senza lode" };

        public HowAreYouMessageProcessor(IMessageProcessor successor) : base(successor)
        {
        }
    }
}