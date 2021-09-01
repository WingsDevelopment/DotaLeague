using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Utils.Exceptions
{
    public class LeagueServiceException : Exception
    {
        public LeagueServiceException()
        {
        }

        public LeagueServiceException(string message) : base(message)
        {
        }

        public LeagueServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LeagueServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
