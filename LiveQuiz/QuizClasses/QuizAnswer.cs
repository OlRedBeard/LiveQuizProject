using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClasses
{
    [Serializable]
    public class QuizAnswer
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool Correct { get; set; }

        public QuizAnswer(string answer, bool correct)
        {
            this.Answer = answer;
            this.Correct = correct;
        }
    }
}
