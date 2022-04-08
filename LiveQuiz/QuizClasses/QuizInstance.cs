using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClasses
{
    public class QuizInstance
    {
        public int Id { get; set; }
        [ForeignKey("Quiz")]
        public Quiz Quiz { get; set; }
        [ForeignKey("User")]
        public User Host { get; set; }
        public string RoomCode { get; set; }
        public bool Completed { get; set; }
        public bool Started { get; set; }
        public List<User> Contestants { get; set; }
    }
}
