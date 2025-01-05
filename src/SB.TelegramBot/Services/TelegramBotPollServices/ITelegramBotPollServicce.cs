namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotPollService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chatId"></param>
        /// <param name="topicId"></param>
        /// <param name="pollId"></param>
        /// <param name="question"></param>
        /// <param name="pollCommandData"></param>
        void HandleSend<T>(string chatId, string topicId, string pollId, string question, string pollCommandData) where T: TelegramBotPollCommand;
    }
}
