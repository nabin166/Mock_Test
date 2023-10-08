using System.ComponentModel.DataAnnotations;

namespace quizapp.Models
{
    public class User
    {
        public User()
        {
            Questions = new HashSet<Question>();
        }
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        

    }
}
