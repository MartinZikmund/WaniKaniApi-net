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
        public WaniKaniApiException()
        {
        }

        public WaniKaniApiException(string message) : base(message)
        {
        }

        public WaniKaniApiException(string message, Exception inner) : base(message, inner)
        {
        }

        protected WaniKaniApiException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
