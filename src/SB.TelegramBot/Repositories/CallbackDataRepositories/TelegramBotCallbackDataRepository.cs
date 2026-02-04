using System;
using SB.TelegramBot.Databases;
using SB.TelegramBot.Databases.Tables;

namespace SB.TelegramBot.Repositories.CallbackDataRepositories
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCallbackDataRepository : ITelegramBotCallbackDataRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TelegramBotDbCallbackData FindById(long id)
        {
            return TelegramBotDb.CallbackData.FindById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public long Insert(TelegramBotDbCallbackData data)
        {
            DeleteOldData();
            return TelegramBotDb.CallbackData.Insert(data).AsInt64;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="days"></param>
        public void DeleteOldData(int days = 7)
        {
            var dateLimit = DateTime.Now.AddDays(-days);
            TelegramBotDb.CallbackData.DeleteMany(x => x.CreatedDateTime < dateLimit);
        }
    }
}
