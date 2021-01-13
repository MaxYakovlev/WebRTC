using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace WebRTC.Hubs
{
    public class SignalHub : Hub
    {
        public async Task Send(object data)
        {
            await Clients.Others.SendAsync("Send", data);
        }
    }
}
