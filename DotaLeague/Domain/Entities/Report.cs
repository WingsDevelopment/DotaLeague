using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotaLeague.Domain.Entities
{
    public class Report
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public string Content { get; private set; }
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
