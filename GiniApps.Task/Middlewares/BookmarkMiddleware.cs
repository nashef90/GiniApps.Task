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
using GiniApps.Task.Extentions;

namespace GiniApps.Task.Middlewares
{
    internal class BookmarkMiddleware
    {
        private readonly RequestDelegate _next;

        public BookmarkMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async System.Threading.Tasks.Task Invoke(HttpContext context)
        {
            var req = context.Request;
            var id = context.Session.Id;
            if (req.Method.ToLower() == Method.Post.ToString().ToLower() && req.Path.ToString().ToLower().EndsWith("api/github/setbookmark"))
            {
                var bodyJson = await GetRequestBody(req);
                if (!string.IsNullOrWhiteSpace(bodyJson))
                {
                    var item = JsonConvert.DeserializeObject<SearchResultItem>(bodyJson);
                    if (item != null)
                    {
                        List<SearchResultItem>? data = context.GetBookmarks();
                        if (item.Bookmarked && !data.Any(x => x.ID == item.ID))
                        {
                            data.Add(item);
                            context.SetBookmarks(data);
                        }
                        else if (!item.Bookmarked && data.Any(x => x.ID == item.ID))
                        {
                            data.RemoveAll(x => x.ID == item.ID);
                            context.SetBookmarks(data);
                        }
                    }
                    context.Response.StatusCode = 200;
                    return;
                }
            }
            await _next(context);
        }

        private static async Task<string> GetRequestBody(HttpRequest request)
        {
            var bodyStr = "";
            try
            {

                // Allows using several time the stream in ASP.Net Core
                request.EnableBuffering();

                // Rewind, so the core is not lost when it looks the body for the request
                request.Body.Position = 0;

                // Arguments: Stream, Encoding, detect encoding, buffer size 
                // AND, the most important: keep stream opened
                using (var reader = new StreamReader(request.Body, Encoding.UTF8, true, 4096, true))
                {
                    bodyStr = await reader.ReadToEndAsync();
                }

                // Rewind, so the core is not lost when it looks the body for the request
                request.Body.Position = 0;


                return bodyStr;
            }
            catch (Exception ex)
            {
                return $"FormatRequest Exception: '{ex.Message}', {ex}";
            }
        }
    }
}
