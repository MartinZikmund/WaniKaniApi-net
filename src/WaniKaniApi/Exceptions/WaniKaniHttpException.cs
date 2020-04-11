using System;
using System.Net.Http;

namespace WaniKaniApi.Exceptions
{
    [Serializable]
    public class WaniKaniHttpException : WaniKaniApiException
    {
        public WaniKaniHttpException(HttpRequestException innerException)
            : base(WaniKaniErrorType.HttpRequest, "HTTP request failed", innerException)
        {
        }
    }
}
