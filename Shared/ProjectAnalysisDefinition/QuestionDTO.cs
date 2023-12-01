using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ProjectAnalysisDefinition
{
    public class QuestionDTO
    {
        public Guid Id { get; set; }
        public QuestionDomainDTO Domain { get; set; }
        public string Keyword { get; set; }
        public string Text { get; set; }
    }
}
