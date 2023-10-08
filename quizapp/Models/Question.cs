using System.ComponentModel.DataAnnotations;

namespace quizapp.Models
{
    public class Question
    {
        public Question()
        {
            Answertables = new HashSet<Answertable>();
        }
        [Key]

        public int Qid { get; set; }

        public string? Questions { get; set; }
        public string? w1Answer { get; set; }
        public string? w2Answer { get; set; }
        public string? w3Answer { get; set; }
        public string? w4Answer { get; set; }
        public string? AnswerDescribes { get; set; }
        public RightAns RightAnswer { get; set; } = RightAns.w1Answer;

        public virtual ICollection<Answertable> Answertables { get; set; }

    }
    public enum RightAns
    {
        w1Answer,
        w2Answer,
        w3Answer,
        w4Answer
    }
}
