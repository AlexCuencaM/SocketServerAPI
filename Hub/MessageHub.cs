using Microsoft.AspNetCore.SignalR;
namespace SocketServerAPI.Hub {
    public class MessageHub: Hub<IMessageHubClient> {
        public async Task SendMessage(string messages) {
            await Clients.All.SendMessage(messages);
        }
        public async Task GetChat(List<string> messages) {
            await Clients.All.GetChat(messages);
        }
    }
}