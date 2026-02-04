using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Repositories.CallbackDataRepositories;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    [BotSingletonService]
    public class TelegramBotButtonBuilderFactory : ITelegramBotButtonBuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ITelegramBotCommandFactory _commandFactory;

        /// <summary>
        /// 
        /// </summary>
        private readonly ITelegramBotCallbackDataRepository _callbackDataRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandFactory"></param>
        /// <param name="callbackDataRepository"></param>
        public TelegramBotButtonBuilderFactory(ITelegramBotCommandFactory commandFactory,
            ITelegramBotCallbackDataRepository callbackDataRepository)
        {
            _commandFactory = commandFactory;
            _callbackDataRepository = callbackDataRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public KeyboardButtonBuilder CreateKeyboardButtonBuilder()
        {
            return new KeyboardButtonBuilder(_commandFactory);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonBuilder CreateInlineKeyboardButtonBuilder()
        {
            return new InlineKeyboardButtonBuilder(_commandFactory, _callbackDataRepository);
        }
    }
}
