using Microsoft.VisualBasic;
using Shared.ProjectAnalysis;
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

        public ProjectAnalysisDTO ToDTO()
        {
            return new ProjectAnalysisDTO
            {
                ProjectName = ProjectName,
                CreationDate = CreationDate,
                Answers = Answers?.Select(a => a.ToDTO()).ToList()
            };
        }

        public static ProjectAnalysis FromDTO(ProjectAnalysisDTO projectAnalysisDTO)
        {
            return new ProjectAnalysis
            {
                CreationDate= projectAnalysisDTO.CreationDate,
                ProjectName = projectAnalysisDTO.ProjectName,
                Answers = projectAnalysisDTO.Answers.Select(a => Answer.FromDTO(a, a.Question)).ToList()
            };
        }
    }
}
