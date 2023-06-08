using GiniApps.Task.Logic.Models.GitHub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiniApps.Task.Logic.Interfaces
{
    public interface IGitHubLogic
    {
        Task<List<SearchResultItem>> SearchAsync(string value, List<int> bookmarkIds);
    }
}
