using SB.TelegramBot.Databases;
using SB.TelegramBot.Databases.Tables;
using SB.TelegramBot.Helpers;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class TelegramBotUserService : ITelegramBotUserService
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ITelegramBotMessageService MessageService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageService"></param>
        public TelegramBotUserService(ITelegramBotMessageService messageService)
        {
            MessageService = messageService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual TelegramBotUserInfo RegisterUser()
        {
            var user = new TelegramBotDbUser();
            user.ChatId = MessageService.Message.Chat.Id;
            user.Language = "uz-Latn-UZ";

            TelegramBotDb.Users.Insert(user);
            return new TelegramBotUserInfo(user.ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual TelegramBotUserInfo GetCurrentUserInfo()
        {
            return GetUserInfo(MessageService.Message.Chat.Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public virtual TelegramBotUserInfo GetUserInfo(long chatId)
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            if (user == null)
                return null;

            var userInfo = new TelegramBotUserInfo();
            userInfo.ChatId = chatId;
            userInfo.Language = user.Language;
            userInfo.CurrentCommandClrName = user.CurrentCommand;
            userInfo.BackCommandClrName = user.BackCommand;
            userInfo.BackCommandHandlerClrName = user.BackCommandHandler;
            userInfo.PriorityCommands = user.PriorityCommands;

            return userInfo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="language"></param>
        public virtual void SetCurrentUserLanguage(string language)
        {
            SetUserLanguage(MessageService.ChatId, language);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="language"></param>
        public virtual void SetUserLanguage(long chatId, string language)
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            if (user == null)
                return;

            user.Language = language;
            TelegramBotDb.Users.Update(user);
            TelegramBotLanguageHelper.InitializeCulture(user.Language);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string GetCurrentUserRole()
        {
            return GetUserRole(MessageService.ChatId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        public virtual string GetUserRole(long chatId)
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            return user?.UserRole;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public virtual bool IsInRole(string role)
        {
            return IsInRole(MessageService.ChatId, role);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public virtual bool IsInRole(long chatId, string role)
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            return user?.UserRole == role;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        public virtual void SetCurrentUserRole(string role)
        {
            SetUserRole(MessageService.ChatId, role);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="role"></param>
        public virtual void SetUserRole(long chatId, string role)
        {
            var user = TelegramBotDb.Users.FindOne(f => f.ChatId == chatId);
            if (user == null)
                return;

            user.UserRole = role;
            TelegramBotDb.Users.Update(user);
        }
    }
}
