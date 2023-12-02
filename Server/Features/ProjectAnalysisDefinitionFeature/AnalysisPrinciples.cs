using Shared.ProjectAnalysisDefinition;
using System.Collections.Generic;

namespace Server.Features.ProjectAnalysisDefinitionFeature
{
    public class AnalysisPrinciples
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public List<string> Aspects { get; set; }

        public AnalysisPrinciplesDTO ToDTO()
        {
            return new AnalysisPrinciplesDTO
            {
                Title = Title,
                ShortDescription = ShortDescription,
                Aspects = Aspects
            };
        }
    }
}
