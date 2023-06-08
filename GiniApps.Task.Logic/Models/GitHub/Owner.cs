using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiniApps.Task.Logic.Models.GitHub
{
    internal class Owner
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("node_id")]
        public string NodeID { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarURL { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarID { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("html_url")]
        public string HtmlURL { get; set; }

        [JsonProperty("followers_url")]
        public string FollowersURL { get; set; }

        [JsonProperty("following_url")]
        public string FollowingURL { get; set; }

        [JsonProperty("gists_url")]
        public string GistsURL { get; set; }

        [JsonProperty("starred_url")]
        public string StarredURL { get; set; }

        [JsonProperty("subscriptions_url")]
        public string SubscriptionsURL { get; set; }

        [JsonProperty("organizations_url")]
        public string OrganizationsURL { get; set; }

        [JsonProperty("repos_url")]
        public string ReposURL { get; set; }

        [JsonProperty("events_url")]
        public string EventsURL { get; set; }

        [JsonProperty("received_events_url")]
        public string ReceivedEventsURL { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }
    }
}