using SB.TelegramBot;
using SB.TelegramBot.Example.Resources.Messages;

namespace SB.TeleramBot.Example.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class LanguageRuCommand : TelegramBotCallbackCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Execute()
        {
            UserService.SetCurrentUserLanguage("ru-RU");
            MessageService.SendMessage(TelegramBotMessages.UserSuccessfulyRegistered);
        }
    }
}
