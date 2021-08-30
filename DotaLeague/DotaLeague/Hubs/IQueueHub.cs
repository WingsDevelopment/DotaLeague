using ApplicationServices.ApplicationDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Hubs
{
    public interface IQueueHub
    {
        Task UserQueued(PlayerShortDTO userShortDTO);
    }
}
