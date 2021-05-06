using SB.TelegramBot.Logics.TelegramBotCommands.Factories;

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
        /// <param name="commandFactory"></param>
        public TelegramBotButtonBuilderFactory(ITelegramBotCommandFactory commandFactory)
        {
            _commandFactory = commandFactory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public KeyboardButtonBuilder CreateKeyboardButtonBuilder()
        {
            return new KeyboardButtonBuilder();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonBuilder CreateInlineKeyboardButtonBuilder()
        {
            return new InlineKeyboardButtonBuilder(_commandFactory);
        }
    }
}
