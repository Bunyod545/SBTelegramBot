using SB.TelegramBot.Databases.Tables;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using SB.TelegramBot.Logics.TelegramBotDIContainers;
using SB.TelegramBot.Repositories;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotPollService : ITelegramBotPollService
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
        private ITelegramBotCurrentCommand _currentCommand;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="commandFactory"></param>
        /// <param name="currentCommand"></param>
        public TelegramBotPollService(
            ITelegramBotServicesProvider serviceProvider,
            ITelegramBotPollRepository repository, 
            ITelegramBotCommandFactory commandFactory, 
            ITelegramBotCurrentCommand currentCommand)
        {
            _serviceProvider = serviceProvider;
            _repository = repository;
            _commandFactory = commandFactory;
            _currentCommand = currentCommand;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chatId"></param>
        /// <param name="topicId"></param>
        /// <param name="pollId"></param>
        /// <param name="question"></param>
        /// <param name="pollCommandData"></param>
        public virtual void HandleSend<T>(string chatId, string topicId, string pollId, string question, string pollCommandData) where T : TelegramBotPollCommand
        {
            var info = new TelegramBotDbPoll();
            info.PollId = pollId;
            info.PollCommand = typeof(T).Name;
            info.PollCommandData = pollCommandData;
            info.Question = question;
            info.ChatId = chatId;
            info.TopicId = topicId;

            _repository.SubmitPoll(info);
        }
    }
}
