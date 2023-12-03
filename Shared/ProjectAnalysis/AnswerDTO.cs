using Shared.ProjectAnalysisDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ProjectAnalysis
{
    public class AnswerDTO
    {
        public string Begründung { get; set; }
        public AnswerChoiceDTO Choice { get; set; }
        public QuestionDTO Question { get; set; }
        public List<AnswerChangeDTO> Changes { get; set; }
    }
}
