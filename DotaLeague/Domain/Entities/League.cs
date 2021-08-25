using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public League()
        {

        }
    }
}
