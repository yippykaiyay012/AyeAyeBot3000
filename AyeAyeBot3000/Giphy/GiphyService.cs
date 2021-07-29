using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AyeAyeBot3000.Giphy
{
    public class GiphyService
    {
        private HttpClient giphyHttpClient;
        private string giphyToken;
        private IConfiguration configuration;

        public GiphyService(IConfiguration configuration)
        {
            this.configuration = configuration;

            giphyToken = configuration["GiphyKey"];
            giphyHttpClient = new HttpClient { BaseAddress = new Uri("https://api.giphy.com") };
        }

        public async Task<string> GetGif(string subject)
        {
            var result = await giphyHttpClient.GetFromJsonAsync<GiphyResponse>($"/v1/gifs/random?api_key={giphyToken}&tag={subject}");
            return result.Data.ImageUrl;
        }
    }
}
