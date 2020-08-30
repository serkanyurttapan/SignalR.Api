using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalR.Api.Hubs
{
    public class ConnectionHub : Hub
    {
        public async Task SendName(string name)
        {
            await Clients.All.SendAsync("ReceiveName", name);
        }
    }
}
