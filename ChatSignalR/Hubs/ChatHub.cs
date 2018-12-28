using ChatSignalR.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string userName, string messageBody)
        {
            var message = new Message
            {
                UserName = userName,
                MessageBody = messageBody,
                Time = DateTime.UtcNow,
                Id = Guid.NewGuid()
            };
            await Clients.All.SendAsync("MessageChannel", message);
        }
    }
}
