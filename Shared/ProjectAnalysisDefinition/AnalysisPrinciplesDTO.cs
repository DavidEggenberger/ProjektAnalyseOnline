using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ProjectAnalysisDefinition
{
    public class AnalysisPrinciplesDTO
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public List<string> Aspects { get; set; }
    }
}
