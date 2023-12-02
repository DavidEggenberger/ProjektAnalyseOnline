using Shared.ProjectAnalysisDefinition;
using System;
using System.Collections.Generic;

namespace Server.Features.ProjectAnalysisDefinitionFeature
{
    public class Question
    {
        public Guid Id { get; set; }
        public QuestionDomain Domain { get; set; }
        public string Keyword { get; set; }
        public string Text { get; set; }

        public QuestionDTO ToDTO()
        {
            return new QuestionDTO
            {
                Domain = (QuestionDomainDTO)Domain,
                Keyword = Keyword,
                Text = Text,
                Id = Id
            };
        }
    }
}
