using Microsoft.VisualBasic;
using Server.Features.ProjectAnalysisDefinitionFeature;
using Shared;
using Shared.ProjectAnalysis;
using Shared.ProjectAnalysisDefinition;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.Features.ProjectAnalysisFeature.Domain
{
    public class ProjectAnalysis
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Answer> Answers { get; set; }

        public AnswerChoice Overall => (AnswerChoice) AnswerHelper.GetOerallChoice(Answers.Select(s => ((int)s.Choice - 3)).Aggregate((s, t) => s += t));
        public AnswerChoice Society => (AnswerChoice)AnswerHelper.GetOerallChoice(Answers.Where(a => a.Question.Domain == QuestionDomain.Gesellschaft).Select(s => ((int)s.Choice - 3)).Aggregate((s, t) => s += t));
        public AnswerChoice Nature => (AnswerChoice)AnswerHelper.GetOerallChoice(Answers.Where(a => a.Question.Domain == QuestionDomain.Umwelt).Select(s => ((int)s.Choice - 3)).Aggregate((s, t) => s += t));
        public AnswerChoice Economic => (AnswerChoice)AnswerHelper.GetOerallChoice(Answers.Where(a => a.Question.Domain == QuestionDomain.Wirtschaft).Select(s => ((int)s.Choice - 3)).Aggregate((s, t) => s += t));

    public ProjectAnalysisDTO ToDTO()
        {
            return new ProjectAnalysisDTO
            {
                Id = Id,
                ProjectName = ProjectName,
                CreationDate = CreationDate,
                Answers = Answers?.Select(a => a.ToDTO()).ToList()
            };
        }

        public static ProjectAnalysis FromDTO(ProjectAnalysisDTO projectAnalysisDTO)
        {
            return new ProjectAnalysis
            {
                Id = projectAnalysisDTO.Id,
                CreationDate= projectAnalysisDTO.CreationDate,
                ProjectName = projectAnalysisDTO.ProjectName,
                Answers = projectAnalysisDTO.Answers.Select(a => Answer.FromDTO(a, a.Question)).ToList()
            };
        }
    }
}
