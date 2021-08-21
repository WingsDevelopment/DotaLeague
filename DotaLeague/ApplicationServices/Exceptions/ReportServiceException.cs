using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ApplicationServices.Exceptions
{
    public class ReportServiceException : Exception
    {
        public ReportServiceException()
        {
        }

        public ReportServiceException(string message) : base(message)
        {
        }

        public ReportServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReportServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
