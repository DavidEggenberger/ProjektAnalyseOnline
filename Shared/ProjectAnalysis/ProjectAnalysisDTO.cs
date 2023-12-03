using Shared.ProjectAnalysisDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ProjectAnalysis
{
    public class ProjectAnalysisDTO
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime CreationDate { get; set; }
        public List<AnswerDTO> Answers { get; set; }

        public AnswerChoiceDTO Overall => AnswerHelper.GetOerallChoice(Answers.Select(s => ((int)s.Choice - 3)).Aggregate((s, t) => s += t));
        public AnswerChoiceDTO Society => AnswerHelper.GetOerallChoice(Answers.Where(a => a.Question.Domain == QuestionDomainDTO.Gesellschaft).Select(s => ((int)s.Choice - 3)).Aggregate((s, t) => s += t));
        public AnswerChoiceDTO Nature => AnswerHelper.GetOerallChoice(Answers.Where(a => a.Question.Domain == QuestionDomainDTO.Umwelt).Select(s => ((int)s.Choice - 3)).Aggregate((s, t) => s += t));
        public AnswerChoiceDTO Economic => AnswerHelper.GetOerallChoice(Answers.Where(a => a.Question.Domain == QuestionDomainDTO.Wirtschaft).Select(s => ((int)s.Choice - 3)).Aggregate((s, t) => s += t));
    }
}
