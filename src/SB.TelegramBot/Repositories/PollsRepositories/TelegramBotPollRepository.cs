using SB.TelegramBot.Databases;
using SB.TelegramBot.Databases.Tables;

namespace SB.TelegramBot.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotPollRepository : ITelegramBotPollRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="poll"></param>
        public void SubmitPoll(TelegramBotDbPoll poll)
        {
            TelegramBotDb.Polls.Upsert(poll);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pollId"></param>
        /// <returns></returns>
        public TelegramBotDbPoll GetPollById(string pollId)
        {
            return TelegramBotDb.Polls.FindOne(f => f.PollId == pollId);
        }
    }
}
