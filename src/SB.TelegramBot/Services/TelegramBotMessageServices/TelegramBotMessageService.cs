using SB.TelegramBot.Logics.TelegramBotClients;
using SB.TelegramBot.Logics.TelegramBotMessages;
using System.Threading;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
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
        public ITelegramBotClientManager TelegramBotClientManager { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="telegramBotClientManager"></param>
        public TelegramBotMessageService(ITelegramBotClientManager telegramBotClientManager)
        {
            TelegramBotClientManager = telegramBotClientManager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="replyMarkup"></param>
        public virtual void EditMessage(string text, InlineKeyboardMarkup replyMarkup = null)
        {
            var client = TelegramBotClientManager.Client;
            var request = new EditMessageTextRequest(ChatId, MessageId, text);
            client.MakeRequestAsync(request);
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void RemoveMessage()
        {
            var client = TelegramBotClientManager.Client;
            var request = new DeleteMessageRequest(ChatId, MessageId);
            client.MakeRequestAsync(request);
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
        public virtual void SendMessage(string text, ParseMode parseMode = ParseMode.Markdown, bool disableWebPagePreview = false, bool disableNotification = false, int replyToMessageId = 0, IReplyMarkup replyMarkup = null, CancellationToken cancellationToken = default)
        {
            var client = TelegramBotClientManager.Client; 
            var request = new SendMessageRequest(ChatId, text);
            request.ParseMode = parseMode;
            request.DisableWebPagePreview = disableWebPagePreview;
            request.DisableNotification = disableNotification;
            request.ReplyToMessageId = replyToMessageId;
            request.ReplyMarkup = replyMarkup;

            client.MakeRequestAsync(request, cancellationToken);
        }
    }
}
