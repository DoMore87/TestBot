using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace TestBot
{
    public class ExpenseBot
    {
        private TelegramBotClient _botClient;

        public ExpenseBot(string botToken)
        {
            _botClient = new TelegramBotClient(botToken);
        }

        public void Start()
        {
            _botClient.OnMessage += BotOnMessageReceived;
            _botClient.StartReceiving();
            var me = _botClient.GetMeAsync().Result;
            Console.WriteLine(me);
        }

        private async void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;
            if (message == null || message.Type != MessageType.TextMessage) return;
            await _botClient.SendTextMessageAsync(message.Chat.Id, message.Text);
        }
    }
}