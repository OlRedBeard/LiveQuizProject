using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClasses
{
    [Serializable]
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

        public override string ToString()
        {
            string type;
            if (Answers.Count == 2)
                type = "TF";
            else
                type = "MC";

            string prev = Question;

            if (Question.Length > 21)
                prev = Question.Substring(0, 21);

            return type + ": " + prev + "...";
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
