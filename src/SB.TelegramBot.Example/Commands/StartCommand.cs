using SB.TelegramBot;
using SB.TelegramBot.Example.Services.Users;

namespace SB.TeleramBot.Example.Commands
{
    /// <summary>
    /// 
    /// </summary>
    [TelegramBotCommandName("/start")]
    public class StartCommand : TelegramBotPublicCommand
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IUserService _service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public StartCommand(IUserService service)
        {
            _service = service;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Execute()
        {
            _service.DoSomething();
        }
    }
}
