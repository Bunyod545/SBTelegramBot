using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
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
        public Task<Message> SendAnimationAsync(InputFile animation, int duration = 0, int width = 0, int height = 0,
            InputFile thumb = null, string caption = null, ParseMode parseMode = ParseMode.Markdown,
            bool disableNotification = false, int replyToMessageId = 0, ReplyMarkup replyMarkup = null,
            CancellationToken cancellationToken = default)
        {
            return Client.SendAnimation(
                ChatId,
                animation,
                caption,
                parseMode,
                replyToMessageId,
                replyMarkup: replyMarkup,
                duration,
                width,
                height,
                thumb,
                disableNotification: disableNotification,
                cancellationToken: cancellationToken);
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
        public Task<Message> SendAnimationAsync(ChatId chatId, InputFile animation, int duration = 0, int width = 0,
            int height = 0, InputFile thumb = null, string caption = null, ParseMode parseMode = ParseMode.Markdown,
            bool disableNotification = false, int replyToMessageId = 0, ReplyMarkup replyMarkup = null,
            CancellationToken cancellationToken = default)
        {
            return Client.SendAnimation(
                chatId,
                animation,
                caption,
                parseMode,
                replyToMessageId,
                replyMarkup: replyMarkup,
                duration,
                width,
                height,
                thumb,
                disableNotification: disableNotification,
                cancellationToken: cancellationToken);
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
        public Task<Message> SendAudioAsync(InputFile audio, string caption = null,
            ParseMode parseMode = ParseMode.Markdown, int duration = 0, string performer = null, string title = null,
            bool disableNotification = false, int replyToMessageId = 0, ReplyMarkup replyMarkup = null,
            CancellationToken cancellationToken = default, InputFile thumb = null)
        {
            return Client.SendAudio(
                ChatId,
                audio,
                caption,
                parseMode,
                replyToMessageId,
                replyMarkup,
                duration,
                performer,
                title,
                thumb,
                disableNotification: disableNotification,
                cancellationToken: cancellationToken);
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
        public Task<Message> SendAudioAsync(ChatId chatId, InputFile audio, string caption = null,
            ParseMode parseMode = ParseMode.Markdown, int duration = 0, string performer = null, string title = null,
            bool disableNotification = false, int replyToMessageId = 0, ReplyMarkup replyMarkup = null,
            CancellationToken cancellationToken = default, InputFile thumb = null)
        {
            return Client.SendAudio(
                chatId,
                audio,
                caption,
                parseMode,
                replyToMessageId,
                replyMarkup,
                duration,
                performer,
                title,
                thumb,
                disableNotification: disableNotification,
                cancellationToken: cancellationToken);
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
            return Client.SendChatAction(ChatId, chatAction, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="chatAction"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task SendChatActionAsync(ChatId chatId, ChatAction chatAction,
            CancellationToken cancellationToken = default)
        {
            return Client.SendChatAction(chatId, chatAction, cancellationToken: cancellationToken);
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
        public Task<Message> SendContactAsync(string phoneNumber, string firstName, string lastName = null,
            bool disableNotification = false, int replyToMessageId = 0, ReplyMarkup replyMarkup = null,
            CancellationToken cancellationToken = default, string vCard = null)
        {
            return Client.SendContact(
                ChatId,
                phoneNumber,
                firstName,
                lastName,
                vCard,
                replyToMessageId,
                replyMarkup,
                disableNotification: disableNotification,
                cancellationToken: cancellationToken);
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
        public Task<Message> SendContactAsync(ChatId chatId, string phoneNumber, string firstName,
            string lastName = null, bool disableNotification = false, int replyToMessageId = 0,
            ReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, string vCard = null)
        {
            return Client.SendContact(
                chatId,
                phoneNumber,
                firstName,
                lastName,
                vCard,
                replyToMessageId,
                replyMarkup,
                disableNotification: disableNotification,
                cancellationToken: cancellationToken);
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
        public Task<Message> SendDiceAsync(bool disableNotification = false, int replyToMessageId = 0,
            ReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, string? emoji = null)
        {
            return Client.SendDice(
                ChatId,
                emoji,
                replyToMessageId,
                replyMarkup,
                cancellationToken: cancellationToken);
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
        public Task<Message> SendDiceAsync(ChatId chatId, bool disableNotification = false, int replyToMessageId = 0,
            ReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, string? emoji = null)
        {
            return Client.SendDice(
                chatId,
                emoji,
                replyToMessageId,
                replyMarkup,
                cancellationToken: cancellationToken);
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
        public Task<Message> SendDocumentAsync(InputFile document, string caption = null,
            ParseMode parseMode = ParseMode.Markdown, bool disableNotification = false, int replyToMessageId = 0,
            ReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputFile thumb = null)
        {
            return Client.SendDocument(
                ChatId,
                document,
                caption,
                parseMode,
                replyToMessageId,
                replyMarkup,
                thumb,
                disableNotification: disableNotification,
                cancellationToken: cancellationToken);
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
        public Task<Message> SendDocumentAsync(ChatId chatId, InputFile document, string caption = null,
            ParseMode parseMode = ParseMode.Markdown, bool disableNotification = false, int replyToMessageId = 0,
            ReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default, InputFile thumb = null)
        {
            return Client.SendDocument(
                chatId,
                document,
                caption,
                parseMode,
                replyToMessageId,
                replyMarkup,
                thumb,
                disableNotification: disableNotification,
                cancellationToken: cancellationToken);
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
        public Task<Message> SendGameAsync(string gameShortName, bool disableNotification = false,
            int replyToMessageId = 0, InlineKeyboardMarkup replyMarkup = null,
            CancellationToken cancellationToken = default)
        {
            return Client.SendGame(
                ChatId,
                gameShortName,
                replyToMessageId,
                replyMarkup,
                disableNotification: disableNotification,
                cancellationToken: cancellationToken);
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
        public Task<Message> SendGameAsync(long chatId, string gameShortName, bool disableNotification = false,
            int replyToMessageId = 0, InlineKeyboardMarkup replyMarkup = null,
            CancellationToken cancellationToken = default)
        {
            return Client.SendGame(
                chatId,
                gameShortName,
                replyToMessageId,
                replyMarkup,
                disableNotification: disableNotification,
                cancellationToken: cancellationToken);
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
        public Task<Message> SendTextMessageV2Async(string text, ParseMode parseMode = ParseMode.Markdown,
            bool disableWebPagePreview = false, bool disableNotification = false, int replyToMessageId = 0,
            ReplyMarkup replyMarkup = null, MessageEntity[] entities = default,
            CancellationToken cancellationToken = default)
        {
            return Client.SendTextMessageV2Async(ChatId, text, parseMode, disableWebPagePreview, disableNotification,
                replyToMessageId, replyMarkup, entities, cancellationToken);
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
        public Task<Message> SendTextMessageAsync(string text, ParseMode parseMode = ParseMode.Markdown,
            bool disableWebPagePreview = false, bool disableNotification = false, int replyToMessageId = 0,
            ReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendMessage(
                ChatId,
                text,
                parseMode,
                replyToMessageId,
                replyMarkup,
                disableNotification: disableNotification,
                cancellationToken: cancellationToken);
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
        public Task<Message> SendTextMessageAsync(ChatId chatId, string text, ParseMode parseMode = ParseMode.Markdown,
            bool disableWebPagePreview = false, bool disableNotification = false, int replyToMessageId = 0,
            ReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            return Client.SendMessage(
                chatId,
                text,
                parseMode,
                replyToMessageId,
                replyMarkup,
                disableNotification: disableNotification,
                cancellationToken: cancellationToken);
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
        public Task<Message> SendTextMessageV2Async(ChatId chatId, string text,
            ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false,
            bool disableNotification = false, int replyToMessageId = 0, ReplyMarkup replyMarkup = null,
            MessageEntity[] entities = default, CancellationToken cancellationToken = default)
        {
            return Client.SendTextMessageV2Async(chatId, text, parseMode, disableWebPagePreview, disableNotification,
                replyToMessageId, replyMarkup, entities, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="poll"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Message> SendPoolMesssage<T>(
            ChatId chatId,
            string question,
            IEnumerable<InputPollOption> options,
            bool isAnonymous = true,
            string pollCommandData = null,
            int? messageThreadId = null,
            PollType? pollType = null,
            bool allowsMultipleAnswers = false,
            int? correctOptionId = null,
            string explanation = null,
            IEnumerable<MessageEntity> explanationEntities = null,
            int? openPeriod = null,
            ParseMode explanationParseMode = ParseMode.None,
            DateTime? closeDate = null,
            bool isClosed = false,
            bool disableNotification = false,
            bool protectContent = false,
            int? replyToMessageId = null,
            bool? allowSendingWithoutReply = null,
            ReplyMarkup replyMarkup = null,
            CancellationToken cancellationToken = default)
            where T : TelegramBotPollCommand
        {
            var result = await Client.SendPoll(
                chatId,
                question,
                options,
                isAnonymous,
                pollType,
                allowsMultipleAnswers,
                correctOptionId,
                replyToMessageId,
                replyMarkup, explanation, explanationParseMode,
                explanationEntities,
                openPeriod: openPeriod,
                closeDate: closeDate,
                isClosed: isClosed,
                disableNotification: disableNotification,
                protectContent: protectContent,
                cancellationToken: cancellationToken);

            PollService.HandleSend<T>(chatId.ToString(), messageThreadId?.ToString(), result.Poll.Id, question,
                pollCommandData);
            return result;
        }
    }
}