using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Utils.Exceptions
{
    public class NotVouchedException : Exception
    {
        public NotVouchedException()
        {
        }

        public NotVouchedException(string message) : base(message)
        {
        }

        public NotVouchedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotVouchedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
