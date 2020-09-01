using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Services;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    [TelegramBotCommand(TelegramBotCommandType.InlineCommand)]
    public abstract class TelegramBotInlineCommand : TelegramBotBaseCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotCallbackQueryService CallbackQueryService { get; }

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotInlineCommand()
        {
            CallbackQueryService = TelegramBotServicesContainer.GetService<ITelegramBotCallbackQueryService>();
        }
    }
}
