using SB.TelegramBot;
using SB.TelegramBot.Example.Commands;
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
        public async override void Execute()
        {
            var message = "test";
            var buttons = CreateInlineKeyboardButtonBuilder();
            buttons.AddRowButton().WithCommand<CallbackTestCommand>().WithText("test1").WithData(new { name = "test" });
            buttons.AddRowButton().WithCommand<CallbackTestCommand>().WithText("test2").WithData(new { name = "test"} );

            await SendTextMessageAsync(message, replyMarkup: buttons.Build());
            await SendPoolMesssage<PollTestCommand>(ChatId, "Test question", new string[] { "Yes", "No"}, isAnonymous: false);
        }
    }
}
