namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotCommandService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        long GetCommandId();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        TelegramBotCommandType GetCommandType();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ITelegramBotCommandName GetCommandName();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Execute<T>() where T : ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        T CreateCommand<T>() where T : ITelegramBotCommand;
    }
}
