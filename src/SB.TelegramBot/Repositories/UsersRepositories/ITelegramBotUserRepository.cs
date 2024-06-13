using SB.TelegramBot.Services;

namespace SB.TelegramBot.Repositories.UsersRepositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotUserRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        TelegramBotUserInfo GetUserByChatId(long chatId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbId"></param>
        /// <returns></returns>
        TelegramBotUserInfo GetUserByDbId(long dbId);
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        TelegramBotUserInfo Update(TelegramBotUserInfo user);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        TelegramBotUserInfo Insert(TelegramBotUserInfo user);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        TelegramBotUserInfo Submit(TelegramBotUserInfo user);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        void Delete(TelegramBotUserInfo user);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        void DeleteByChatId(long chatId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbId"></param>
        /// <returns></returns>
        void DeleteByDbId(long dbId);
    }
}
