using System.Collections.Generic;
using Telegram.Bot.Types;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotMessageHandlerManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="THandler"></typeparam>
        void AddHandler<THandler>() where THandler : ICommandMessageHandler;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="THandler"></typeparam>
        /// <typeparam name="TBeforeHandler"></typeparam>
        void AddBeforeHandler<THandler, TBeforeHandler>()
            where THandler : ICommandMessageHandler
            where TBeforeHandler : ICommandMessageHandler;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="THandler"></typeparam>
        /// <typeparam name="TAfterHandler"></typeparam>
        void AddAfterHandler<THandler, TAfterHandler>()
            where THandler : ICommandMessageHandler
            where TAfterHandler : ICommandMessageHandler;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="THandler"></typeparam>
        void RemoveHandler<THandler>() where THandler : ICommandMessageHandler;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void Handle(Message message);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<ICommandMessageHandler> GetMessageHandlers();
    }
}
