using System.Threading;
using System.Threading.Tasks;
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
        /// <param name="inlineMessageId"></param>
        /// <param name="caption"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="parseMode"></param>
        /// <returns></returns>
        public Task EditMessageCaptionAsync(string inlineMessageId, string caption, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default, ParseMode parseMode = ParseMode.Default)
        {
            return Client.EditMessageCaptionAsync(inlineMessageId, caption, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="caption"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="parseMode"></param>
        /// <returns></returns>
        public Task<Message> EditMessageCaptionAsync(ChatId chatId, int messageId, string caption, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default, ParseMode parseMode = ParseMode.Default)
        {
            return Client.EditMessageCaptionAsync(chatId, messageId, caption, replyMarkup, cancellationToken, parseMode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task EditMessageLiveLocationAsync(string inlineMessageId, float latitude, float longitude, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageLiveLocationAsync(inlineMessageId, latitude, longitude, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> EditMessageLiveLocationAsync(ChatId chatId, int messageId, float latitude, float longitude, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageLiveLocationAsync(chatId, messageId, latitude, longitude, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="media"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task EditMessageMediaAsync(InputMediaBase media, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageMediaAsync(ChatId, MessageId, media, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="media"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task EditMessageMediaAsync(string inlineMessageId, InputMediaBase media, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageMediaAsync(inlineMessageId, media, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="media"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> EditMessageMediaAsync(ChatId chatId, int messageId, InputMediaBase media, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageMediaAsync(chatId, messageId, media, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task EditMessageReplyMarkupAsync(InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageReplyMarkupAsync(ChatId, MessageId, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task EditMessageReplyMarkupAsync(string inlineMessageId, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageReplyMarkupAsync(inlineMessageId, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> EditMessageReplyMarkupAsync(ChatId chatId, int messageId, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageReplyMarkupAsync(chatId, messageId, replyMarkup, cancellationToken);
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
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> EditMessageTextAsync(string text, ParseMode parseMode = ParseMode.Default, bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageTextAsync(ChatId, MessageId, text, parseMode, disableWebPagePreview, replyMarkup, cancellationToken);
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
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> EditMessageTextAsync(ChatId chatId, int messageId, string text, ParseMode parseMode = ParseMode.Default, bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageTextAsync(chatId, messageId, text, parseMode, disableWebPagePreview, replyMarkup, cancellationToken);
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
        public Task EditMessageTextAsync(string inlineMessageId, string text, ParseMode parseMode = ParseMode.Default, bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageTextAsync(inlineMessageId, text, parseMode, disableWebPagePreview, replyMarkup, cancellationToken);
        }
    }
}
