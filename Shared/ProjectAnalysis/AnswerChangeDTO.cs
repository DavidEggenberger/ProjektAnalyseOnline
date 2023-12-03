using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ProjectAnalysis
{
    public class AnswerChangeDTO
    {
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public AnswerChoiceDTO Start { get; set; }
        public AnswerChoiceDTO End { get; set; }
        public Guid QuestionId { get; set; }
        public Guid AnalysisId { get; set; }
    }
}
