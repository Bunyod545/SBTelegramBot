using Telegram.Bot.Types;
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
        /// <param name="replyMarkup"></param>
        void SendMessage(string text, IReplyMarkup replyMarkup = null);

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
