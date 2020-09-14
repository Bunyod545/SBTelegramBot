namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotUserService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chat"></param>
        TelegramBotUserInfo RegisterUser();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        TelegramBotUserInfo GetUserInfo(long chatId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        TelegramBotUserInfo GetCurrentUserInfo();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="language"></param>
        void SetCurrentUserLanguage(string language);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="language"></param>
        void SetUserLanguage(long chatId, string language);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetCurrentUserRole();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        string GetUserRole(long chatId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        bool IsInRole(string role);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        bool IsInRole(long chatId, string role);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        void SetCurrentUserRole(string role);
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="role"></param>
        void SetUserRole(long chatId ,string role);
    }
}
