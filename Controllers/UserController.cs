using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SocketServerAPI.Hub;
using SocketServerAPI.Models;
using SocketServerAPI.ViewModels;
namespace SignalRDemo.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase {
        private IHubContext <MessageHub, IMessageHubClient> messageHub;
        private ChatDb _context;

        public UserController(IHubContext <MessageHub, IMessageHubClient> _messageHub, ChatDb chatDb) {
            messageHub = _messageHub;
            _context = chatDb;
        }
        [HttpGet]
        [Route("Messages")]
        public async Task<IActionResult> GetChat(List<string> messages) {
            await messageHub.Clients.All.GetChat(messages);
            return Ok(new MessageViewModel{
                Msg = "Message sent to all users"
            });
        }


    }
}