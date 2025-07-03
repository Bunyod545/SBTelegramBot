using Newtonsoft.Json;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;

namespace SB.TelegramBot.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class SbEditInlineMessageTextRequest : EditInlineMessageTextRequest
    {
        /// <summary>
        /// Optional. For text messages, special entities like usernames, URLs, bot commands, etc. that appear in the text
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MessageEntity[] Entities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="text"></param>
        public SbEditInlineMessageTextRequest(string inlineMessageId, string text)
        {
            InlineMessageId = inlineMessageId;
            Text = text;
        }
    }
}
