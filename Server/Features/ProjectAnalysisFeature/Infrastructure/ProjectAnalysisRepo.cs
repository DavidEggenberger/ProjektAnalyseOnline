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
                        Changes = new List<AnswerChange>()
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
                        Question = q,
                        Changes = new List<AnswerChange>()
                    }).ToList(),
                }
            };
        }

        public List<ProjectAnalysis> GetProjectAnalyses()
        {
            return projectAnalyses;
        }

        public List<ProjectAnalysis> SearchProjectAnalyses(string searchWord, AnswerChoice? choice)
        {
            if(searchWord == null && choice != null)
            {
                return projectAnalyses.Where(s => s.Overall == choice).ToList();
            }
            if (searchWord != null && choice != null)
            {
                return projectAnalyses.Where(s => s.ProjectName.ToLower().Contains(searchWord.ToLower()) && s.Overall == choice).ToList();
            }

            return projectAnalyses.Where(s => s.ProjectName.ToLower().Contains(searchWord.ToLower())).ToList();
        }

        public ProjectAnalysis GetProjectAnalysis(Guid id)
        {
            var p = projectAnalyses.First(p => p.Id == id);

            return p;
        }

        public void Update(Guid id, ProjectAnalysis projectAnalysis)
        {
            var proj = projectAnalyses.First(p => p.Id == id);

            foreach (var item in projectAnalysis.Answers.Where(a => a.Changes != null && a.Changes.Any()))
            {
                var v = proj.Answers.First(a => a.Question.Text == item.Question.Text);

                v.Choice = item.Changes.Last().End;
                v.Changes = item.Changes;
            }
        }

        public void Remove(Guid id)
        {
            var proj = projectAnalyses.First(p => p.Id == id);

            projectAnalyses.Remove(proj);
        }

        public Guid AddProjectAnalysis(ProjectAnalysis projectAnalysis)
        {
            projectAnalysis.Id = Guid.NewGuid();
            projectAnalyses.Add(projectAnalysis);

            return projectAnalysis.Id;
        }
    }
}
