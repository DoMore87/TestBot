using System.Collections.Generic;

namespace TestBot
{
    public interface IMessageProcessor
    {
        string Process(string message);
    }
}