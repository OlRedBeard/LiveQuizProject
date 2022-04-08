using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClasses
{
    public class UserScore
    {
        public int Id { get; set; }
        public string QuizName { get; set; }
        public int Score { get; set; }
    }
}
