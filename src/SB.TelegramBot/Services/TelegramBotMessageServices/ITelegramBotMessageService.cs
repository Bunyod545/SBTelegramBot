using System.Threading;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotMessageService
    {
        /// <summary>
        /// 
        /// </summary>
        Message Message { get; }

        /// <summary>
        /// 
        /// </summary>
        Chat Chat { get; }

        /// <summary>
        /// 
        /// </summary>
        long ChatId { get; }

        /// <summary>
        /// 
        /// </summary>
        int MessageId { get; }

        /// <summary>
        /// 
        /// </summary>
        string Text { get; }

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
        void SendMessage(string text, ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false, bool disableNotification = false, int replyToMessageId = 0, ReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="replyMarkup"></param>
        void EditMessage(string text, InlineKeyboardMarkup replyMarkup = null);

        /// <summary>
        /// 
        /// </summary>
        void RemoveMessage();
    }
}
