using SB.TelegramBot.Dotnet.Example.Services.Users;

namespace SB.TelegramBot.Dotnet.Example.Commands;

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
        var message = "test";
        var buttons = CreateInlineKeyboardButtonBuilder();
        buttons.AddRowButton().WithCommand<CallbackTestCommand>().WithText("test1").WithData(new { name = "test" });
        buttons.AddRowButton().WithCommand<CallbackTestCommand>().WithText("test2").WithData(new { name = "test"} );

        SendTextMessageAsync(message, replyMarkup: buttons.Build());
    }
}