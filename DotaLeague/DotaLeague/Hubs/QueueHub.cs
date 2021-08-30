using ApplicationServices.ApplicationDTOs;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Hubs
{
    public class QueueHub : Hub<IQueueHub>
    {
        //public async Task UserQueued(PlayerShortDTO userShortDTO)
        //{
        //    await Clients.All.SendAsync("UserQueued", userShortDTO);
        //}
    }
}
