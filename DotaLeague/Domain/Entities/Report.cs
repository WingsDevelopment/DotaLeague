using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Domain.Entities
{
    public class Report
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        //image?

        public Report()
        {
            Id = Guid.NewGuid().ToString();
        }
        public Report(string userId, string content) : this()
        {
            UserId = userId;
            Content = content;
        }
    }
}
