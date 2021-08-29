using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Domain.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        //image?

        public Report()
        {

        }
        public Report(int userId, string content) : this()
        {
            UserId = userId;
            Content = content;
        }
    }
}
