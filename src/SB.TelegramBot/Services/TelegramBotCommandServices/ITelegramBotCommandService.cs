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

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        void SetCurrentCommand<TCommand>() where TCommand : ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        void ClearCacheCommands();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        void ClearCurrentCommand();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        void SetBackCommandHandler<TCommand>() where TCommand : ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetBackCommandHandler<T>() where T : class, ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        void ExecuteBackCommandHandler();

        /// <summary>
        /// 
        /// </summary>
        void ClearBackCommandHandler();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void SetBackCommand<T>() where T : ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetBackCommand<T>() where T : class, ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        void ExecuteBackCommand();

        /// <summary>
        /// 
        /// </summary>
        void ClearBackCommand();
    }
}
