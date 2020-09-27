namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICommandMessageHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        void Handle(MessageContext context);
    }
}
