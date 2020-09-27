using Telegram.Bot.Args;


namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotMessageHandler : ITelegramBotMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void Handle(object sender, MessageEventArgs e)
        {
            TelegramBotMessageHandlerManager.Handle(e.Message);
        }
    }
}
