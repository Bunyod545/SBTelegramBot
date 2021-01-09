using System;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICommandMessageExceptionHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="ex"></param>
        void HandleExecuteException(MessageContext context, Exception ex);
    }
}
