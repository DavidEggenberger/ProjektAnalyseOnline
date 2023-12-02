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
                    CreationDate = DateTime.Now.AddHours(-rnd.Next(4)),
                    
                },
                new ProjectAnalysis
                {
                    Id = Guid.NewGuid(),
                    ProjectName = "Sanierung Brunnenbergstrasse",
                    CreationDate = DateTime.Now.AddHours(-rnd.Next(4)),

                }
            };
        }

        public List<ProjectAnalysis> GetProjectAnalyses()
        {
            return projectAnalyses;
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
