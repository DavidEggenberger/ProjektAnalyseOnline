using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ProjectAnalysis
{
    public class ProjectAnalysisDTO
    {
        public string ProjectName { get; set; }
        public DateTime CreationDate { get; set; }
        public List<AnswerDTO> Answers { get; set; }
    }
}
