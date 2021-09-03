using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Models.FilterViewModels
{
    public class PlayerFiltersVM
    {
        public int? ById { get; set; }
        public string ByDisplayName { get; set; }
        public string ByEmail { get; set; }
        public string BySteamID { get; set; }
        public DateTime? RegistratedFrom { get; set; }
        public DateTime? RegistratedTo { get; set; }
        public int? MMRFrom { get; set; }
        public int? MMRTo { get; set; }
        public PlayerSortByVM SortBy { get; set; }

        public PlayerFiltersVM()
        {

        }
    }
}
