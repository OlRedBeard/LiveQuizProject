using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClasses
{
    public class QuiznessLayer
    {
        public static User LoggedInUser = null;

        public static bool Register(User u)
        {
            try
            {
                using (QuizContext qc = new QuizContext())
                {
                    qc.Add(u);
                    qc.SaveChanges();                    
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddQuiz(Quiz q)
        {
            try
            {
                using (QuizContext qc = new QuizContext())
                {
                    qc.Entry(q.Creator).State = EntityState.Unchanged;
                    qc.Add(q);
                    qc.SaveChanges();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Login(string username, string hashedPass)
        {
            try
            {
                using (QuizContext qc = new QuizContext())
                {
                    int count = qc.Users.Where(x => x.Username == username && x.Password == hashedPass).Count();
                    if (count < 1)
                        return false;
                    else
                    {
                        LoggedInUser = qc.Users.Where(x => x.Username == username && x.Password == hashedPass).FirstOrDefault();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckAvailableUserName(string username)
        {
            try
            {
                using (QuizContext qc = new QuizContext())
                {
                    int count = qc.Users.Where(x => x.Username == username).Count();
                    if (count < 1)
                        return true;
                    else
                    {
                        LoggedInUser = qc.Users.Where(x => x.Username == username).FirstOrDefault();
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static List<Quiz> GetPublicQuizzes()
        {
            try
            {
                using (QuizContext qc = new QuizContext())
                {
                    List<Quiz> list = qc.Quizzes.Include(a => a.Creator).Where(x => x.IsPublic == true).ToList();
                    return list;
                }
            }
            catch
            {
                return null;
            }
        }

        public static List<Quiz> GetYourQuizzes()
        {
            try
            {
                using (QuizContext qc = new QuizContext())
                {
                    List<Quiz> list = qc.Quizzes.Include(a => a.Creator).Include(b => b.Questions).Where(x => x.Creator == LoggedInUser).ToList();
                    return list;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
