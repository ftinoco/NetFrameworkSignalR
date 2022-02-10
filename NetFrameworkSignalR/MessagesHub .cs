using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace NetFrameworkSignalR
{
    [HubName("messagesHub")]   
    public class MessagesHub : Hub
    {
        public static void SendMessages()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<MessagesHub>();
        }

        [HubMethodName("send")]
        public void Send(string name)
        {
            string salt = "MyName";
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<MessagesHub>();
            context.Clients.All.updateMessages(salt.Equals(name));
        }
    }
}