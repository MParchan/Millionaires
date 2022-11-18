using System.ComponentModel.DataAnnotations;

namespace Millionaires.Models
{
    public enum CorrectAnswer
    {
        A, B, C, D
    }
    public class Question
    {
        public int QuestionId { get; set; }
        public string? QuestionContents { get; set; }
        public string? AnswerA { get; set; }
        public string? AnswerB { get; set; }
        public string? AnswerC { get; set; }
        public string? AnswerD { get; set; }
        public CorrectAnswer CorrectAnswer { get; set; }
        [Range(1, 5)]
        public int DifficultyLevel { get; set; }

    }
}
