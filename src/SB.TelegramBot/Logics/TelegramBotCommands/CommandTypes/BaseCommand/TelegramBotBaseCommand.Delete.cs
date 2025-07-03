using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Requests;
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
            return Client.DeleteChatPhoto(chatId, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chatId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task DeleteChatStickerSetAsync(ChatId chatId, CancellationToken cancellationToken = default)
        {
            return Client.DeleteChatStickerSet(chatId, cancellationToken);
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
            return Client.DeleteMessage(ChatId, MessageId, cancellationToken);
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
            return Client.DeleteMessage(ChatId, messageId, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sticker"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task DeleteStickerFromSetAsync(InputFileId sticker, CancellationToken cancellationToken = default)
        {
            return Client.DeleteStickerFromSet(sticker, cancellationToken);
        }
    }
}