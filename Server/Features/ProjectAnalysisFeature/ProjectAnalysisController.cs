using Microsoft.AspNetCore.Mvc;
using Server.Features.ProjectAnalysisDefinitionFeature;
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

        [HttpGet("new")]
        public ActionResult<List<ProjectAnalysisDTO>> GetNewProjectAnalysis()
        {
            return Ok(new ProjectAnalysisDTO
            {
                CreationDate = DateTime.Now,
                Answers = ProjectAnalysisDefinition.GetAllQuestions().Select(q => new AnswerDTO
                {
                    Question = q.ToDTO(),
                    Changes = new List<AnswerChangeDTO>(),
                    Choice = AnswerChoiceDTO.neutral
                }).ToList()
            }); 
        }

        [HttpGet("excel")]
        public ActionResult<List<ProjectAnalysisDTO>> GetExcelForProjectAnalysis()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<ProjectAnalysisDTO> Get(Guid id)
        {
            return Ok(_projectAnalysisRepo.GetProjectAnalysis(id).ToDTO());
        }

        [HttpGet("question/{id}")]
        public ActionResult<List<AnswerChangeDTO>> GetAnswerHistory(Guid id)
        {
            var answer = _projectAnalysisRepo.GetProjectAnalyses().SelectMany(s => s.Answers).Where(a => a.Question.Id == id).FirstOrDefault();

            

            return Ok(answer.Changes.Select(c => c.ToDTO()));
        }

        [HttpPost]
        public ActionResult<Guid> CreateProjectAnalysis([FromBody] ProjectAnalysisDTO projectAnalysisDTO)
        {
            foreach (var answer in projectAnalysisDTO.Answers)
            {
                answer.Question.Date = DateTime.Now;
            }

            var projectAnalysis = ProjectAnalysis.FromDTO(projectAnalysisDTO);

            return Ok(_projectAnalysisRepo.AddProjectAnalysis(projectAnalysis));
        }

        [HttpPut("{id}")]
        public ActionResult CreateProjectAnalysis([FromRoute] Guid id, [FromBody] AnswerChangeDTO changeDTO)
        {
            var answer = _projectAnalysisRepo.GetProjectAnalysis(id).Answers.Where(a => a.Question.Id == changeDTO.QuestionId).FirstOrDefault();

            if (answer.Changes == null)
            {
                answer.Changes = new List<AnswerChange>();
            }

            answer.Changes.Add(AnswerChange.FromDTO(changeDTO));

            answer.Choice = (AnswerChoice) changeDTO.End;

            return Ok();
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
