using Telegram.Bot.Types;

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
        public Message Message => MessageService.Message;

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
    }
}
