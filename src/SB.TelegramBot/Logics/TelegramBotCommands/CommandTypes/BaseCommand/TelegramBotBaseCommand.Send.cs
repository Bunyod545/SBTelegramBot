using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InputFiles;
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
        public Task<Message> SendAnimationAsync(InputOnlineFile animation, int duration = 0, int width = 0, int height = 0, InputMedia thumb = null, string caption = null, ParseMode parseMode = ParseMode.Default, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendAnimationAsync(ChatId, animation, duration, width, height, thumb, caption, parseMode, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
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
        public Task<Message> SendAnimationAsync(ChatId chatId, InputOnlineFile animation, int duration = 0, int width = 0, int height = 0, InputMedia thumb = null, string caption = null, ParseMode parseMode = ParseMode.Default, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendAnimationAsync(chatId, animation, duration, width, height, thumb, caption, parseMode, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
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
        public Task<Message> SendAudioAsync(InputOnlineFile audio, string caption = null, ParseMode parseMode = ParseMode.Default, int duration = 0, string performer = null, string title = null, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputMedia thumb = null)
        {
            return Client.SendAudioAsync(ChatId, audio, caption, parseMode, duration, performer, title, disableNotification, replyToMessageId, replyMarkup, cancellationToken, thumb);
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
        public Task<Message> SendAudioAsync(ChatId chatId, InputOnlineFile audio, string caption = null, ParseMode parseMode = ParseMode.Default, int duration = 0, string performer = null, string title = null, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputMedia thumb = null)
        {
            return Client.SendAudioAsync(chatId, audio, caption, parseMode, duration, performer, title, disableNotification, replyToMessageId, replyMarkup, cancellationToken, thumb);
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
            return Client.SendChatActionAsync(ChatId, chatAction, cancellationToken);
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
            return Client.SendChatActionAsync(chatId, chatAction, cancellationToken);
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
            return Client.SendContactAsync(ChatId, phoneNumber, firstName, lastName, disableNotification, replyToMessageId, replyMarkup, cancellationToken, vCard);
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
            return Client.SendContactAsync(chatId, phoneNumber, firstName, lastName, disableNotification, replyToMessageId, replyMarkup, cancellationToken, vCard);
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
            return Client.SendDiceAsync(ChatId, disableNotification, replyToMessageId, replyMarkup, cancellationToken, emoji);
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
            return Client.SendDiceAsync(chatId, disableNotification, replyToMessageId, replyMarkup, cancellationToken, emoji);
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
        public Task<Message> SendDocumentAsync(InputOnlineFile document, string caption = null, ParseMode parseMode = ParseMode.Default, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputMedia thumb = null)
        {
            return Client.SendDocumentAsync(ChatId, document, caption, parseMode, disableNotification, replyToMessageId, replyMarkup, cancellationToken, thumb);
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
        public Task<Message> SendDocumentAsync(ChatId chatId, InputOnlineFile document, string caption = null, ParseMode parseMode = ParseMode.Default, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputMedia thumb = null)
        {
            return Client.SendDocumentAsync(chatId, document, caption, parseMode, disableNotification, replyToMessageId, replyMarkup, cancellationToken, thumb);
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
            return Client.SendGameAsync(ChatId, gameShortName, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
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
            return Client.SendGameAsync(chatId, gameShortName, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="payload"></param>
        /// <param name="providerToken"></param>
        /// <param name="startParameter"></param>
        /// <param name="currency"></param>
        /// <param name="prices"></param>
        /// <param name="providerData"></param>
        /// <param name="photoUrl"></param>
        /// <param name="photoSize"></param>
        /// <param name="photoWidth"></param>
        /// <param name="photoHeight"></param>
        /// <param name="needName"></param>
        /// <param name="needPhoneNumber"></param>
        /// <param name="needEmail"></param>
        /// <param name="needShippingAddress"></param>
        /// <param name="isFlexible"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="sendPhoneNumberToProvider"></param>
        /// <param name="sendEmailToProvider"></param>
        /// <returns></returns>
        public Task<Message> SendInvoiceAsync(string title, string description, string payload, string providerToken, string startParameter, string currency, IEnumerable<LabeledPrice> prices, string providerData = null, string photoUrl = null, int photoSize = 0, int photoWidth = 0, int photoHeight = 0, bool needName = false, bool needPhoneNumber = false, bool needEmail = false, bool needShippingAddress = false, bool isFlexible = false, bool disableNotification = false, int replyToMessageId = 0, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default, bool sendPhoneNumberToProvider = false, bool sendEmailToProvider = false)
        {
            return Client.SendInvoiceAsync((int)ChatId, title, description, payload, providerToken, startParameter, currency, prices, providerData, photoUrl, photoSize, photoWidth, photoHeight, needName, needPhoneNumber, needEmail, needShippingAddress, isFlexible, disableNotification, replyToMessageId, replyMarkup, cancellationToken, sendPhoneNumberToProvider, sendEmailToProvider);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="payload"></param>
        /// <param name="providerToken"></param>
        /// <param name="startParameter"></param>
        /// <param name="currency"></param>
        /// <param name="prices"></param>
        /// <param name="providerData"></param>
        /// <param name="photoUrl"></param>
        /// <param name="photoSize"></param>
        /// <param name="photoWidth"></param>
        /// <param name="photoHeight"></param>
        /// <param name="needName"></param>
        /// <param name="needPhoneNumber"></param>
        /// <param name="needEmail"></param>
        /// <param name="needShippingAddress"></param>
        /// <param name="isFlexible"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="sendPhoneNumberToProvider"></param>
        /// <param name="sendEmailToProvider"></param>
        /// <returns></returns>
        public Task<Message> SendInvoiceAsync(int chatId, string title, string description, string payload, string providerToken, string startParameter, string currency, IEnumerable<LabeledPrice> prices, string providerData = null, string photoUrl = null, int photoSize = 0, int photoWidth = 0, int photoHeight = 0, bool needName = false, bool needPhoneNumber = false, bool needEmail = false, bool needShippingAddress = false, bool isFlexible = false, bool disableNotification = false, int replyToMessageId = 0, InlineKeyboardMarkup replyMarkup = null, CancellationToken cancellationToken = default, bool sendPhoneNumberToProvider = false, bool sendEmailToProvider = false)
        {
            return Client.SendInvoiceAsync(chatId, title, description, payload, providerToken, startParameter, currency, prices, providerData, photoUrl, photoSize, photoWidth, photoHeight, needName, needPhoneNumber, needEmail, needShippingAddress, isFlexible, disableNotification, replyToMessageId, replyMarkup, cancellationToken, sendPhoneNumberToProvider, sendEmailToProvider);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="livePeriod"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendLocationAsync(float latitude, float longitude, int livePeriod = 0, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendLocationAsync(ChatId, latitude, longitude, livePeriod, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="livePeriod"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendLocationAsync(ChatId chatId, float latitude, float longitude, int livePeriod = 0, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendLocationAsync(chatId, latitude, longitude, livePeriod, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputMedia"></param>
        /// <param name="chatId"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message[]> SendMediaGroupAsync(IEnumerable<IAlbumInputMedia> inputMedia, bool disableNotification = false, int replyToMessageId = 0, CancellationToken cancellationToken = default)
        {
            return Client.SendMediaGroupAsync(inputMedia, ChatId, disableNotification, replyToMessageId, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputMedia"></param>
        /// <param name="chatId"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message[]> SendMediaGroupAsync(IEnumerable<IAlbumInputMedia> inputMedia, ChatId chatId, bool disableNotification = false, int replyToMessageId = 0, CancellationToken cancellationToken = default)
        {
            return Client.SendMediaGroupAsync(inputMedia, chatId, disableNotification, replyToMessageId, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="media"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("Use the other overload of this method instead. Only photo and video input types are allowed.")]
        public Task<Message[]> SendMediaGroupAsync(IEnumerable<InputMediaBase> media, bool disableNotification = false, int replyToMessageId = 0, CancellationToken cancellationToken = default)
        {
            return Client.SendMediaGroupAsync(ChatId, media, disableNotification, replyToMessageId, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="media"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("Use the other overload of this method instead. Only photo and video input types are allowed.")]
        public Task<Message[]> SendMediaGroupAsync(ChatId chatId, IEnumerable<InputMediaBase> media, bool disableNotification = false, int replyToMessageId = 0, CancellationToken cancellationToken = default)
        {
            return Client.SendMediaGroupAsync(chatId, media, disableNotification, replyToMessageId, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="photo"></param>
        /// <param name="caption"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendPhotoAsync(InputOnlineFile photo, string caption = null, ParseMode parseMode = ParseMode.Default, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendPhotoAsync(ChatId, photo, caption, parseMode, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="photo"></param>
        /// <param name="caption"></param>
        /// <param name="parseMode"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendPhotoAsync(ChatId chatId, InputOnlineFile photo, string caption = null, ParseMode parseMode = ParseMode.Default, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendPhotoAsync(chatId, photo, caption, parseMode, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="question"></param>
        /// <param name="options"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="isAnonymous"></param>
        /// <param name="type"></param>
        /// <param name="allowsMultipleAnswers"></param>
        /// <param name="correctOptionId"></param>
        /// <param name="isClosed"></param>
        /// <param name="explanation"></param>
        /// <param name="explanationParseMode"></param>
        /// <param name="openPeriod"></param>
        /// <param name="closeDate"></param>
        /// <returns></returns>
        public Task<Message> SendPollAsync(string question, IEnumerable<string> options, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, bool? isAnonymous = null, PollType? type = null, bool? allowsMultipleAnswers = null, int? correctOptionId = null, bool? isClosed = null, string explanation = null, ParseMode explanationParseMode = ParseMode.Default, int? openPeriod = null, DateTime? closeDate = null)
        {
            return Client.SendPollAsync(ChatId, question, options, disableNotification, replyToMessageId, replyMarkup, cancellationToken, isAnonymous, type, allowsMultipleAnswers, correctOptionId, isClosed, explanation, explanationParseMode, openPeriod, closeDate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="question"></param>
        /// <param name="options"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="isAnonymous"></param>
        /// <param name="type"></param>
        /// <param name="allowsMultipleAnswers"></param>
        /// <param name="correctOptionId"></param>
        /// <param name="isClosed"></param>
        /// <param name="explanation"></param>
        /// <param name="explanationParseMode"></param>
        /// <param name="openPeriod"></param>
        /// <param name="closeDate"></param>
        /// <returns></returns>
        public Task<Message> SendPollAsync(ChatId chatId, string question, IEnumerable<string> options, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, bool? isAnonymous = null, PollType? type = null, bool? allowsMultipleAnswers = null, int? correctOptionId = null, bool? isClosed = null, string explanation = null, ParseMode explanationParseMode = ParseMode.Default, int? openPeriod = null, DateTime? closeDate = null)
        {
            return Client.SendPollAsync(chatId, question, options, disableNotification, replyToMessageId, replyMarkup, cancellationToken, isAnonymous, type, allowsMultipleAnswers, correctOptionId, isClosed, explanation, explanationParseMode, openPeriod, closeDate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="sticker"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendStickerAsync(InputOnlineFile sticker, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendStickerAsync(ChatId, sticker, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="sticker"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendStickerAsync(ChatId chatId, InputOnlineFile sticker, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendStickerAsync(chatId, sticker, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
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
        public Task<Message> SendTextMessageAsync(string text, ParseMode parseMode = ParseMode.Default, bool disableWebPagePreview = false, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendTextMessageAsync(ChatId, text, parseMode, disableWebPagePreview, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
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
        public Task<Message> SendTextMessageAsync(ChatId chatId, string text, ParseMode parseMode = ParseMode.Default, bool disableWebPagePreview = false, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendTextMessageAsync(chatId, text, parseMode, disableWebPagePreview, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="title"></param>
        /// <param name="address"></param>
        /// <param name="foursquareId"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="foursquareType"></param>
        /// <returns></returns>
        public Task<Message> SendVenueAsync(float latitude, float longitude, string title, string address, string foursquareId = null, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, string foursquareType = null)
        {
            return Client.SendVenueAsync(ChatId, latitude, longitude, title, address, foursquareId, disableNotification, replyToMessageId, replyMarkup, cancellationToken, foursquareType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="title"></param>
        /// <param name="address"></param>
        /// <param name="foursquareId"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="foursquareType"></param>
        /// <returns></returns>
        public Task<Message> SendVenueAsync(ChatId chatId, float latitude, float longitude, string title, string address, string foursquareId = null, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, string foursquareType = null)
        {
            return Client.SendVenueAsync(chatId, latitude, longitude, title, address, foursquareId, disableNotification, replyToMessageId, replyMarkup, cancellationToken, foursquareType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="video"></param>
        /// <param name="duration"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="caption"></param>
        /// <param name="parseMode"></param>
        /// <param name="supportsStreaming"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="thumb"></param>
        /// <returns></returns>
        public Task<Message> SendVideoAsync(InputOnlineFile video, int duration = 0, int width = 0, int height = 0, string caption = null, ParseMode parseMode = ParseMode.Default, bool supportsStreaming = false, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputMedia thumb = null)
        {
            return Client.SendVideoAsync(ChatId, video, duration, width, height, caption, parseMode, supportsStreaming, disableNotification, replyToMessageId, replyMarkup, cancellationToken, thumb);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="video"></param>
        /// <param name="duration"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="caption"></param>
        /// <param name="parseMode"></param>
        /// <param name="supportsStreaming"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="thumb"></param>
        /// <returns></returns>
        public Task<Message> SendVideoAsync(ChatId chatId, InputOnlineFile video, int duration = 0, int width = 0, int height = 0, string caption = null, ParseMode parseMode = ParseMode.Default, bool supportsStreaming = false, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputMedia thumb = null)
        {
            return Client.SendVideoAsync(chatId, video, duration, width, height, caption, parseMode, supportsStreaming, disableNotification, replyToMessageId, replyMarkup, cancellationToken, thumb);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="videoNote"></param>
        /// <param name="duration"></param>
        /// <param name="length"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="thumb"></param>
        /// <returns></returns>
        public Task<Message> SendVideoNoteAsync(InputTelegramFile videoNote, int duration = 0, int length = 0, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputMedia thumb = null)
        {
            return Client.SendVideoNoteAsync(ChatId, videoNote, duration, length, disableNotification, replyToMessageId, replyMarkup, cancellationToken, thumb);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="videoNote"></param>
        /// <param name="duration"></param>
        /// <param name="length"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="thumb"></param>
        /// <returns></returns>
        public Task<Message> SendVideoNoteAsync(ChatId chatId, InputTelegramFile videoNote, int duration = 0, int length = 0, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputMedia thumb = null)
        {
            return Client.SendVideoNoteAsync(chatId, videoNote, duration, length, disableNotification, replyToMessageId, replyMarkup, cancellationToken, thumb);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="voice"></param>
        /// <param name="caption"></param>
        /// <param name="parseMode"></param>
        /// <param name="duration"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendVoiceAsync(InputOnlineFile voice, string caption = null, ParseMode parseMode = ParseMode.Default, int duration = 0, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendVoiceAsync(ChatId, voice, caption, parseMode, duration, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="voice"></param>
        /// <param name="caption"></param>
        /// <param name="parseMode"></param>
        /// <param name="duration"></param>
        /// <param name="disableNotification"></param>
        /// <param name="replyToMessageId"></param>
        /// <param name="replyMarkup"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<Message> SendVoiceAsync(ChatId chatId, InputOnlineFile voice, string caption = null, ParseMode parseMode = ParseMode.Default, int duration = 0, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendVoiceAsync(chatId, voice, caption, parseMode, duration, disableNotification, replyToMessageId, replyMarkup, cancellationToken);
        }
    }
}
