using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices.ApplicationDTOs
{
    public class UserShortDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int WinRate { get; set; }
        public int MMR { get; set; }
    }
}
