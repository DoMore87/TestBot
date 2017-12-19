using System.Collections.Generic;

namespace TestBot.Processors
{
    public interface IMessageProcessor
    {
        string Process(string message);
    }
}