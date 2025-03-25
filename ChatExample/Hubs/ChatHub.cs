using ChatExample.Models;
using ChatExample.Services;
using Microsoft.AspNetCore.SignalR;

namespace ChatExample.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, string guid)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, guid);
        }
    }
}
