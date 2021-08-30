using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Utils.Exceptions
{
    public class InvalidSteamIDException : Exception
    {
        public InvalidSteamIDException()
        {
        }

        public InvalidSteamIDException(string message) : base(message)
        {
        }

        public InvalidSteamIDException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidSteamIDException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
