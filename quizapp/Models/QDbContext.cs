using Microsoft.EntityFrameworkCore;

namespace quizapp.Models
{
    public class QDbContext:DbContext
    {
        public QDbContext(DbContextOptions options):base(options){
            
        }
    }
}
