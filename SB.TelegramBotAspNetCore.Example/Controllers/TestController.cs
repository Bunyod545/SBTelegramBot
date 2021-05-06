using Microsoft.AspNetCore.Mvc;
using SB.TelegramBot.Logics.TelegramBotClients;
using System.Threading.Tasks;

namespace SB.TelegramBotAspNetCore.Example.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TestController
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ITelegramBotClientManager _clientManager;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientManager"></param>
        public TestController(ITelegramBotClientManager clientManager)
        {
            _clientManager = clientManager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public  async Task<string> GetName()
        {
            var me = await _clientManager.Client.GetMeAsync();
            return me.Username;
        }
    }
}
