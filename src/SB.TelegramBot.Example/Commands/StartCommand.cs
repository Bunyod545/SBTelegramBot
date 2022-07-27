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
            var message = "testtesttest";
            var buttons = CreateInlineKeyboardButtonBuilder();
            buttons.AddRowButton("test1").WithData(new { name = "test11" });
            buttons.AddRowButton("test2").WithData(new { name = "test22"} );

            SendTextMessageAsync(message, replyMarkup: buttons.Build());
        }
    }
}
