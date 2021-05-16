using JS.APIChatRoom.ViewModels;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JS.APIChatRoom.HubConfig
{
    public class ChatHub : Hub
    {
        public async Task BroadcastChatData(List<ChatViewModel> data)
        {
            await Clients.All.SendAsync("broadcastChatData", data);
        }
    }
}
