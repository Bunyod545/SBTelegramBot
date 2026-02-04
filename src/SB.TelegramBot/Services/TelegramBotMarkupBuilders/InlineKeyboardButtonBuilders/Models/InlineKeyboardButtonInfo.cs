using Newtonsoft.Json;
using SB.TelegramBot.Databases;
using SB.TelegramBot.Databases.Tables;
using SB.TelegramBot.Repositories.CallbackDataRepositories;
using SB.TelegramBot.Logics.TelegramBotCommands.Factories;
using System;
using Telegram.Bot.Types.ReplyMarkups;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public class InlineKeyboardButtonInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public InlineKeyboardButton Button { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotCommandFactory CommandFactory { get; }

        /// <summary>
        /// 
        /// </summary>
        public ITelegramBotCallbackDataRepository Repository { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="button"></param>
        /// <param name="commandFactory"></param>
        /// <param name="repository"></param>
        public InlineKeyboardButtonInfo(InlineKeyboardButton button, ITelegramBotCommandFactory commandFactory,
            ITelegramBotCallbackDataRepository repository)
        {
            Button = button;
            CommandFactory = commandFactory;
            Repository = repository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonInfo WithText(string text)
        {
            Button.Text = text;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonInfo WithCommand<T>() where T : ITelegramBotCommand
        {
            var commandInfo = CommandFactory.GetCommandInfo(typeof(T));
            if (commandInfo == null)
                return this;

            Button.CallbackData = $"{commandInfo.CommandId};" + Button.CallbackData;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public InlineKeyboardButtonInfo WithData(object data)
        {
            var dataString = TelegramBotCallbackDataConverter.Serialize(data);
            if (CanAddData(dataString))
            {
                Button.CallbackData += dataString;
                return this;
            }

            return WithDataToDb(data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public InlineKeyboardButtonInfo WithDbData(object data)
        {
            return WithDataToDb(data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataString"></param>
        /// <returns></returns>
        protected virtual bool CanAddData(string dataString)
        {
            var totalLength = (Button.CallbackData?.Length ?? 0) + (dataString?.Length ?? 0);
            return totalLength <= 64;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        protected virtual InlineKeyboardButtonInfo WithDataToDb(object data)
        {
            var dbData = new TelegramBotDbCallbackData();
            dbData.Data = JsonConvert.SerializeObject(data);
            var id = Repository.Insert(dbData);

            Button.CallbackData += $"ID:{id};";
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public InlineKeyboardButtonInfo WithUrl(string url)
        {
            Button.Url = url;
            return this;
        }
    }
}