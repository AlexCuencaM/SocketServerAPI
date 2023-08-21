using Microsoft.EntityFrameworkCore;
namespace SocketServerAPI.Models;
public class ChatDb: DbContext{
    public ChatDb(DbContextOptions options): base(options){
    }
    public DbSet<Chat> Chats {get; set;} = null;
}