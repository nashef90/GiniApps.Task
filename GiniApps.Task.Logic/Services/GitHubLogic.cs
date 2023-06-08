using GiniApps.Task.Logic.Interfaces;
using GiniApps.Task.Logic.Models.GitHub;
using RestSharp.Serializers.NewtonsoftJson;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GiniApps.Task.Logic.Services
{
    internal class GitHubLogic : IGitHubLogic
    {
        private readonly RestClient _httpClient;

        public GitHubLogic()
        {
            _httpClient = new RestClient("https://api.github.com", configureSerialization: s => s.UseNewtonsoftJson());
        }

        public async Task<List<SearchResultItem>> SearchAsync(string value, List<int> bookmarkIds)
        {
            var request = new RestRequest($"search/repositories?q={value}");
            var response = await _httpClient.GetAsync(request);
            if ((response?.IsSuccessStatusCode ?? false) && !string.IsNullOrWhiteSpace(response.Content))
            {
                var responseResult = JsonConvert.DeserializeObject<SearchResponse>(response.Content);
                return responseResult?.Items?
                    .Select(x => new SearchResultItem()
                    {
                        ID = x.ID,
                        RepoName = x?.Name,
                        AvatarURL = x?.Owner?.AvatarURL,
                        Bookmarked = bookmarkIds?.Contains(x.ID) ?? false
                    })
                    .ToList() ?? new();
            }
            throw new Exception($"Unable to make the request to GitHub, StatusCode: {response?.StatusCode}");
        }
    }
}
