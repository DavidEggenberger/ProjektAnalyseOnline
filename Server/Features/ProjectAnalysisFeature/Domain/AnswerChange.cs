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
    }
}
