using Shared.ProjectAnalysis;
using System;

namespace Shared
{
    public class AnswerHelper
    {
        public static AnswerChoiceDTO GetChoice(int d)
        {
            return d switch
            {
                -3 => AnswerChoiceDTO.starkNegativ,
                -2 => AnswerChoiceDTO.negativ,
                -1 => AnswerChoiceDTO.tendenziellNegativ,
                0 => AnswerChoiceDTO.neutral,
                1 => AnswerChoiceDTO.tendenziellPositiv,
                2 => AnswerChoiceDTO.positiv,
                3 => AnswerChoiceDTO.starkPositiv,
            };
        }

        public static AnswerChoiceDTO GetOerallChoice(decimal d)
        {
            Console.WriteLine(d);
            return Math.Round(d / 6) switch
            {
                -3 => AnswerChoiceDTO.starkNegativ,
                -2 => AnswerChoiceDTO.negativ,
                -1 => AnswerChoiceDTO.tendenziellNegativ,
                1 => AnswerChoiceDTO.tendenziellPositiv,
                2 => AnswerChoiceDTO.positiv,
                3 => AnswerChoiceDTO.starkPositiv,
                _ => AnswerChoiceDTO.neutral
            };
        }

        public static AnswerChoiceDTO GetOerallOverallChoice(decimal d)
        {
            Console.WriteLine(d);
            return Math.Round(d / 18) switch
            {
                -3 => AnswerChoiceDTO.starkNegativ,
                -2 => AnswerChoiceDTO.negativ,
                -1 => AnswerChoiceDTO.tendenziellNegativ,
                1 => AnswerChoiceDTO.tendenziellPositiv,
                2 => AnswerChoiceDTO.positiv,
                3 => AnswerChoiceDTO.starkPositiv,
                _ => AnswerChoiceDTO.neutral
            };
        }
    }
}
