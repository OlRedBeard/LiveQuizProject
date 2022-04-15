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

        public static string? GetIPbyQuiz(Quiz q)
        {
            try
            {
                string ip = "";
                foreach(QuizInstance qi in q.Instances)
                {
                    if (qi.Completed == false)
                        ip = qi.HostIP;
                }
                return ip;
            }
            catch
            {
                return null;
            }
        }

        public static Quiz GetQuizbyCode(string code)
        {
            Quiz tmp = null;

            try
            {
                using (QuizContext qc = new QuizContext())
                {
                    QuizInstance qi = qc.Instances.Where(x => x.RoomCode == code && x.Completed == false).FirstOrDefault();

                    if (qi != null)
                        tmp = qc.Quizzes.Include(a => a.Instances).Where(x => x.Instances.Contains(qi)).FirstOrDefault();
                }

                return tmp;
            }
            catch
            {
                return tmp;
            }
        }

        public static bool UpdateUser(UserScore score)
        {
            try
            {
                using (QuizContext qc = new QuizContext())
                {
                    User usr = qc.Users.Include(a => a.UserScores).Where(x => x.Id == LoggedInUser.Id).SingleOrDefault();
                    bool exists = false;

                    if (usr != null)
                    {
                        foreach (UserScore us in usr.UserScores)
                        {
                            if (us.QuizName == score.QuizName)
                            {
                                us.Score = score.Score;
                                us.NumQuestions = score.NumQuestions;
                                us.NumCorrect = score.NumCorrect;
                                us.TimeToAnswer = score.TimeToAnswer;
                                exists = true;
                            }
                        }

                        if (!exists)
                            usr.UserScores.Add(score);

                        qc.SaveChanges();
                    }                    
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddInstance(Quiz q, QuizInstance qi)
        {
            try
            {
                using (QuizContext qc = new QuizContext())
                {
                    Quiz result = qc.Quizzes.SingleOrDefault(x => x.Id == q.Id);
                    if (result != null)
                    {
                        result.AddInstance(qi);
                        qc.SaveChanges();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EndInstance(QuizInstance qi)
        {
            try
            {
                using (QuizContext qc = new QuizContext())
                {
                    QuizInstance result = qc.Instances.SingleOrDefault(x => x.Id == qi.Id);
                    if (result != null)
                    {
                        result.Completed = true;
                        qc.SaveChanges();
                    }
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
                    List<Quiz> ret = new List<Quiz>();

                    List<Quiz> list = qc.Quizzes.Include(a => a.Creator).Include(b => b.Instances).Where(x => x.IsPublic == true )
                        .ToList();
                    foreach(Quiz q in list)
                    {           
                        foreach (QuizInstance qi in q.Instances)
                        {
                            if (qi.Completed != true)
                            {
                                ret.Add(q);
                            }
                        }
                                              
                    }
                    return ret;
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
                    List<Quiz> list = qc.Quizzes.Include(a => a.Creator).Include(b => b.Questions).ThenInclude(c => c.Answers).Where(x => x.Creator == LoggedInUser).ToList();
                    return list;
                }
            }
            catch
            {
                return null;
            }
        }

        public List<QuizAnswer> GetAnswers()
        {
            try
            {
                using (QuizContext qc = new QuizContext())
                {
                    List<QuizAnswer> answer = qc.Answers.ToList();
                    return answer;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
