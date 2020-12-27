using Newtonsoft.Json;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;

namespace SB.TelegramBot.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class SbEditMessageTextRequest : EditMessageTextRequest
    {
        /// <summary>
        /// Optional. For text messages, special entities like usernames, URLs, bot commands, etc. that appear in the text
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MessageEntity[] Entities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="text"></param>
        public SbEditMessageTextRequest(ChatId chatId, int messageId, string text) : base(chatId, messageId, text)
        {
        }
    }
}
