using ApplicationServices.ApplicationDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Hubs
{
    [Authorize]
    public class QueueHub : Hub<IQueueHub>
    {
        //public async Task UserQueued(PlayerShortDTO userShortDTO)
        //{
        //    await Clients.All.SendAsync("UserQueued", userShortDTO);
        //}
    }
}
