using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClasses
{
    [Serializable]
    public class UserScore
    {
        public int Id { get; set; }
        public string QuizName { get; set; }
        public int Score { get; set; }
        public int NumQuestions { get; set; }
        public int NumCorrect { get; set; }
        public int TimeToAnswer { get; set; }
    }
}
