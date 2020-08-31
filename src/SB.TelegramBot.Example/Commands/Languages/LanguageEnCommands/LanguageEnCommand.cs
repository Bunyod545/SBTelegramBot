using SB.TelegramBot;
using SB.TelegramBot.Example.Resources.Messages;
using SB.TeleramBot.Example.Commands.Languages.LanguageEnCommands.Models;

namespace SB.TeleramBot.Example.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class LanguageEnCommand : TelegramBotCallbackCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Execute()
        {
            var data = CallbackQueryService.GetData<LanguageEnInfo>();

            UserService.SetCurrentUserLanguage("en");
            CallbackQueryService.SendText(TelegramBotMessages.UserSuccessfulyRegistered);
        }
    }
}
