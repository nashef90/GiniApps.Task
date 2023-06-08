using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiniApps.Task.Logic.Interfaces;
using GiniApps.Task.Logic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GiniApps.Task.Logic.Extentions
{
    public static class ExtentionMethods
    {
        public static IServiceCollection AddLogicServices(this IServiceCollection services)
        {
            services?.AddSingleton<IGitHubLogic, GitHubLogic>();
            return services;
        }
    }
}
