using SB.TelegramBot;
using System;

namespace SB.TeleramBot.Example
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            TelegramBotApplication.Run("7117747622:AAEK6rtTtZFpM9Ck21B61Mm9dCbd-5-p1Yg");

            Console.WriteLine("Telegram bot started!");
            Console.WriteLine("Press enter to close!");
            Console.ReadLine();
        }
    }
}
