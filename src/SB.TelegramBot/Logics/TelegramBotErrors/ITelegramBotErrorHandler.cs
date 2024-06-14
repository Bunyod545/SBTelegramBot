using System;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotErrorHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception"></param>
        void Handle(Exception exception);
    }
}
