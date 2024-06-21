using SB.TelegramBot.Databases;
using SB.TelegramBot.Databases.Tables;
using SB.TelegramBot.Services;

namespace SB.TelegramBot.Repositories.UsersRepositories
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotUserRepository : ITelegramBotUserRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public TelegramBotUserInfo GetUserByChatId(long chatId)
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            if (user == null)
                return null;

            return MapToInfo(user, new TelegramBotUserInfo());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbId"></param>
        /// <returns></returns>
        public TelegramBotUserInfo GetUserByDbId(long dbId)
        {
            var user = TelegramBotDb.Users.FindOne(f => f.Id == dbId);
            if (user == null)
                return null;

            return MapToInfo(user, new TelegramBotUserInfo());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private TelegramBotUserInfo MapToInfo(TelegramBotDbUser user, TelegramBotUserInfo userInfo)
        {
            userInfo.DbId = user.Id;
            userInfo.ChatId = user.ChatId;
            userInfo.Language = user.Language;
            userInfo.CurrentCommandData = user.CurrentCommandData;
            userInfo.CurrentCommandClrName = user.CurrentCommand;
            userInfo.BackCommandClrName = user.BackCommand;
            userInfo.BackCommandHandlerClrName = user.BackCommandHandler;
            userInfo.PriorityCommands = user.PriorityCommands;
            userInfo.BackCommand = user.BackCommand;
            userInfo.BackCommandHandler = user.BackCommandHandler;
            userInfo.UserRole = user.UserRole;

            return userInfo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public TelegramBotUserInfo Update(TelegramBotUserInfo user)
        {
            var dbUser = TelegramBotDb.Users.FindOne(f => f.Id == user.DbId);
            if (dbUser == null)
                return null;

            MapToEntity(dbUser, user);
            TelegramBotDb.Users.Update(dbUser);
            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public TelegramBotUserInfo Insert(TelegramBotUserInfo user)
        {
            var dbUser = new TelegramBotDbUser();

            MapToEntity(dbUser, user);
            TelegramBotDb.Users.Insert(dbUser);

            return MapToInfo(dbUser, user);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public TelegramBotUserInfo Submit(TelegramBotUserInfo user)
        {
            var dbUser = TelegramBotDb.Users.FindOne(f => f.Id == user.DbId);
            if (dbUser == null)
                return Insert(user);

            return Update(user);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        private void MapToEntity(TelegramBotDbUser user, TelegramBotUserInfo userInfo)
        {
            user.Id = userInfo.DbId;
            user.ChatId = userInfo.ChatId;
            user.Language = userInfo.Language;
            user.CurrentCommand = userInfo.CurrentCommandClrName;
            user.BackCommand = userInfo.BackCommandClrName;
            user.BackCommandHandler = userInfo.BackCommandHandlerClrName;
            user.PriorityCommands = userInfo.PriorityCommands;
            user.BackCommand = userInfo.BackCommand;
            user.BackCommandHandler = userInfo.BackCommandHandler;
            user.UserRole = userInfo.UserRole;
            user.CurrentCommandData = userInfo.CurrentCommandData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public void Delete(TelegramBotUserInfo user)
        {
            if (user == null)
                return;

            var dbUser = TelegramBotDb.Users.FindOne(f => f.Id == user.DbId);
            if (dbUser != null)
                TelegramBotDb.Users.Delete(dbUser.Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public void DeleteByChatId(long chatId)
        {
            var userInfo = GetUserByChatId(chatId);
            Delete(userInfo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbId"></param>
        /// <returns></returns>
        public void DeleteByDbId(long dbId)
        {
            var userInfo = GetUserByDbId(dbId);
            Delete(userInfo);
        }
    }
}
