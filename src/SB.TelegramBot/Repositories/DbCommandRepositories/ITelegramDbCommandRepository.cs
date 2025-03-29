using SB.TelegramBot.Databases.Tables;
using System.Collections.Generic;

namespace SB.TelegramBot.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramDbCommandRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<TelegramBotDbCommand> FindAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        void Insert(TelegramBotDbCommand command);
    }
}
