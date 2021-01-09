using Telegram.Bot.Requests;
using Telegram.Bot.Types;

namespace SB.TelegramBot.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class SbSendVoiceMessageRequest : RequestBase<Message>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="methodName"></param>
        public SbSendVoiceMessageRequest(string methodName) : base(methodName)
        {
        }
    }
}
