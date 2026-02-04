using LiteDB;
using SB.TelegramBot.Databases.Tables;
using System;
using System.IO;

namespace SB.TelegramBot.Databases
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotDb
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DatabaseFileName = "TelegramBot.db";

        /// <summary>
        /// 
        /// </summary>
        public static string DatabaseFolder = "";

        /// <summary>
        /// 
        /// </summary>
        public static LiteDatabase Database { get; }

        /// <summary>
        /// 
        /// </summary>
        public static ILiteCollection<TelegramBotDbUser> Users { get; }

        /// <summary>
        /// 
        /// </summary>
        public static ILiteCollection<TelegramBotDbPoll> Polls { get; }

        /// <summary>
        /// 
        /// </summary>
        public static ILiteCollection<TelegramBotDbCommand> Commands { get; }

        /// <summary>
        /// 
        /// </summary>
        public static ILiteCollection<TelegramBotDbCallbackData> CallbackData { get; }

        /// <summary>
        /// 
        /// </summary>
        static TelegramBotDb()
        {
            var path = string.Empty;
            if (!string.IsNullOrEmpty(DatabaseFolder))
            {
                Directory.CreateDirectory(DatabaseFolder);
                path = DatabaseFolder;
            }

            var dbFile = Path.Combine(path, DatabaseFileName);
            Database = new LiteDatabase(dbFile);
            Polls = Database.GetCollection<TelegramBotDbPoll>(nameof(Polls));
            Users = Database.GetCollection<TelegramBotDbUser>(nameof(Users));
            Commands = Database.GetCollection<TelegramBotDbCommand>(nameof(Commands));
            CallbackData = Database.GetCollection<TelegramBotDbCallbackData>(nameof(CallbackData));
        }
    }
}
