using SB.TelegramBot.Logics.TelegramBotCommands.Factories.Models;

namespace SB.TelegramBot.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITelegramBotCommandRole
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        void Initialize(TelegramBotCommandInfo info);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        bool IsEqualRole(string role);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetRole();
    }
}