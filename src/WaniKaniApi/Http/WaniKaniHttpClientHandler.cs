using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WaniKaniApi.Exceptions;

namespace WaniKaniApi.Http
{
    public class WaniKaniHttpClientHandler : HttpClientHandler
    {
        public WaniKaniHttpClientHandler()
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await base.SendAsync(request, cancellationToken);
                if (!response.IsSuccessStatusCode)
                {
                    var errorType = (int)response.StatusCode;
                    WaniKaniErrorType wkErrorType = WaniKaniErrorType.Unknown;
                    if (Enum.IsDefined(typeof(WaniKaniErrorType), errorType))
                    {
                        wkErrorType = (WaniKaniErrorType)errorType;
                    }

                    var content = await response.Content.ReadAsStringAsync();

                    throw new WaniKaniApiException(wkErrorType, content ?? "No content");
                }
                return response;
            }
            catch (HttpRequestException httpException)
            {
                throw new WaniKaniHttpException(httpException);
            }
        }
    }
}
