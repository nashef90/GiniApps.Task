using GiniApps.Task.Extentions;
using GiniApps.Task.Logic.Interfaces;
using GiniApps.Task.Logic.Models.GitHub;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace GiniApps.Task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GithubController : ControllerBase
    {

        private readonly ILogger<GithubController> _logger;
        private readonly IGitHubLogic _githubLogic;


        public GithubController(ILogger<GithubController> logger, IGitHubLogic githubLogic)
        {
            _logger = logger;
            _githubLogic = githubLogic;
        }

        [HttpGet("Search")]
        [ProducesResponseType(typeof(List<SearchResultItem>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<SearchResultItem>>> SearchAsync([FromQuery] string value)
        {
            _logger.LogInformation($"> SearchAsync [Value = '{value}']");
            try
            {
                var bookmarkIds = HttpContext.GetBookmarks().Select(x => x.ID).ToList();
                var result = await _githubLogic.SearchAsync(value, bookmarkIds);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "SearchAsync exception");
                return StatusCode((int)HttpStatusCode.InternalServerError, $"SearchAsync exception '{ex.Message}'");
            }
        }


        [HttpGet("Bookmarks")]
        [ProducesResponseType(typeof(List<SearchResultItem>), StatusCodes.Status200OK)]
        public ActionResult GetBookmarks()
        {
            _logger.LogInformation($"> Get Bookmarks");
            return Ok(HttpContext.GetBookmarks());
        }
    }
}