using Newtonsoft.Json;
using SB.TelegramBot.Databases;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TelegramBotCommandService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetCurrentCommandData<T>()
        {
            return GetCurrentCommandData<T>(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public T GetCurrentCommandData<T>(long chatId)
        {
            var jsonString = GetCurrentCommandDataString(chatId);
            if (string.IsNullOrEmpty(jsonString))
                return default(T);

            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void SetCurrentCommandData(object data)
        {
            SetCurrentCommandData(data, ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="chatId"></param>
        public void SetCurrentCommandData(object data, long chatId)
        {
            if (data == null)
            {
                ClearCurrentCommandDataString(chatId);
                return;
            }

            var jsonString = JsonConvert.SerializeObject(data);
            SetCurrentCommandDataString(chatId, jsonString);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public string GetCurrentCommandDataString()
        {
            return GetCurrentCommandDataString(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public string GetCurrentCommandDataString(long chatId)
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            if (user == null)
                return null;

            return user.CurrentCommandData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public void ClearCurrentCommandDataString()
        {
            ClearCurrentCommandDataString(ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public void ClearCurrentCommandDataString(long chatId)
        {
            SetCurrentCommandDataString(chatId, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public void SetCurrentCommandDataString(string data)
        {
            SetCurrentCommandDataString(data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public void SetCurrentCommandDataString(long chatId, string data)
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            if (user == null)
                return;

            user.CurrentCommandData = data;
            TelegramBotDb.Users.Update(user);
        }
    }
}
