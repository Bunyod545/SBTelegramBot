using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Services;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

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
        public CallbackQuery CallbackQuery => CallbackQueryService?.CallbackQuery;

        /// <summary>
        /// 
        /// </summary>
        public string CallbackQueryId => CallbackQuery?.Id;

        /// <summary>
        /// 
        /// </summary>
        public User From => CallbackQuery?.From;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="servicesProvider"></param>
        public override void Initialize(ITelegramBotServicesProvider servicesProvider)
        {
            base.Initialize(servicesProvider);
            CallbackQueryService = servicesProvider.GetService<ITelegramBotCallbackQueryService>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        protected T GetData<T>() where T : class, new()
        {
            return CallbackQueryService.GetData<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public Task SendAnswerText(string text, bool showAlert = false, string url = default)
        {
            return Client.AnswerCallbackQuery(CallbackQueryId, text, showAlert, url);
        }
    }
}