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
            TelegramBotApplication.Run("1777270229:AAEiHcIxWMxymgffTx57TxecEbBvalkNfL4");

            Console.WriteLine("Telegram bot started!");
            Console.WriteLine("Press enter to close!");
            Console.ReadLine();
        }
    }
}
