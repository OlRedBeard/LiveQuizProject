using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClasses
{
    public class Quiz
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public User Creator { get; set; }
        public bool IsPublic { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public List<QuizQuestion> Questions { get; set; }
    }
}
