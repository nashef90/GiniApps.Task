using GiniApps.Task.Logic.Models.GitHub;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace GiniApps.Task.Extentions
{
    internal static class ExtentionMethods
    {
        private const string BOOKMARKS_KEY = "bookmarks";

        internal static List<SearchResultItem> GetBookmarks(this HttpContext httpContent)
        {
            var sessionJson = httpContent.Session.GetString(BOOKMARKS_KEY);
            List<SearchResultItem>? data = null;
            if (!string.IsNullOrWhiteSpace(sessionJson))
            {
                data = JsonConvert.DeserializeObject<List<SearchResultItem>>(sessionJson) ?? new();
            }
            return data ?? new();
        }

        internal static List<SearchResultItem> SetBookmarks(this HttpContext httpContent, List<SearchResultItem> data)
        {
            data ??= new();
            var json = JsonConvert.SerializeObject(data);
            httpContent.Session.SetString(BOOKMARKS_KEY, json);
            return data;
        }

    }
}
