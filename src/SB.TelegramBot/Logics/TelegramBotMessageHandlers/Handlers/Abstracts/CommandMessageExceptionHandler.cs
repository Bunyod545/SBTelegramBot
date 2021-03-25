using System;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class CommandMessageExceptionHandler : ICommandMessageExceptionHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="ex"></param>
        public virtual void HandleExecuteException(MessageContext context, Exception ex)
        {

        }
    }
}
