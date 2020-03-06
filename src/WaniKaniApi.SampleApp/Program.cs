using System;
using System.Threading.Tasks;
using WaniKaniApi.Models;

namespace WaniKaniApi.SampleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var apiKey = Console.ReadLine();
            var client = new WaniKaniClient(apiKey);
        }
    }
}
