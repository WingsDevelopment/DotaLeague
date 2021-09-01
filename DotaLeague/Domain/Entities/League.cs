using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class League
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public bool IsDeleted { get; private set; }

        public League(string name, DateTime startDateTime, DateTime endDateTime)
        {
            Name = name;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }

        public void SetIsDeleted(bool isDeleted)
        {
            IsDeleted = isDeleted;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetStartDateTime(DateTime startDateTime)
        {
            StartDateTime = startDateTime;
        }

        public void SetEndDateTime(DateTime endDateTime)
        {
            EndDateTime = endDateTime;
        }
    }
}
