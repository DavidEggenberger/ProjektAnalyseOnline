using Server.Features.ProjectAnalysisDefinitionFeature;
using Server.Features.ProjectAnalysisFeature.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.Features.ProjectAnalysisFeature.Infrastructure
{
    public class ProjectAnalysisRepo
    {
        private List<ProjectAnalysis> projectAnalyses;

        public ProjectAnalysisRepo()
        {
            var rnd = new Random();

            projectAnalyses = new List<ProjectAnalysis>()
            {
                new ProjectAnalysis
                {
                    Id = Guid.NewGuid(),
                    ProjectName = "Spielplatz St.Fiden",
                    CreationDate = DateTime.Now.AddHours(-rnd.Next(90)),
                    Answers = ProjectAnalysisDefinition.GetAllQuestions().Select(q => new Answer
                    {
                        Choice = (AnswerChoice)rnd.Next(0, 7),
                        Question = q,
                    }).ToList(),
                },
                new ProjectAnalysis
                {
                    Id = Guid.NewGuid(),
                    ProjectName = "Neue Brunnenbergstrasse",
                    CreationDate = DateTime.Now.AddHours(-rnd.Next(4)),
                    Answers = ProjectAnalysisDefinition.GetAllQuestions().Select(q => new Answer
                    {
                        Choice = (AnswerChoice)rnd.Next(0, 7),
                        Question = q
                    }).ToList(),
                }
            };
        }

        public List<ProjectAnalysis> GetProjectAnalyses()
        {
            return projectAnalyses;
        }

        public List<ProjectAnalysis> SearchProjectAnalyses(string searchWord)
        {
            return projectAnalyses.Where(s => s.ProjectName.ToLower().Contains(searchWord.ToLower())).ToList();
        }

        public ProjectAnalysis GetProjectAnalysis(Guid id)
        {
            return projectAnalyses.First(p => p.Id == id);
        }

        public Guid AddProjectAnalysis(ProjectAnalysis projectAnalysis)
        {
            projectAnalysis.Id = Guid.NewGuid();
            projectAnalyses.Add(projectAnalysis);

            return projectAnalysis.Id;
        }
    }
}
