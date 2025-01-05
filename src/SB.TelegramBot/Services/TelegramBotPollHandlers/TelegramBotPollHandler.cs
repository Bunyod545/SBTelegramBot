using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Repositories;
using System;
using Telegram.Bot.Types;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotPollHandler : ITelegramBotPollHandler
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ITelegramBotServicesProvider _serviceProvider;

        /// <summary>
        /// 
        /// </summary>
        private ITelegramBotPollRepository _repository;

        /// <summary>
        /// 
        /// </summary>
        private ITelegramBotCommandFactory _commandFactory;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="commandFactory"></param>
        /// <param name="currentCommand"></param>
        public TelegramBotPollHandler(
            ITelegramBotServicesProvider serviceProvider,
            ITelegramBotPollRepository repository, 
            ITelegramBotCommandFactory commandFactory)
        {
            _serviceProvider = serviceProvider;
            _repository = repository;
            _commandFactory = commandFactory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void Handle(object sender, Update e)
        {
            var pollId = e.Poll?.Id ?? e.PollAnswer?.PollId;
            var poll = _repository.GetPollById(pollId);
            if (poll == null)
                return;

            var commandInfo = _commandFactory.GetPollCommandHandler(poll.PollCommand);
            if (commandInfo == null) 
                return;

            var handlerCommand = _commandFactory.GetCommandInstance(commandInfo);
            var currentCommand = _serviceProvider.GetService<ITelegramBotCurrentCommand>();
            currentCommand?.SetCurrentCommand(handlerCommand);
            ExecuteCommand(handlerCommand);
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void ExecuteCommand(ITelegramBotCommand command)
        {
            try
            {
                TryExecuteCommand(command);
            }
            catch (Exception ex)
            {
                CatchExecuteCommand(command, ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        protected virtual void TryExecuteCommand(ITelegramBotCommand command)
        {
            command?.Initialize(_serviceProvider);
            command?.Execute();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageContext"></param>
        /// <param name="ex"></param>
        protected virtual void CatchExecuteCommand(ITelegramBotCommand command, Exception ex)
        {
            if (command is IPollExceptionHandler exceptionHandler)
                exceptionHandler.HandleExecuteException(ex);

            var handlerService = _serviceProvider.GetService<IPollExceptionHandler>();
            handlerService?.HandleExecuteException(ex);
        }
    }
}
