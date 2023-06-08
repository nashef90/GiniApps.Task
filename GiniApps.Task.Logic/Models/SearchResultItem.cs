using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiniApps.Task.Logic.Models.GitHub
{
    public class SearchResultItem
    {
        public int ID { get; set; }
        public string? RepoName { get; set; }
        public string? AvatarURL { get; set; }
        public bool Bookmarked { get; set; }
    }
}
