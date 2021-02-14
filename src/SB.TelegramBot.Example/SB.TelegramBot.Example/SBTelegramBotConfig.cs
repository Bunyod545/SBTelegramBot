using SB.TelegramBot.Logics.TelegramBotDIContainers;

namespace SB.TelegramBot.Example
{
    /// <summary>
    /// 
    /// </summary>
    public class SBTelegramBotConfig : TelegramBotAppConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        public SBTelegramBotConfig(string token) : base(token) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public override void RegisterServices(ITelegramBotServicesCollection services)
        {
            // Register your services there. For example:
            // services.AddScoped<ITestService, TestService>();
        }
    }
}
