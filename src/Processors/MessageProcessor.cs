using System;

namespace TestBot.Processors
{
    public abstract class MessageProcessor : IMessageProcessor
    {
        private IMessageProcessor _successor;
        protected abstract string[] Responses { get; }

        protected MessageProcessor(IMessageProcessor successor)
        {
            _successor = successor;
        }

        string IMessageProcessor.Process(string message)
        {
            if (IsCurrentTopic(message))
            {
                return GetRandomResponse();
            }
            return _successor.Process(message);
        }

        protected string GetRandomResponse()
        {
            var randomizer = new Random(DateTime.Now.Millisecond);
            return Responses[randomizer.Next(0, Responses.Length)];
        }

        protected abstract bool IsCurrentTopic(string message);

    }
}