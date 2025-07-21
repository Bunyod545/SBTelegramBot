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
        public virtual void Handle(Exception exception)
        {
            Console.WriteLine(exception.ToString());
        }
    }
}
