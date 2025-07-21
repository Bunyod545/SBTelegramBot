using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
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
        public Task EditMessageCaptionAsync(string inlineMessageId, string caption,
            InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default,
            ParseMode parseMode = ParseMode.Markdown)
        {
            return Client.EditMessageCaption(
                ChatId,
                MessageId,
                caption,
                parseMode,
                replyMarkup: replyMarkup,
                cancellationToken: cancellationToken);
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
        public Task<Message> EditMessageCaptionAsync(ChatId chatId, int messageId, string caption,
            InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default,
            ParseMode parseMode = ParseMode.Markdown)
        {
            return Client.EditMessageCaption(
                chatId,
                messageId,
                caption,
                parseMode,
                replyMarkup: replyMarkup,
                cancellationToken: cancellationToken);
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
        public Task EditMessageLiveLocationAsync(int inlineMessageId, float latitude, float longitude,
            InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageLiveLocation(
                ChatId,
                inlineMessageId,
                latitude,
                longitude,
                replyMarkup: replyMarkup,
                cancellationToken: cancellationToken);
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
        public Task<Message> EditMessageLiveLocationAsync(ChatId chatId, int messageId, float latitude, float longitude,
            InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageLiveLocation(
                ChatId,
                messageId,
                latitude,
                longitude,
                replyMarkup: replyMarkup,
                cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="media"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task EditMessageMediaAsync(InputMedia media, InlineKeyboardMarkup replyMarkup = null,
            CancellationToken cancellationToken = default)
        {
            return Client.EditMessageMedia(
                ChatId,
                MessageId,
                media,
                replyMarkup,
                cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="media"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task EditMessageMediaAsync(int inlineMessageId, InputMedia media,
            InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageMedia(
                ChatId,
                inlineMessageId,
                media,
                replyMarkup,
                cancellationToken: cancellationToken);
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
        public Task<Message> EditMessageMediaAsync(ChatId chatId, int messageId, InputMedia media,
            InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageMedia(
                chatId,
                messageId,
                media,
                replyMarkup: replyMarkup,
                cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task EditMessageReplyMarkupAsync(InlineKeyboardMarkup replyMarkup = null,
            CancellationToken cancellationToken = default)
        {
            return Client.EditMessageReplyMarkup(
                ChatId,
                MessageId,
                replyMarkup: replyMarkup,
                cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task EditMessageReplyMarkupAsync(int inlineMessageId, InlineKeyboardMarkup replyMarkup = null,
            CancellationToken cancellationToken = default)
        {
            return Client.EditMessageReplyMarkup(
                ChatId,
                inlineMessageId,
                replyMarkup,
                cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableWebPagePreview"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> EditMessageTextAsync(string text, ParseMode parseMode = ParseMode.Markdown,
            bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null,
            CancellationToken cancellationToken = default)
        {
            return Client.EditMessageText(
                ChatId,
                MessageId,
                text,
                parseMode,
                replyMarkup: replyMarkup,
                cancellationToken: cancellationToken,
                linkPreviewOptions: disableWebPagePreview);
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
        public Task<Message> EditMessageTextAsync(ChatId chatId, int messageId, string text,
            ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false,
            InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageText(
                chatId,
                messageId,
                text,
                parseMode,
                replyMarkup: replyMarkup,
                cancellationToken: cancellationToken);
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
        public Task<Message> EditMessageTextV2Async(string text, ParseMode parseMode = ParseMode.Markdown,
            bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null,
            MessageEntity[] entities = default, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageText(
                ChatId,
                MessageId,
                text,
                parseMode,
                entities,
                replyMarkup: replyMarkup,
                cancellationToken: cancellationToken);
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
        public Task<Message> EditMessageTextV2Async(ChatId chatId, int messageId, string text,
            ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false,
            InlineKeyboardMarkup replyMarkup = null, MessageEntity[] entities = default,
            CancellationToken cancellationToken = default)
        {
            return Client.EditMessageTextV2Async(chatId, messageId, text, parseMode, disableWebPagePreview, replyMarkup,
                entities, cancellationToken);
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
        public Task EditMessageTextAsync(int inlineMessageId, string text, ParseMode parseMode = ParseMode.Markdown,
            bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null,
            CancellationToken cancellationToken = default)
        {
            return Client.EditMessageText(
                chatId: ChatId,
                inlineMessageId,
                text,
                parseMode,
                replyMarkup: replyMarkup,
                cancellationToken: cancellationToken);
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
        public Task EditMessageTextV2Async(string inlineMessageId, string text,
            ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false,
            InlineKeyboardMarkup replyMarkup = null, MessageEntity[] entities = default,
            CancellationToken cancellationToken = default)
        {
            return Client.EditMessageTextV2Async(inlineMessageId, text, parseMode, disableWebPagePreview, replyMarkup,
                entities, cancellationToken);
        }
    }
}