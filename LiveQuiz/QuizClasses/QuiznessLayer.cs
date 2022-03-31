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
    }
}
