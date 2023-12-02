using Microsoft.AspNetCore.Mvc;

namespace Server.Features.ProjectAnalysisFeature
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectAnalysisSearchController : ControllerBase
    {
        [HttpGet]
        public string SearchProjectAnalysis(
            [FromQuery] string keyword
            )
        {
            return "value";
        }
    }
}
