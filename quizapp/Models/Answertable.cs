using System.ComponentModel.DataAnnotations;

/**/

namespace quizapp.Models
{
    public class Answertable
    {
        [Key]
        public int AnswertblId { get; set; }
        public int? ChooseAnswer { get; set; }
        public int?  UserId { get; set; }
        public int? QuestionId { get; set; }
        

        public virtual User? User { get; set; }
        public virtual Question? Question { get; set; }

        /*I am from gaindakot*/
        /*Heloo WOrld yxz*/
    }
}
