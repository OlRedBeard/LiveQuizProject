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
        static Random rnd = new Random();
        public int Id { get; set; }
        public string Question { get; set; }
        public List<QuizAnswer> Answers { get; set; }

        public QuizQuestion(string question)
        {
            this.Question = question;
            Answers = new List<QuizAnswer>();
        }

        public void AddAnswer(QuizAnswer answer)
        {
            Answers.Add(answer);
        }

        public void Shuffle()
        {
            for (int i = 0; i < 100; i++)
            {
                int position1 = rnd.Next(0, Answers.Count);
                int position2 = rnd.Next(0, Answers.Count);

                //hold one answer in memory
                QuizAnswer answer = Answers[position1];
                //swap the second answer to the first position
                Answers[position1] = Answers[position2];
                //add the stored answer to the second position
                Answers[position2] = answer;
            }
        }
    }
}
