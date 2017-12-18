using System;
using Telegram.Bot;

namespace TestBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var bot = new ExpenseBot("472516916:AAHSqofGTucU604HL20wFKfpBYl9PhosRow");

            bot.Start();
            Console.WriteLine("Bot started!");
            Console.ReadLine();
            Console.WriteLine("Bot terminated..");
        }
    }
}