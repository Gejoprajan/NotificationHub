﻿using Microsoft.AspNetCore.SignalR;

namespace NotificationHub.Hubs
{
        public class NotificationPush : Hub
        {
            public async Task SendNotification(string message)
            {
                await Clients.All.SendAsync("ReceiveNotification", message);
            }
        }

    
}
