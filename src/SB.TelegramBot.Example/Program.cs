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
            TelegramBotApplication.Run("7668782175:AAHepyis4JQT9nT8aPJ6Ffc7S6FSaz50GMw");

            Console.WriteLine("Telegram bot started!");
            Console.WriteLine("Press enter to close!");
            Console.ReadLine();
        }
    }
}
