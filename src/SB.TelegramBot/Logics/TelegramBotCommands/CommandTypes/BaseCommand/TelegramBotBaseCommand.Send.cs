using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.Payments;
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
        /// <param name="animation"></param>
        /// <param name="duration"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="thumb"></param>
        /// <param name="caption"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendAnimationAsync(InputFile animation, int duration = 0, int width = 0, int height = 0, InputFile thumb = null, string caption = null, ParseMode parseMode = ParseMode.Markdown, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new SendAnimationRequest(ChatId, animation);
            request.Duration = duration;
            request.Width = width;
            request.Height = height;
            request.Thumbnail = thumb;
            request.Caption = caption;
            request.ParseMode = parseMode;
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;

            return Client.MakeRequestAsync(request, cancellationToken); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="animation"></param>
        /// <param name="duration"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="thumb"></param>
        /// <param name="caption"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendAnimationAsync(ChatId chatId, InputFile animation, int duration = 0, int width = 0, int height = 0, InputFile thumb = null, string caption = null, ParseMode parseMode = ParseMode.Markdown, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new SendAnimationRequest(chatId, animation);
            request.Duration = duration;
            request.Width = width;
            request.Height = height;
            request.Thumbnail = thumb;
            request.Caption = caption;
            request.ParseMode = parseMode;
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="audio"></param>
        /// <param name="caption"></param>
        /// <param name="parseMode"></param>
        /// <param name="duration"></param>
        /// <param name="performer"></param>
        /// <param name="title"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="thumb"></param>
        /// <returns></returns>
        public Task<Message> SendAudioAsync(InputFile audio, string caption = null, ParseMode parseMode = ParseMode.Markdown, int duration = 0, string performer = null, string title = null, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputFile thumb = null)
        {
            var request = new SendAudioRequest(ChatId, audio);
            request.Duration = duration;
            request.Caption = caption;
            request.Performer = performer;
            request.Title = title;
            request.ParseMode = parseMode;
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;
            request.Thumbnail = thumb;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="audio"></param>
        /// <param name="caption"></param>
        /// <param name="parseMode"></param>
        /// <param name="duration"></param>
        /// <param name="performer"></param>
        /// <param name="title"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="thumb"></param>
        /// <returns></returns>
        public Task<Message> SendAudioAsync(ChatId chatId, InputFile audio, string caption = null, ParseMode parseMode = ParseMode.Markdown, int duration = 0, string performer = null, string title = null, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputFile thumb = null)
        {
            var request = new SendAudioRequest(chatId, audio);
            request.Duration = duration;
            request.Caption = caption;
            request.Performer = performer;
            request.Title = title;
            request.ParseMode = parseMode;
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;
            request.Thumbnail = thumb;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="chatAction"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task SendChatActionAsync(ChatAction chatAction, CancellationToken cancellationToken = default)
        {
            var request = new SendChatActionRequest(ChatId, chatAction);
            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="chatAction"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task SendChatActionAsync(ChatId chatId, ChatAction chatAction, CancellationToken cancellationToken = default)
        {
            var request = new SendChatActionRequest(chatId, chatAction);
            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="vCard"></param>
        /// <returns></returns>
        public Task<Message> SendContactAsync(string phoneNumber, string firstName, string lastName = null, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, string vCard = null)
        {
            var request = new SendContactRequest(ChatId, phoneNumber, firstName);
            request.LastName = lastName;
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;
            request.Vcard = vCard;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="vCard"></param>
        /// <returns></returns>
        public Task<Message> SendContactAsync(ChatId chatId, string phoneNumber, string firstName, string lastName = null, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, string vCard = null)
        {
            var request = new SendContactRequest(chatId, phoneNumber, firstName);
            request.LastName = lastName;
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;
            request.Vcard = vCard;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="emoji"></param>
        /// <returns></returns>
        public Task<Message> SendDiceAsync(bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, Emoji? emoji = null)
        {
            var request = new SendDiceRequest(ChatId);
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;
            request.Emoji = emoji;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="emoji"></param>
        /// <returns></returns>
        public Task<Message> SendDiceAsync(ChatId chatId, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, Emoji? emoji = null)
        {
            var request = new SendDiceRequest(chatId);
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;
            request.Emoji = emoji;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="document"></param>
        /// <param name="caption"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="thumb"></param>
        /// <returns></returns>
        public Task<Message> SendDocumentAsync(InputFile document, string caption = null, ParseMode parseMode = ParseMode.Markdown, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputFile thumb = null)
        {
            var request = new SendDocumentRequest(ChatId, document);
            request.Caption = caption;
            request.ParseMode = parseMode;
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;
            request.Thumbnail = thumb;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="document"></param>
        /// <param name="caption"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="thumb"></param>
        /// <returns></returns>
        public Task<Message> SendDocumentAsync(ChatId chatId, InputFile document, string caption = null, ParseMode parseMode = ParseMode.Markdown, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputFile thumb = null)
        {
            var request = new SendDocumentRequest(chatId, document);
            request.Caption = caption;
            request.ParseMode = parseMode;
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;
            request.Thumbnail = thumb;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="gameShortName"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendGameAsync(string gameShortName, bool disableNotification = false, int replyToMessageId = 0, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new SendGameRequest(ChatId, gameShortName);
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="gameShortName"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendGameAsync(long chatId, string gameShortName, bool disableNotification = false, int replyToMessageId = 0, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new SendGameRequest(chatId, gameShortName);
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;

            return Client.MakeRequestAsync(request, cancellationToken);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableWebPagePreview"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendTextMessageV2Async(string text, ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, MessageEntity[] entities = default, CancellationToken cancellationToken = default)
        {
            return Client.SendTextMessageV2Async(ChatId, text, parseMode, disableWebPagePreview, disableNotification, replyToMessageId, replyMarkup, entities, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableWebPagePreview"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendTextMessageAsync(string text, ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new SendMessageRequest(ChatId, text);
            request.ParseMode = parseMode;
            request.DisableWebPagePreview = disableWebPagePreview;
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="text"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableWebPagePreview"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendTextMessageAsync(ChatId chatId, string text, ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var request = new SendMessageRequest(chatId, text);
            request.ParseMode = parseMode;
            request.DisableWebPagePreview = disableWebPagePreview;
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;

            return Client.MakeRequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="text"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableWebPagePreview"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendTextMessageV2Async(ChatId chatId, string text, ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, MessageEntity[] entities = default, CancellationToken cancellationToken = default)
        {
            return Client.SendTextMessageV2Async(chatId, text, parseMode, disableWebPagePreview, disableNotification, replyToMessageId, replyMarkup, entities, cancellationToken);
        }
    }
}
