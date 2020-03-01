using System;
using System.Threading.Tasks;

namespace WaniKaniApi.SampleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var apiKey = Console.ReadLine();
            var client = new WaniKaniClient(apiKey);
            var user = await client.GetSrsStagesAsync();
        }
    }
}
