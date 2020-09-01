using SB.TelegramBot;
using SB.TelegramBot.Example.Resources.Messages;

namespace SB.TeleramBot.Example.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class LanguageUzCommand : TelegramBotCallbackCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Execute()
        {
            UserService.SetCurrentUserLanguage("uz-Latn-UZ");
            MessageService.SendMessage(TelegramBotMessages.UserSuccessfulyRegistered);
        }
    }
}
