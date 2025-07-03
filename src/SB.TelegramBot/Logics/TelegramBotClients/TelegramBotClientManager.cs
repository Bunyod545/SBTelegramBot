using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Services;
using System;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace SB.TelegramBot.Logics.TelegramBotClients
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotClientManager : ITelegramBotClientManager
    {
        /// <summary>
        /// 
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public HttpClient HttpClient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TelegramBotClient Client { get; set; }

        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotServicesProvider ServicesProvider { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotErrorHandler ErrorHandler { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="servicesProvider"></param>
        public TelegramBotClientManager(ITelegramBotServicesProvider servicesProvider, ITelegramBotErrorHandler errorHandler)
        {
            ServicesProvider = servicesProvider;
            ErrorHandler = errorHandler;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {
            Client = new TelegramBotClient(Token, HttpClient);

            var name = Client.GetMe().Result.Username;
            Console.WriteLine($"Telegram bot name: {name}");

            var cts = new CancellationTokenSource();
            var receiverOptions = new ReceiverOptions()
            {
                AllowedUpdates = Array.Empty<UpdateType>()
            };

            Client.StartReceiving(
                updateHandler: HandleUpdateAsync,
                errorHandler: HandlePollingErrorAsync,
                receiverOptions: receiverOptions,
                cancellationToken: cts.Token
            );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="update"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        private Task HandleUpdateAsync(ITelegramBotClient client, Update update, CancellationToken token)
        {
            try
            {
                return TryHandleUpdateAsync(client, update, token); 
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="update"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        private Task TryHandleUpdateAsync(ITelegramBotClient client, Update update, CancellationToken token)
        {
            ServicesProvider.RequestBegin();
            var result = HandleWithRequestScope(client, update, token);
            ServicesProvider.RequestEnd();

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="update"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        private Task HandleWithRequestScope(ITelegramBotClient client, Update update, CancellationToken token)
        {
            var currentUpdate = ServicesProvider.GetService<ITelegramBotCurrentUpdate>();
            currentUpdate.SetCurrentUpdate(update);

            if (update.Type == UpdateType.Message)
            {
                var messageHandler = ServicesProvider.GetService<ITelegramBotMessageHandler>();
                messageHandler.Handle(client, update);
                return Task.CompletedTask;
            }

            if (update.Type == UpdateType.CallbackQuery)
            {
                var callbackQueryHandler = ServicesProvider.GetService<ITelegramBotCallbackQueryHandler>();
                callbackQueryHandler.Handle(client, update);
                return Task.CompletedTask;
            }

            if (update.Type == UpdateType.InlineQuery)
            {
                var inlineQueryHandler = ServicesProvider.GetService<ITelegramBotInlineQueryHandler>();
                inlineQueryHandler.Handle(client, update);
                return Task.CompletedTask;
            }

            if (update.Type == UpdateType.EditedMessage)
            {
                var messageEditedHandler = ServicesProvider.GetService<ITelegramBotMessageEditedHandler>();
                messageEditedHandler.Handle(client, update);
                return Task.CompletedTask;
            }

            if (update.Type == UpdateType.Poll)
            {
                var pollHandler = ServicesProvider.GetService<ITelegramBotPollHandler>();
                pollHandler.Handle(client, update);
                return Task.CompletedTask;
            }

            if (update.Type == UpdateType.PollAnswer)
            {
                var pollHandler = ServicesProvider.GetService<ITelegramBotPollHandler>();
                pollHandler.Handle(client, update);
                return Task.CompletedTask;
            }

            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="exception"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        private Task HandlePollingErrorAsync(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            if (exception != null)
                ErrorHandler.Handle(exception);

            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Client = null;
        }
    }
}
