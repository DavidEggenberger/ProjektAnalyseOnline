using Microsoft.AspNetCore.Mvc;
using Server.Features.ProjectAnalysisFeature.Domain;
using Server.Features.ProjectAnalysisFeature.Infrastructure;
using Shared.ProjectAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.Features.ProjectAnalysisFeature
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectAnalysisController : ControllerBase
    {
        private readonly ProjectAnalysisRepo _projectAnalysisRepo;
        public ProjectAnalysisController(ProjectAnalysisRepo _projectAnalysisRepo)
        {
            this._projectAnalysisRepo = _projectAnalysisRepo;
        }

        [HttpGet("all")]
        public ActionResult<List<ProjectAnalysisDTO>> GetAllProjectAnalyses()
        {
            return Ok(_projectAnalysisRepo.GetProjectAnalyses().Select(p => p.ToDTO()).ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<ProjectAnalysisDTO> Get(Guid id)
        {
            return Ok(_projectAnalysisRepo.GetProjectAnalysis(id).ToDTO());
        }

        [HttpPost]
        public ActionResult<Guid> CreateProjectAnalysis([FromBody] ProjectAnalysisDTO projectAnalysisDTO)
        {
            var projectAnalysis = ProjectAnalysis.FromDTO(projectAnalysisDTO);

            return Ok(_projectAnalysisRepo.AddProjectAnalysis(projectAnalysis));
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
