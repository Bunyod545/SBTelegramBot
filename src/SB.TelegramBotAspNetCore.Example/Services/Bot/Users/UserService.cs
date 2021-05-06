using SB.TelegramBot.AspNetCore.Example.Services.Abstracts;

namespace SB.TelegramBot.AspNetCore.Example.Services.Users
{
    /// <summary>
    /// 
    /// </summary>
    [BotScopedService]
    public class UserService : BaseService, IUserService
    {
        /// <summary>
        /// 
        /// </summary>
        public void DoSomething()
        {
        }
    }
}
