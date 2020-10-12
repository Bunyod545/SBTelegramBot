namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public partial interface ITelegramBotCommandService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetCurrentCommandData<T>();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chatId"></param>
        /// <returns></returns>
        T GetCurrentCommandData<T>(long chatId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        void SetCurrentCommandData(object data);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="chatId"></param>
        void SetCurrentCommandData(object data, long chatId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetCurrentCommandDataString();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        string GetCurrentCommandDataString(long chatId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        void ClearCurrentCommandDataString();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        void ClearCurrentCommandDataString(long chatId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        void SetCurrentCommandDataString(string data);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        void SetCurrentCommandDataString(long chatId, string data);
    }
}
