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
            var message = "Test Callback Data (Small and Large)";
            var buttons = CreateInlineKeyboardButtonBuilder();

            // Small data (should be in callback string)
            buttons.AddRowButton()
                .WithCommand<CallbackTestCommand>()
                .WithText("Small Data")
                .WithData(new { name = "small" });

            // Large data (should exceed 64 bytes and be stored in DB)
            var largeData = new LargeDataModel
            {
                Title = "Large Data Test",
                Description = "This is a test for large callback data storage in LiteDB",
                LongText =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            };

            buttons.AddRowButton()
                .WithCommand<CallbackTestCommand>()
                .WithText("Large Data")
                .WithData(largeData);

            await SendTextMessageAsync(message, replyMarkup: buttons.Build());
        }
    }
}
