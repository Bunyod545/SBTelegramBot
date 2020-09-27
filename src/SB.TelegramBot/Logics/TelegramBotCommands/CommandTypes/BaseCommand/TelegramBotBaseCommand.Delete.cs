using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace SB.TelegramBot
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class TelegramBotBaseCommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task DeleteChatPhotoAsync(ChatId chatId, CancellationToken cancellationToken = default)
        {
            return Client.DeleteChatPhotoAsync(chatId, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task DeleteChatStickerSetAsync(ChatId chatId, CancellationToken cancellationToken = default)
        {
            return Client.DeleteChatStickerSetAsync(chatId, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task DeleteMessageAsync(CancellationToken cancellationToken = default)
        {
            return Client.DeleteMessageAsync(ChatId, MessageId, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task DeleteMessageAsync(ChatId chatId, int messageId, CancellationToken cancellationToken = default)
        {
            return Client.DeleteMessageAsync(chatId, messageId, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sticker"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task DeleteStickerFromSetAsync(string sticker, CancellationToken cancellationToken = default)
        {
            return Client.DeleteStickerFromSetAsync(sticker, cancellationToken);
        }
    }
}
