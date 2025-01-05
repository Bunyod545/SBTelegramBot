using SB.TelegramBot.Databases.Tables;

namespace SB.TelegramBot.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotPollRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pollId"></param>
        /// <returns></returns>
       TelegramBotDbPoll GetPollById(string pollId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poll"></param>
        void SubmitPoll(TelegramBotDbPoll poll);
    }
}
