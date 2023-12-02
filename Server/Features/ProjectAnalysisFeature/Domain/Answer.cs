using Server.Features.ProjectAnalysisDefinitionFeature;
using Shared.ProjectAnalysis;

namespace Server.Features.ProjectAnalysisFeature.Domain
{
    public class Answer
    {
        public string Begründung { get; set; }
        public AnswerChoice Choice { get; set; }
        public Question Question { get; set; }

        public AnswerDTO ToDTO()
        {
            return new AnswerDTO
            {
                Begründung = Begründung,
                Choice = (AnswerChoiceDTO)Choice,
                Question = Question.ToDTO()
            };
        }
    }
}
