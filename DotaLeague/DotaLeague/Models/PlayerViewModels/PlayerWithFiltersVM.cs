using ApplicationServices.ApplicationDTOs;
using DotaLeague.Models.FilterViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Models.PlayerViewModels
{
    public class PlayerWithFiltersVM
    {
        public ICollection<PlayerDTO> Players { get; set; }
        public PlayerFiltersVM Filters { get; set; }

        public PlayerWithFiltersVM()
        {
            Players = new List<PlayerDTO>();
        }

        public PlayerWithFiltersVM(ICollection<PlayerDTO> players, PlayerFiltersVM filters) : this()
        {
            Players = players;
            Filters = filters;
        }
    }
}
