using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClasses
{
    public class QuizQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public List<QuizAnswer> Answers { get; set; }
    }
}
