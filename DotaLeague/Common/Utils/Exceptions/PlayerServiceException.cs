using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Utils.Exceptions
{
    public class PlayerServiceException : Exception
    {
        public PlayerServiceException()
        {
        }

        public PlayerServiceException(string message) : base(message)
        {
        }

        public PlayerServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PlayerServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
