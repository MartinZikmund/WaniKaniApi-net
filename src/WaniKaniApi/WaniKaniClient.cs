using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaniKaniApi
{
    public class WaniKaniClient : IWaniKaniClient
    {
        private readonly string _apiKey;

        public WaniKaniClient(string apiKey)
        {
            _apiKey = apiKey;
        }
    }
}
