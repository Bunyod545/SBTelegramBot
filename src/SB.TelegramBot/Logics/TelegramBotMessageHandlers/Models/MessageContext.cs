using SB.TelegramBot.Services;
using Telegram.Bot.Types;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class MessageContext
    {
        /// <summary>
        /// 
        /// </summary>
        public Message Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotUserService UserService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotUserInfo User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UserRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICommandMessageHandler NextHandler { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsCanNextHandler { get; set; } = true;

        /// <summary>
        /// 
        /// </summary>
        public void MessageHandled()
        {
            IsCanNextHandler = false;
        }
    }
}
