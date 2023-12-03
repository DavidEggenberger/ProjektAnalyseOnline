using Microsoft.AspNetCore.Mvc;
using Server.Features.ProjectAnalysisFeature.Domain;
using Server.Features.ProjectAnalysisFeature.Infrastructure;
using Shared.ProjectAnalysis;
using System.Linq;

namespace Server.Features.ProjectAnalysisFeature
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectAnalysisSearchController : ControllerBase
    {
        private readonly ProjectAnalysisRepo _projectAnalysisRepo;
        public ProjectAnalysisSearchController(ProjectAnalysisRepo _projectAnalysisRepo)
        {
            this._projectAnalysisRepo = _projectAnalysisRepo;
        }


        [HttpGet]
        public ActionResult SearchProjectAnalysis(
            [FromQuery] string keyword,
            [FromQuery] int? choice
            )
        {

            return Ok(_projectAnalysisRepo.SearchProjectAnalyses(keyword, (AnswerChoice)choice).Select(p => p.ToDTO()).ToList());
        }
    }
}
