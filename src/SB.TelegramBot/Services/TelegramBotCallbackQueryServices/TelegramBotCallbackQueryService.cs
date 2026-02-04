using Newtonsoft.Json;
using SB.TelegramBot.Databases;
using SB.TelegramBot.Databases.Tables;
using SB.TelegramBot.Repositories.CallbackDataRepositories;
using SB.TelegramBot.Logics.TelegramBotCallbackQueries;
using System;
using Telegram.Bot.Types;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotCallbackQueryService : ITelegramBotCallbackQueryService
    {
        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotCallbackDataRepository Repository { get; }

        /// <summary>
        /// 
        /// </summary>
        public CallbackQuery CallbackQuery => TelegramBotCallbackQueryManager.CallbackQuery.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public TelegramBotCallbackQueryService(ITelegramBotCallbackDataRepository repository)
        {
            Repository = repository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public virtual T GetData<T>() where T : class, new()
        {
            var data = CallbackQuery?.Data;
            if (string.IsNullOrEmpty(data))
                return default;

            if (string.IsNullOrEmpty(data))
                return default;

            if (data.StartsWith("ID:"))
                return GetDataFromDb<T>(data);

            return TelegramBotCallbackDataConverter.Deserialize<T>(data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        protected virtual T GetDataFromDb<T>(string data) where T : class, new()
        {
            var idString = data.Substring(3);
            if (idString.EndsWith(";"))
                idString = idString.Substring(0, idString.Length - 1);

            if (!long.TryParse(idString, out var id))
                return default;

            var dbData = Repository.FindById(id);
            if (dbData == null)
                return default;

            return JsonConvert.DeserializeObject<T>(dbData.Data);
        }
    }
}