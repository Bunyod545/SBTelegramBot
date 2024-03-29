using Autofac.Features.Metadata;
using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Requests;
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
        public Task EditMessageCaptionAsync(string inlineMessageId, string caption, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default, ParseMode parseMode = ParseMode.Markdown)
        {
            var request = new EditMessageCaptionRequest(ChatId, MessageId);
            request.Caption = caption;
            request.ReplyMarkup = replyMarkup;
            request.ParseMode = parseMode;

            return Client.MakeRequestAsync(request, cancellationToken);
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
        public Task<Message> EditMessageCaptionAsync(ChatId chatId, int messageId, string caption, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default, ParseMode parseMode = ParseMode.Markdown)
        {
            var request = new EditMessageCaptionRequest(chatId, messageId);
            request.Caption = caption;
            request.ReplyMarkup = replyMarkup;
            request.ParseMode = parseMode;

            return Client.MakeRequestAsync(request, cancellationToken);
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
        public Task EditMessageLiveLocationAsync(int inlineMessageId, float latitude, float longitude, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new EditMessageLiveLocationRequest(ChatId, inlineMessageId, latitude, longitude);
            request.ReplyMarkup = replyMarkup;

            return Client.MakeRequestAsync(request, cancellationToken);
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
            var request = new EditMessageLiveLocationRequest(ChatId, messageId, latitude, longitude);
            request.ReplyMarkup = replyMarkup;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="media"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task EditMessageMediaAsync(InputMedia media, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new EditMessageMediaRequest(ChatId, MessageId, media);
            request.ReplyMarkup = replyMarkup;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="media"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task EditMessageMediaAsync(int inlineMessageId, InputMedia media, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new EditMessageMediaRequest(ChatId, inlineMessageId, media);
            request.ReplyMarkup = replyMarkup;

            return Client.MakeRequestAsync(request, cancellationToken);
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
        public Task<Message> EditMessageMediaAsync(ChatId chatId, int messageId, InputMedia media, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new EditMessageMediaRequest(chatId, messageId, media);
            request.ReplyMarkup = replyMarkup;

            return Client.MakeRequestAsync(request, cancellationToken);
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
            var request = new EditMessageReplyMarkupRequest(ChatId, MessageId);
            request.ReplyMarkup = replyMarkup;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inlineMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task EditMessageReplyMarkupAsync(int inlineMessageId, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new EditMessageReplyMarkupRequest(ChatId, inlineMessageId);
            request.ReplyMarkup = replyMarkup;

            return Client.MakeRequestAsync(request, cancellationToken);
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
        public Task<Message> EditMessageTextAsync(string text, ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new EditMessageTextRequest(ChatId, MessageId, text);
            request.ParseMode = parseMode;
            request.ReplyMarkup = replyMarkup;
            request.DisableWebPagePreview = disableWebPagePreview;

            return Client.MakeRequestAsync(request, cancellationToken);
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
        public Task<Message> EditMessageTextAsync(ChatId chatId, int messageId, string text, ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new EditMessageTextRequest(chatId, messageId, text);
            request.ParseMode = parseMode;
            request.ReplyMarkup = replyMarkup;
            request.DisableWebPagePreview = disableWebPagePreview;

            return Client.MakeRequestAsync(request, cancellationToken); 
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
        public Task<Message> EditMessageTextV2Async(string text, ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null, MessageEntity[] entities = default, CancellationToken cancellationToken = default)
        {
            var request = new EditMessageTextRequest(ChatId, MessageId, text);
            request.ParseMode = parseMode;
            request.ReplyMarkup = replyMarkup;
            request.DisableWebPagePreview = disableWebPagePreview;
            request.Entities = entities;

            return Client.MakeRequestAsync(request, cancellationToken);
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
        public Task<Message> EditMessageTextV2Async(ChatId chatId, int messageId, string text, ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null, MessageEntity[] entities = default, CancellationToken cancellationToken = default)
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
        public Task EditMessageTextAsync(int inlineMessageId, string text, ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new EditMessageTextRequest(ChatId, inlineMessageId, text);
            request.ParseMode = parseMode;
            request.ReplyMarkup = replyMarkup;
            request.DisableWebPagePreview = disableWebPagePreview;

            return Client.MakeRequestAsync(request, cancellationToken);
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
        public Task EditMessageTextV2Async(string inlineMessageId, string text, ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false, InlineKeyboardMarkup replyMarkup = null, MessageEntity[] entities = default, CancellationToken cancellationToken = default)
        {
            return Client.EditMessageTextV2Async(inlineMessageId, text, parseMode, disableWebPagePreview, replyMarkup, entities, cancellationToken);
        }
    }
}
