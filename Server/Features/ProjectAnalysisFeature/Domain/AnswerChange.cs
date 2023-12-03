using Shared.ProjectAnalysis;
using System;

namespace Server.Features.ProjectAnalysisFeature.Domain
{
    public class AnswerChange
    {
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public AnswerChoice Start { get; set; }
        public AnswerChoice End { get; set; }

        public AnswerChangeDTO ToDTO()
        {
            return new AnswerChangeDTO
            {
                Date =Date,
                Reason = Reason,
                End = (AnswerChoiceDTO)End,
                Start = (AnswerChoiceDTO)Start,
            };
        }

        public static AnswerChange FromDTO(AnswerChangeDTO answerChange)
        {
            return new AnswerChange
            {
                Date = answerChange.Date,
                Reason = answerChange.Reason,
                End = (AnswerChoice)answerChange.End,
                Start = (AnswerChoice)answerChange.Start,
            };
        }
    }
}
