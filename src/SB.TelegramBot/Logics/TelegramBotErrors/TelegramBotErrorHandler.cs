using System;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotErrorHandler : ITelegramBotErrorHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception"></param>
        public void Handle(Exception exception)
        {
            Console.WriteLine(exception.ToString());
        }
    }
}
