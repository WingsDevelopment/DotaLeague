using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Models.PlayerViewModels
{
    public class PlayerEditVM
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public int VouchedLeague { get; set; }
        public string SteamID { get; set; }
        public DateTime TimeOutDateTime { get; set; }
        public int Pos1PriorityValue { get; set; }
        public int Pos2PriorityValue { get; set; }
        public int Pos3PriorityValue { get; set; }
        public int Pos4PriorityValue { get; set; }
        public int Pos5PriorityValue { get; set; }

        public PlayerEditVM()
        {

        }
    }
}
