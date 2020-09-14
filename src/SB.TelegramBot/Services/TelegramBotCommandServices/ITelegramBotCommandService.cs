using Telegram.Bot.Types;

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
        /// <typeparam name="TCommand"></typeparam>
        /// <param name="chatId"></param>
        void SetCurrentCommand<TCommand>(long chatId) where TCommand : ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        void ClearCacheCommands();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        void ClearCacheCommands(long chatId);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        void ClearCurrentCommand();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        void ClearCurrentCommand(long chatId);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        void SetBackCommandHandler<TCommand>() where TCommand : ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        /// <param name="chatId"></param>
        void SetBackCommandHandler<TCommand>(long chatId) where TCommand : ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetBackCommandHandler<T>() where T : class, ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chatId"></param>
        /// <returns></returns>
        T GetBackCommandHandler<T>(long chatId) where T : class, ITelegramBotCommand;

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
        /// <param name="chatId"></param>
        void ClearBackCommandHandler(long chatId);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void SetBackCommand<T>() where T : ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chatId"></param>
        void SetBackCommand<T>(long chatId) where T : ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetBackCommand<T>() where T : class, ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chatId"></param>
        /// <returns></returns>
        T GetBackCommand<T>(long chatId) where T : class, ITelegramBotCommand;

        /// <summary>
        /// 
        /// </summary>
        void ExecuteBackCommand();

        /// <summary>
        /// 
        /// </summary>
        void ClearBackCommand();
    
        /// <summary>
        /// 
        /// </summary>
        void ClearBackCommand(long chatId);
    }
}
