using System;
using Telegram.Bot;

namespace TestBot
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("472516916:AAHSqofGTucU604HL20wFKfpBYl9PhosRow");

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}