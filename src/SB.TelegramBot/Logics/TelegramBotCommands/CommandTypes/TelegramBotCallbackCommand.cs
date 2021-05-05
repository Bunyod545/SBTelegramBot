using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Services;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    [TelegramBotCommand(TelegramBotCommandType.CallbackCommand)]
    public abstract class TelegramBotCallbackCommand : TelegramBotBaseCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotCallbackQueryService CallbackQueryService { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="container"></param>
        public override void Initialize(ITelegramBotServicesContainer container)
        {
            base.Initialize(container);
            CallbackQueryService = container.GetService<ITelegramBotCallbackQueryService>();
        }
    }
}
