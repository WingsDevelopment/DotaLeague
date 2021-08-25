using ApplicationServices.ApplicationDTOs;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Hubs
{
    public class QueueHub : Hub
    {
        public async Task UserQueued(UserShortDTO userShortDTO)
        {
            await Clients.All.SendAsync("UserQueued", userShortDTO);
        }
    }
}
