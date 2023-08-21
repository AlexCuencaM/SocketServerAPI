namespace SocketServerAPI.Hub {
    public interface IMessageHubClient {
        Task SendMessage(string message);
        Task GetChat(List<string> message);
    }
}