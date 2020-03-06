﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;

namespace WaniKaniApi.Api
{
    public class ResetsApi : ApiBase, IResetsApi
    {
        public ResetsApi(HttpClient client) : base(client)
        {
        }

        public async Task<Reset> GetAsync(int id) =>
            await GetObjectResponseAsync<Reset>($"resets/{id}");

        public async Task<Reset[]> GetAllAsync() =>
            await GetCollectionResponseAsync<Reset>($"resets");
    }
}
