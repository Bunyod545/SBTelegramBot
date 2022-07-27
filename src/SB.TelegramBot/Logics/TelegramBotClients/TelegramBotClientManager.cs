using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Services;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
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
        public TelegramBotClient Client { get; set; }

        /// <summary>
        /// 
        /// </summary>
        protected ITelegramBotServicesProvider ServicesProvider { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="servicesProvider"></param>
        public TelegramBotClientManager(ITelegramBotServicesProvider servicesProvider)
        {
            ServicesProvider = servicesProvider;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {
            Client = new TelegramBotClient(Token);

            var name = Client.GetMeAsync().Result.Username;
            Console.WriteLine($"Telegram bot name: {name}");

            Client.StartReceiving(updateHandler: TryHandleUpdateAsync, pollingErrorHandler: HandlePollingErrorAsync);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="update"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private async Task TryHandleUpdateAsync(ITelegramBotClient client, Update update, CancellationToken cancellationToken)
        {
            try
            {
                await HandleUpdateAsync(client, update, cancellationToken);
            }
            catch (Exception ex)
            {
                await HandlePollingErrorAsync(client, ex, cancellationToken);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="update"></param>
        /// <param name="cancellationToken"></param>
        /// <exception cref="NotImplementedException"></exception>
        private Task HandleUpdateAsync(ITelegramBotClient client, Update update, CancellationToken cancellationToken)
        {
            return update.Type switch
            {
                UpdateType.Message => Client_OnMessage(update),
                UpdateType.CallbackQuery => Client_OnCallbackQuery(update),
                UpdateType.InlineQuery => Client_OnInlineQuery(update),
                UpdateType.EditedMessage => Client_OnMessageEdited(update)
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="exception"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        private Task HandlePollingErrorAsync(ITelegramBotClient client, Exception exception, CancellationToken cancellationToken)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            Console.WriteLine(ErrorMessage);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        private Task Client_OnMessage(Update update)
        {
            var handler = ServicesProvider.GetService<ITelegramBotMessageHandler>();
            handler.Handle(update);

            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        private Task Client_OnCallbackQuery(Update update)
        {
            var handler = ServicesProvider.GetService<ITelegramBotCallbackQueryHandler>();
            handler.Handle(update.CallbackQuery);

            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        private Task Client_OnInlineQuery(Update update)
        {
            var handler = ServicesProvider.GetService<ITelegramBotInlineQueryHandler>();
            handler.Handle(update);

            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="update"></param>
        /// <returns></returns>
        private Task Client_OnMessageEdited(Update update)
        {
            var handler = ServicesProvider.GetService<ITelegramBotMessageEditedHandler>();
            handler.Handle(update);

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
