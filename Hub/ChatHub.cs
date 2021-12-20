namespace chatroom.Hub
{
    using Microsoft.AspNetCore.SignalR;
    using System.Threading.Tasks;

    public class ChatHub : Hub
    {
        public Task BroadcastMessage(string name, string message)
        {
            System.Diagnostics.Debug.WriteLine("Send - First letter of the message [" + message[0] +"]");
            return Clients.All.SendAsync("broadcastMessage", name, message);
        }
            

        public Task Echo(string name, string message)
        {
            System.Diagnostics.Debug.WriteLine("Echo - First letter of the message [" + message[0] + "]");
            return Clients.Client(Context.ConnectionId)
                .SendAsync("echo", name, $"{message} (echo from server)");
        } 
    }
}
