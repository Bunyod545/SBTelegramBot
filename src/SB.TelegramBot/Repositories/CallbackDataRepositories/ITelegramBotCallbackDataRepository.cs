using SB.TelegramBot.Databases.Tables;

namespace SB.TelegramBot.Repositories.CallbackDataRepositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotCallbackDataRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TelegramBotDbCallbackData FindById(long id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        long Insert(TelegramBotDbCallbackData data);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="days"></param>
        void DeleteOldData(int days = 7);
    }
}
