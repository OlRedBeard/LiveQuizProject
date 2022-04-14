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
        static Random rnd = new Random();
        public int Id { get; set; }
        [ForeignKey("User")]
        public User Creator { get; set; }
        public bool IsPublic { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public List<QuizQuestion> Questions { get; set; }
        public List<QuizInstance> Instances { get; set; }

        public Quiz(User creator, bool isPub, string title, string topic)
        {
            this.Creator = creator;
            this.IsPublic = isPub;
            this.Title = title;
            this.Topic = topic;

            Questions = new List<QuizQuestion>();
            Instances = new List<QuizInstance>();
        }

        public Quiz()
        {
            Questions = new List<QuizQuestion>();
            Instances = new List<QuizInstance>();
        }

        public void Shuffle()
        {
            for (int i = 0; i < 100; i++)
            {
                int position1 = rnd.Next(0, Questions.Count);
                int position2 = rnd.Next(0, Questions.Count);

                //hold one answer in memory
                QuizQuestion question = Questions[position1];
                //swap the second answer to the first position
                Questions[position1] = Questions[position2];
                //add the stored answer to the second position
                Questions[position2] = question;
            }
        }

        public void AddQuestion(QuizQuestion question)
        {
            Questions.Add(question);
        }

        public void AddInstance(QuizInstance instance)
        {
            Instances.Add(instance);
        }
    }
}
