using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClasses
{
    [Serializable]
    public class Anon : User
    {
        public Anon(string name)
        {
            this.Username = name;
            this.Password = null;
        }
    }
}
