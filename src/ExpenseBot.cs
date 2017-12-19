using System;
using System.Diagnostics;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using TestBot.Processors;

namespace TestBot
{
    public class ExpenseBot
    {
        private TelegramBotClient _botClient;
        private IMessageProcessor _messageProcessor;

        public ExpenseBot(string botToken)
        {
            _botClient = new TelegramBotClient(botToken);
            _messageProcessor = new GreetingsMessageProcessor(new HowAreYouMessageProcessor(new FallbackMessageProcessor()));
        }

        public void Start()
        {
            _botClient.OnMessage += BotOnMessageReceived;
            _botClient.StartReceiving();
        }

        private async void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
        {
            var sw = Stopwatch.StartNew();
            //Console.WriteLine($"Message received at {DateTime.Now}");
            var message = messageEventArgs.Message;
            if (message == null || message.Type != MessageType.TextMessage) return;
            await _botClient.SendTextMessageAsync(message.Chat.Id, _messageProcessor.Process(message.Text));
            //Console.WriteLine($"Request served in {sw.Elapsed}");
        }
    }
}