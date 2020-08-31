using SB.TelegramBot.Logics.TelegramBotClients;
using SB.TelegramBot.Logics.TelegramBotMessages;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotMessageService : ITelegramBotMessageService
    {
        /// <summary>
        /// 
        /// </summary>
        public Message Message => TelegramBotMessageManager.Message.Value;

        /// <summary>
        /// 
        /// </summary>
        public Chat Chat => Message.Chat;

        /// <summary>
        /// 
        /// </summary>
        public long ChatId => Message.Chat.Id;

        /// <summary>
        /// 
        /// </summary>
        public int MessageId => Message.MessageId;

        /// <summary>
        /// 
        /// </summary>
        public string Text => Message.Text;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="replyMarkup"></param>
        public void EditMessage(string text, InlineKeyboardMarkup replyMarkup = null)
        {
            var client = TelegramBotClientManager.Client;
            client.EditMessageTextAsync(ChatId, MessageId, text, replyMarkup: replyMarkup);
        }

        /// <summary>
        /// 
        /// </summary>
        public void RemoveMessage()
        {
            var client = TelegramBotClientManager.Client;
            client.DeleteMessageAsync(ChatId, MessageId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="replyMarkup"></param>
        public void SendMessage(string text, IReplyMarkup replyMarkup = null)
        {
            var client = TelegramBotClientManager.Client;
            client.SendTextMessageAsync(Message.Chat.Id, text, replyMarkup: replyMarkup);
        }
    }
}
