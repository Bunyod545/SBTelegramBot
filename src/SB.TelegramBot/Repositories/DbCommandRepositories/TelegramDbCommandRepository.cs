using SB.TelegramBot.Databases;
using SB.TelegramBot.Databases.Tables;
using System.Collections.Generic;
using System.Linq;

namespace SB.TelegramBot.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramDbCommandRepository : ITelegramDbCommandRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public void Insert(TelegramBotDbCommand command)
        {
            TelegramBotDb.Commands.Upsert(command);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<TelegramBotDbCommand> FindAll()
        {
            return TelegramBotDb.Commands.FindAll().ToList();
        }
    }
}
