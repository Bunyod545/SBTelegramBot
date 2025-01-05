using System;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPollExceptionHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        void HandleExecuteException(Exception ex);
    }
}
