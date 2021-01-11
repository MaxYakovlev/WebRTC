using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRTC.Hubs
{
    public class SignalHub : Hub
    {
        public async Task Send(object data)
        {
            await Clients.Others.SendAsync("Send", data);
        }

        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();

            await Clients.Others.SendAsync("Connect", Context.ConnectionId);
        }
    }
}
