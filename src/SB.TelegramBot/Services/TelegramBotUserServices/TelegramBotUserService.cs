using SB.TelegramBot.Databases;
using SB.TelegramBot.Databases.Tables;
using SB.TelegramBot.Helpers;
using SB.TelegramBot.Repositories.UsersRepositories;

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
        protected readonly ITelegramBotUserRepository UserRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageService"></param>
        public TelegramBotUserService(ITelegramBotMessageService messageService, ITelegramBotUserRepository userRepository)
        {
            MessageService = messageService;
            UserRepository = userRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual TelegramBotUserInfo RegisterUser()
        {
            var user = new TelegramBotUserInfo();
            user.ChatId = MessageService.Message.Chat.Id;
            user.Language = "uz-Latn-UZ";

            return UserRepository.Insert(user);
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
            return UserRepository.GetUserByChatId(chatId);
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
            var user = UserRepository.GetUserByChatId(chatId);
            if (user == null)
                return;

            user.Language = language;
            UserRepository.Update(user);
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
            var user = UserRepository.GetUserByChatId(chatId);
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
            var user = UserRepository.GetUserByChatId(chatId);
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
            var user = UserRepository.GetUserByChatId(chatId);
            if (user == null)
                return;

            user.UserRole = role;
            UserRepository.Update(user);
        }
    }
}
