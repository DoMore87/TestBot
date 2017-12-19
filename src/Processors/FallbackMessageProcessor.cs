namespace TestBot.Processors
{
    public class FallbackMessageProcessor : MessageProcessor
    {
        protected override string[] Responses => new string[] {
            "Non ho capito..",
            "???",
            "Il mio creatore non mi ha insegnato come rispondere in questi casi",
            "Forse con il prossimo aggiornamento saprò risponderti",
            "Sono un semplice Bot, la mia Intelligenza Artificiale è limitata",
            "Non conosco questi argomenti purtroppo",
            "Non so come risponderti" };

        public FallbackMessageProcessor() : base(null)
        { }

        protected override bool IsCurrentTopic(string message)
        {
            return true;
        }
    }
}