using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class TelegramBotBaseCommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="text"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableWebPagePreview"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> EditMessageTextV2Async(string text, ParseMode parseMode = 0, bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null, MessageEntity[] entities = default, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageTextV2Async(ChatId, MessageId, text, parseMode, disableWebPagePreview, replyMarkup, entities, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="text"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableWebPagePreview"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> EditMessageTextV2Async(ChatId chatId, int messageId, string text, ParseMode parseMode = 0, bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null, MessageEntity[] entities = default, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageTextV2Async(chatId, messageId, text, parseMode, disableWebPagePreview, replyMarkup, entities, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="text"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableWebPagePreview"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task EditMessageTextV2Async(string inlineMessageId, string text, ParseMode parseMode = 0, bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null, MessageEntity[] entities = default, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageTextV2Async(inlineMessageId, text, parseMode, disableWebPagePreview, replyMarkup, entities, cancellationToken);
        }
    }
}
