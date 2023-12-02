using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Features.ProjectAnalysisDefinitionFeature
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectAnalysisDefinitionsController : ControllerBase
    {

        [HttpGet("analysisQuestions")]
        public async Task<ActionResult> GetAnalysisDefinition()
        {
            return Ok(ProjectAnalysisDefinition.GetAllQuestions().Select(q => q.ToDTO()).ToList());
        }

        [HttpGet("analysisPrinciples")]
        public async Task<ActionResult> GetAnalysisPrinciples()
        {
            return Ok(ProjectAnalysisDefinition.GetPrinciples().Select(p => p.ToDTO()).ToList());
        }
    }
}
