using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WaniKaniApi.Exceptions
{
    [Serializable]
    public class WaniKaniApiException : Exception
    {
        public WaniKaniApiException(WaniKaniErrorType errorType)
        {
            ErrorType = errorType;
        }

        public WaniKaniApiException(WaniKaniErrorType errorType, string message) : base(message)
        {
            ErrorType = errorType;
        }

        public WaniKaniApiException(WaniKaniErrorType errorType, string message, Exception inner) : base(message, inner)
        {
            ErrorType = errorType;
        }

        protected WaniKaniApiException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

        public WaniKaniErrorType ErrorType { get; }
    }
}
