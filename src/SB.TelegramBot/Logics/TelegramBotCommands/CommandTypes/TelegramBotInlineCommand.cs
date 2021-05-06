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
        public ITelegramBotCallbackQueryService CallbackQueryService { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="servicesProvider"></param>
        public override void Initialize(ITelegramBotServicesProvider servicesProvider)
        {
            base.Initialize(servicesProvider);
            CallbackQueryService = servicesProvider.GetService<ITelegramBotCallbackQueryService>();
        }
    }
}
